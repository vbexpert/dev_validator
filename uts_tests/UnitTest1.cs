﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Text;
namespace uts_tests
{
    [TestClass]
    public class UnitTest1
    {
        public string s_tasks_fp = "tasks_source_code";
        public string s_validator_fnp = "dev_validator_C\\bin\\Debug\\validator1.exe";

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            //this is required as validator.exe is being rebuilt (?) for some reason
            //and thus prevents multitests from running in parallel:
            //fix - create a copy:
            string s_original_validator_fnp = "dev_validator_C\\bin\\Debug\\validator.exe";
            string s_validator_fnp = "dev_validator_C\\bin\\Debug\\validator1.exe";
            Directory.SetCurrentDirectory("..\\..\\..\\");
            if (File.Exists(s_validator_fnp)) {
                File.Delete(s_validator_fnp);
            }
            File.Copy(s_original_validator_fnp, s_validator_fnp);
        }
        [TestMethod]
        public void tm_00_test_01()
        {
            string s_task_id = "00_test_01";
            string s_task_exe_ft = "test_01.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_00()
        {
            string s_task_id = "01_Form_00";
            string s_task_exe_ft = "Form_00.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_01()
        {
            string s_task_id = "01_Form_01";
            string s_task_exe_ft = "Form_01.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_02()
        {
            string s_task_id = "01_Form_02";
            string s_task_exe_ft = "Form_02.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_03()
        {
            string s_task_id = "01_Form_03";
            string s_task_exe_ft = "Form_03.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_04()
        {
            string s_task_id = "01_Form_04";
            string s_task_exe_ft = "Form_04.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_05()
        {
            string s_task_id = "01_Form_05";
            string s_task_exe_ft = "Form_05.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_06()
        {
            string s_task_id = "01_Form_06";
            string s_task_exe_ft = "Form_06.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_07()
        {
            string s_task_id = "01_Form_07";
            string s_task_exe_ft = "Form_07.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_08()
        {
            string s_task_id = "01_Form_08";
            string s_task_exe_ft = "Form_08.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_09()
        {
            string s_task_id = "01_Form_09";
            string s_task_exe_ft = "Form_09.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_10()
        {
            string s_task_id = "01_Form_10";
            string s_task_exe_ft = "Form_10.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_11()
        {
            string s_task_id = "01_Form_11";
            string s_task_exe_ft = "Form_11.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_12()
        {
            string s_task_id = "01_Form_12";
            string s_task_exe_ft = "Form_12.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_01_Form_13()
        {
            string s_task_id = "01_Form_13";
            string s_task_exe_ft = "Form_13.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_02_Button_00()
        {
            string s_task_id = "02_Button_00";
            string s_task_exe_ft = "Button_00.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_02_Button_01()
        {
            string s_task_id = "02_Button_01";
            string s_task_exe_ft = "Button_01.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_02_Button_02()
        {
            string s_task_id = "02_Button_02";
            string s_task_exe_ft = "Button_02.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_02_Button_03()
        {
            string s_task_id = "02_Button_03";
            string s_task_exe_ft = "Button_03.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_03_Label_01()
        {
            string s_task_id = "03_Label_01";
            string s_task_exe_ft = "Label_01.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_03_Label_02()
        {
            string s_task_id = "03_Label_02";
            string s_task_exe_ft = "Label_02.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_02_test_02_Tech_Showdown()
        {
            string s_task_id = "00_test_02_Tech_Showdown";
            string s_task_exe_ft = "TestTask_02.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        [TestMethod]
        public void tm_06_2d_graphics_01()
        {
            string s_task_id = "06_2d_graphics_01";
            string s_task_exe_ft = "drawing01.exe";
            string s_result = _validate_task(s_task_id, s_task_exe_ft);
        }
        //[unit-test-insertion-point]
        private string _validate_task(string s_task_id, string s_task_exe_ft) {
            //move validator exe to temp:
            string s_task_exe_fnp = s_tasks_fp + "\\" + s_task_id + "\\bin\\Debug\\" + s_task_exe_ft;
            string s_task_code_file = s_tasks_fp + "\\" + s_task_id + "\\code.txt";
            string s_output = this.Run_app(s_validator_fnp, s_task_exe_fnp + " " + s_task_code_file + " " + s_task_exe_ft);

            string[] stringSeparators = new string[] { "\r\n" };
            string[] sa_lines = s_output.Split(stringSeparators, StringSplitOptions.None);
            foreach (string s_line in sa_lines)
            {
                if (s_line.Contains("reslt")) {
                    Assert.IsTrue(s_line.ToLower().Contains("false") == false, "task validation failed!");
                }
            }
            return s_output;
        }
        public string Run_app(string s_app, string s_cla) 
        {
            string output = string.Empty;
            string error = string.Empty;

            ProcessStartInfo processStartInfo = new ProcessStartInfo(s_app, s_cla);
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
            processStartInfo.UseShellExecute = false;
            processStartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;

            Process process = Process.Start(processStartInfo);
            using (StreamReader streamReader = process.StandardOutput)
            {
                output = streamReader.ReadToEnd();
            }

            using (StreamReader streamReader = process.StandardError)
            {
                error = streamReader.ReadToEnd();
            }

            return output;

        }

    }
}
