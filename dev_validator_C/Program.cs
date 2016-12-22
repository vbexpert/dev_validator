#region "imports"

using System;using System.Reflection;using System.Windows.Forms;using System.Collections.Generic;using System.IO;


#endregion
static class mod_main{    private static void Main()    {        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //-------------------------->
        String[] arguments = Environment.GetCommandLineArgs();
        //-------------------------->
        //command line args number:
        if (arguments.GetLength(0) != 3)
        {            _cl("not enough CLAs!");            _cl("press any key to quit...");            Console.ReadKey();            Environment.Exit(0);        }
        //-------------------------->
        string s_assembl_fnp = arguments[1];        string s_profile_fnp = arguments[2];        _cl(Convert.ToString("Loading assembly...")); //+ s_assembl_fnp + " & profile: " + s_profile_fnp);
                                                      //-------------------------->
                                                      //lodaing profile:
        cls_Profile cls_VP = new cls_Profile();        if (File.Exists(s_profile_fnp) == false)
        {            _cl("Profile file not found! " + s_profile_fnp);            _cl("press any key to quit...");            Console.ReadKey();            Environment.Exit(0);        }        string s_buf = File.ReadAllText(s_profile_fnp);        string[] sa_data = s_buf.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);        cls_VP.lst_parametrs = new List<string>(sa_data);
        //trim all:
        for (int i = 0; i <= cls_VP.lst_parametrs.Count - 1; i++)        {            cls_VP.lst_parametrs[i] = cls_VP.lst_parametrs[i].Trim();        }        _cl("----------------------------------->");        _get_assembly_FormNames_and_validate(s_assembl_fnp, cls_VP);        _cl("----------------------------------->");
        //_cl("press any key to quit...")
        //Console.ReadKey()
        //
    }    public static void _cl(string s_msg)    {        Console.WriteLine(s_msg);    }    private static void _get_assembly_FormNames(string s_fnp)    {
        //http://stackoverflow.com/questions/465488/can-i-load-a-net-assembly-at-runtime-and-instantiate-a-type-knowing-only-the-na
        //01. загрузка .нет сборки из файла в мастер-объект с помощью "отражения":
        Assembly obj_Assemply = Assembly.LoadFrom(s_fnp);
        //02. получение всех типов объектов внитри сборки:
        Type[] AllTypesInProjects = obj_Assemply.GetTypes();
        //03. итератор по всем типам:
        for (int i = 0; i <= AllTypesInProjects.Length - 1; i++)
        {
            //04. усли тип = Форма
            if (AllTypesInProjects[i].BaseType == typeof(Form))
            {
                //05. создание инстанса формы:
                Form f = (Form)Activator.CreateInstance(AllTypesInProjects[i]);
                //06. показать созданый инстанс формы (что самое удивительное, эту строчку можно закомментировать 
                // - но оно всё равно будет работать :-) форма будет невидимая, но рабочая на 100%):
                f.Show();
                //07. с этой точки сть доступ ко всей програмой начинке:
                Console.WriteLine("Form size: " + f.Height + ":" + f.Width); //размер
                Console.WriteLine(f.GetType() + ":" + f.Name); //тип объекта и его имя
                                                               //08. итератор по всем внутренним контролам внутри формы (лейблы, кнопки, картинки, текстбоксы)
                Console.WriteLine("-- состояние контролов ДО нажатия ---------------------------------->");                foreach (Control obj_control in f.Controls)                {
                    //09. если тип кнопка: 
                    if (obj_control.GetType() == typeof(Button))                    {                        Type buttonType = obj_control.GetType();
                        //10. эмулировать нажатия на кнопку через "отражение":
                        MethodInfo clickMethodInfo = typeof(Button).GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);                        clickMethodInfo.Invoke(obj_control, new object[] { EventArgs.Empty });
                        //------------>
                        //11. запускаем цикл ожидания с прокачкой сообщений окнам,
                        //    гарантировано обновить окно формы, чтобы оно получило управляющие сообщения:
                        //    10 циклов по 100 мСек - с обновлением окна (для слабых машин + дать время программе на
                        //    обработку нажатия кнопки) 
                        for (int i2 = 1; i2 <= 10; i2++)                        {                            System.Threading.Thread.Sleep(100); //заморозка потока выполнения на 100 мСек
                            f.Refresh(); //обновление окна
                        }
                        //<------------
                    }
                    //12. отображаем Тип контрола, его Имя и Текст:
                    Console.WriteLine(obj_control.GetType() + "\t title=" + obj_control.Name + "\t value=[" + obj_control.Text + "]");                }
                //------------------------------------------->
                //13. теперь опять проводим итерацию по всем контролам, но...
                //уже ПОСЛЕ того, как кнопка была нажата и результат попал в ТекстБокс3:
                Console.WriteLine("-- состояние контролов ПОСЛЕ нажатия ---------------------------------->");                foreach (Control obj_control in f.Controls)                {
                    //14. отображаем Тип контрола, его Имя и Текст:
                    Console.WriteLine(obj_control.GetType() + "\t title=" + obj_control.Name + "\t value=[" + obj_control.Text + "]");                }            }        }    }    private static void _get_assembly_FormNames_and_validate(string s_fnp, cls_Profile cls_VP)    {
        //http://stackoverflow.com/questions/465488/can-i-load-a-net-assembly-at-runtime-and-instantiate-a-type-knowing-only-the-na
        Assembly obj_Assemply = Assembly.LoadFrom(s_fnp);        Type[] AllTypesInProjects = obj_Assemply.GetTypes();        for (int i = 0; i <= AllTypesInProjects.Length - 1; i++)        {            if (AllTypesInProjects[i].BaseType == typeof(Form))            {
                //Convert Type to Object: 
                Form f = (Form)Activator.CreateInstance(AllTypesInProjects[i]);                _cl("Form size: " + f.Height + ":" + f.Width);                _cl(f.GetType().FullName + ":" + f.Name);
                //
                //_cl("validation score is: " & cls_VP._get_validation_score(f.Controls))
                //
                Console.WriteLine("<div class='val_score'>" + cls_VP._get_validation_score(f.Controls) + " % вірно!</div>");            }        }
        //Console.ReadKey()
    }}public class cls_Profile{    public List<string> lst_parametrs;    public int _get_validation_score(System.Windows.Forms.Control.ControlCollection lst_controls)    {        int i_score = 0;        foreach (string p_loopVariable in lst_parametrs)        {            string p = p_loopVariable;            bool b_control_validated = false;            string[] sa_values = p.Split(Convert.ToChar(":"));
            //syntax:
            //0 = type
            //1 = control name
            //2 = control text
            //-------------------------->
            foreach (Control c in lst_controls)            {                if (c.GetType().FullName == sa_values[0])                {                    if (c.Name == sa_values[1])                    {                        if (c.Text == sa_values[2])                        {                            i_score += Convert.ToInt32(sa_values[3]);                            b_control_validated = true;                            break; // TODO: might not be correct. Was : Exit For
                        }                    }                }            }            if (b_control_validated == false)            {
                //_cl("control validation failed: " + p);
            }            else            {
                //_cl("control validation Ok: " + p);
            }
            //--------------------------<
        }        return i_score;    }}