#region "imports"
using System;
using System.Reflection;
using System.Windows.Forms;
#endregion

static class mod_main
{
    public static void Main(string[] args)
    {
        //------------------------------>
        //a) load via hardcode:
        //_get_assembly_FormNames("c:\\Users\\Admin\\Desktop\\dev_validator\\WindowsApplication1\\bin\\Debug\\WindowsApplication1.exe");
        //------------------------------>
        //b) load via command line argument:
        String[] arguments = Environment.GetCommandLineArgs();
        string s_fnp = arguments[1];
        Console.WriteLine("Loading assembly: " + s_fnp);
        Console.WriteLine("----------------------------------->");
        _get_assembly_FormNames(s_fnp);
        Console.WriteLine("----------------------------------->");
        Console.WriteLine("press any key to quit...");
        Console.ReadKey();
        //------------------------------>
    }
    private static void _get_assembly_FormNames(string s_fnp)
	{
		//http://stackoverflow.com/questions/465488/can-i-load-a-net-assembly-at-runtime-and-instantiate-a-type-knowing-only-the-na
		//01. загрузка .нет сборки из файла в мастер-объект с помощью "отражения":
        Assembly obj_Assemply = Assembly.LoadFrom(s_fnp);
        //02. получение всех типов объектов внитри сборки:
		Type[] AllTypesInProjects = obj_Assemply.GetTypes();
        //03. итератор по всем типам:
		for (int i = 0; i <= AllTypesInProjects.Length - 1; i++) {
            //04. усли тип = Форма
			if (AllTypesInProjects[i].BaseType == typeof(Form)) {
				//05. создание инстанса формы:
				Form f = (Form)Activator.CreateInstance(AllTypesInProjects[i]);
                //06. показать созданый инстанс формы (что самое удивительное, эту строчку можно закомментировать 
                // - но оно всё равно будет работать :-) форма будет невидимая, но рабочая на 100%):
                f.Show();
                //07. с этой точки сть доступ ко всей програмой начинке:
				Console.WriteLine("Form size: " + f.Height + ":" + f.Width); //размер
				Console.WriteLine(f.GetType() + ":" + f.Name); //тип объекта и его имя
                //08. итератор по всем внутренним контролам внутри формы (лейблы, кнопки, картинки, текстбоксы)
                Console.WriteLine("-- состояние контролов ДО нажатия ---------------------------------->");
                foreach (Control obj_control in f.Controls) 
                {
                    //09. если тип кнопка: 
                    if (obj_control.GetType() == typeof(Button))
                    {
                        Type buttonType = obj_control.GetType();
                        //10. эмулировать нажатия на кнопку через "отражение":
                        MethodInfo clickMethodInfo = typeof(Button).GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
                        clickMethodInfo.Invoke(obj_control, new object[] { EventArgs.Empty });
                        //------------>
                        //11. запускаем цикл ожидания с прокачкой сообщений окнам,
                        //    гарантировано обновить окно формы, чтобы оно получило управляющие сообщения:
                        //    10 циклов по 100 мСек - с обновлением окна (для слабых машин + дать время программе на
                        //    обработку нажатия кнопки) 
                        for (int i2 = 1; i2 <= 10; i2++) 
                        {
                            System.Threading.Thread.Sleep(100); //заморозка потока выполнения на 100 мСек
                            f.Refresh(); //обновление окна
                        }
                        //<------------
                    }
                    //12. отображаем Тип контрола, его Имя и Текст:
                    Console.WriteLine(obj_control.GetType() + "\t title=" + obj_control.Name + "\t value=[" + obj_control.Text + "]");
				}
                //------------------------------------------->
                //13. теперь опять проводим итерацию по всем контролам, но...
                //уже ПОСЛЕ того, как кнопка была нажата и результат попал в ТекстБокс3:
                Console.WriteLine("-- состояние контролов ПОСЛЕ нажатия ---------------------------------->");
                foreach (Control obj_control in f.Controls)
                {
                    //14. отображаем Тип контрола, его Имя и Текст:
                    Console.WriteLine(obj_control.GetType() + "\t title=" + obj_control.Name + "\t value=[" + obj_control.Text + "]");
                }
			}
		}
	}
}