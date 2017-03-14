using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace dev_DynCC
{
    public partial class Form1 : Form
    {
        public object ReferencedAssemblies { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s_profile_fnp = "code1.txt";
            string s_buf = File.ReadAllText(s_profile_fnp);
            //
            this._compile(s_buf);
        }

        public void _compile(string s_code = "")
        {
            //init compiler:
            CSharpCodeProvider obj_CSharpCodeProvider = new CSharpCodeProvider();
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

            //main compile call:
            CompilerResults obj_results = obj_CSharpCodeProvider.CompileAssemblyFromSource(_CompilerParameters, s_code);

            //error handling:
            if (obj_results.Errors.HasErrors == true) {
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
            Assembly obj_Assemply = Assembly.LoadFrom("WindowsApplication1.exe");
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
                    goto _form_detected;
                }
            }
            //<--------------------------------------------------------------
            _form_detected:

            //calling validation code:
            MethodInfo main1 = program.GetMethod("test");
            object obj_result = main1.Invoke(null, new object[] { f });
            
            MessageBox.Show("validator func returned: " + obj_result);
            
        }
    }
}
