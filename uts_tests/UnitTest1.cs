using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Text;
namespace uts_tests
{
    [TestClass]
    public class UnitTest1
    {
        private string s_tasks_fp = "tasks_source_code";
        private string s_validator_fnp = "dev_validator_C\\bin\\Debug\\validator.exe";
        [TestMethod]
        public void tm_01_Form_01()
        {
            string s_task_id = "01_Form_01";
            string s_task_exe_ft = "Form_01.exe";
            string s_result = _get_validation_result(s_task_id, s_task_exe_ft);
            Assert.IsTrue(s_result.ToLower().Contains("not ok") == false, "task validation failed!");
        }
        [TestMethod]
        public void tm_01_Form_02()
        {
            string s_task_id = "01_Form_02";
            string s_task_exe_ft = "Form_02.exe";
            string s_result = _get_validation_result(s_task_id, s_task_exe_ft);
            Assert.IsTrue(s_result.ToLower().Contains("not ok") == false, "task validation failed!");
        }
        [TestMethod]
        public void tm_01_Form_03()
        {
            string s_task_id = "01_Form_03";
            string s_task_exe_ft = "Form_03.exe";
            string s_result = _get_validation_result(s_task_id, s_task_exe_ft);
            Assert.IsTrue(s_result.ToLower().Contains("not ok") == false, "task validation failed!");
        }
        [TestMethod]
        public void tm_01_Form_04()
        {
            string s_task_id = "01_Form_04";
            string s_task_exe_ft = "Form_04.exe";
            string s_result = _get_validation_result(s_task_id, s_task_exe_ft);
            Assert.IsTrue(s_result.ToLower().Contains("not ok") == false, "task validation failed!");
        }
        [TestMethod]
        public void tm_01_Form_05()
        {
            string s_task_id = "01_Form_05";
            string s_task_exe_ft = "Form_05.exe";
            string s_result = _get_validation_result(s_task_id, s_task_exe_ft);
            Assert.IsTrue(s_result.ToLower().Contains("not ok") == false, "task validation failed!");
        }
        private string _get_validation_result(string s_task_id, string s_task_exe_ft) {
            Directory.SetCurrentDirectory("..\\..\\..\\");

            string s_task_exe_fnp = s_tasks_fp + "\\" + s_task_id + "\\bin\\Debug\\" + s_task_exe_ft;
            string s_task_code_file = s_tasks_fp + "\\" + s_task_id + "\\code.txt";
            string s_output = this.Run_app(s_validator_fnp, s_task_exe_fnp + " " + s_task_code_file + " " + s_task_exe_ft);
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
