using System;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

static class mod_main
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //-------------------------->
        String[] arguments = Environment.GetCommandLineArgs();
        //-------------------------->
        //command line args number:
        if (arguments.GetLength(0) != 4)
        {
            _cl("not enough CLAs!");
            //_cl("press any key to quit...");
            //Console.ReadKey();
            Environment.Exit(0);
        }
        //-------------------------->
        //sevae args:
        string s_assembl_fnp = arguments[1];
        string s_vCodeFile = arguments[2];
        string s_vAppOriginalFT = arguments[3];
        //_cl(Convert.ToString("Loading assembly...")); //+ s_assembl_fnp + " & profile: " + s_profile_fnp);
        //-------------------------->
        //lodaing codefile:
        //-------------------------->
        //check if exists:
        if (File.Exists(s_vCodeFile) == false)
        {
            _cl("code file not found! " + s_vCodeFile);
            Environment.Exit(0);
        }
        if (File.Exists(s_assembl_fnp) == false)
        {
            _cl("assembly not found! " + s_assembl_fnp);
            Environment.Exit(0);
        }
        //-------------------------->
        //main call:
        object r = _compile_run_and_validate(s_vCodeFile, s_assembl_fnp, s_vAppOriginalFT);
        //-------------------------->
        //return result to webpage:
        Console.WriteLine(r); //<div class='val_score'></div>
        //-------------------------->
        if (1 == 1) {
        }
    }

    public static object _compile_run_and_validate(string s_code_file_fnp = "", 
                                                  string s_student_app_fnp = "", 
                                                  string s_vAppOrigina_app_ft = "")
    {
        //read code:
        string s_dynamic_code = File.ReadAllText(s_code_file_fnp);

        //get output-class code:
        string s_output_class_code = global::dev_validator_C.Properties.Resources.output_class;

        //patch:
        s_dynamic_code = s_dynamic_code.Replace("//[validator-class-placeholder]", s_output_class_code);

        //init compiler: https://stackoverflow.com/questions/4063285/missing-assembly-references-in-dynamically-compiled-code
        CSharpCodeProvider obj_CSharpCodeProvider = new CSharpCodeProvider(new Dictionary<String, String> { { "CompilerVersion", "v3.5" } });

        CodeDomProvider obj_CodeDomProvider = CodeDomProvider.CreateProvider("CSharp");

        //init parms:
        System.CodeDom.Compiler.CompilerParameters _CompilerParameters = new System.CodeDom.Compiler.CompilerParameters();

        //init:
        _CompilerParameters.GenerateExecutable = true;
        _CompilerParameters.GenerateInMemory = false;
        _CompilerParameters.WarningLevel = 3;
        _CompilerParameters.TreatWarningsAsErrors = true;
        _CompilerParameters.CompilerOptions = "/target:exe";
        //add refs:
        _CompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
        _CompilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
        _CompilerParameters.ReferencedAssemblies.Add("System.Data.dll");
        _CompilerParameters.ReferencedAssemblies.Add("System.Xml.dll");
        _CompilerParameters.ReferencedAssemblies.Add("System.dll");
        _CompilerParameters.ReferencedAssemblies.Add("System.Core.dll");
        
        //main compile call:
        CompilerResults obj_results = obj_CSharpCodeProvider.CompileAssemblyFromSource(_CompilerParameters, s_dynamic_code);

        //error handling:
        if (obj_results.Errors.HasErrors == true)
        {
            StringBuilder sb = new StringBuilder();
            foreach (CompilerError error in obj_results.Errors)
            {
                sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
            }
            Console.WriteLine(sb.ToString());
        }

        //get main method:
        Assembly assembly = obj_results.CompiledAssembly;
        Type program = assembly.GetType("ns_d_code.cls_Main");

        //-------------------------------------------------------------->
        //get form instance:
        Form f = null;
        //01. загрузка .нет сборки из файла в мастер-объект с помощью "отражения":
        Assembly obj_Assemply = Assembly.LoadFrom(s_student_app_fnp);
        //02. получение всех типов объектов внитри сборки:
        Type[] AllTypesInProjects = obj_Assemply.GetTypes();
        //03. итератор по всем типам:
        for (int i = 0; i <= AllTypesInProjects.Length - 1; i++)
        {
            //04. усли тип = Форма
            if (AllTypesInProjects[i].BaseType == typeof(Form))
            {
                //05. создание инстанса формы:
                f = (Form)Activator.CreateInstance(AllTypesInProjects[i]);
                //
                if (_is_mono()) { //adjust Form deltas for Linux:
                    //adjusts:
                    f.Width = f.Width + 8;
                    f.Height = f.Height + 12;
                }
                goto _form_detected;
            }
        }
        //<--------------------------------------------------------------
        _form_detected:

        //calling validation code:
        MethodInfo main1 = program.GetMethod("test");
        object obj_result = main1.Invoke(null, new object[] { f, s_student_app_fnp, s_vAppOrigina_app_ft });

        //dbg to console:
        Debug.WriteLine(obj_result);

        return obj_result;

    }
    public static void _cl(string s_msg)
    {
        Console.WriteLine(s_msg);
    }
    private static bool _is_mono()
    {
        Type t = Type.GetType("Mono.Runtime");
        if (null != t) return true;
        return false;
    }
}