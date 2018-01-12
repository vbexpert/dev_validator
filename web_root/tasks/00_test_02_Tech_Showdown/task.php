<?php
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
//create UI validation webpage:
$cls_Task->s_title = "[test] Test Code Samples";
$cls_Task->s_id = "00_test_02_Tech_Showdown"; //_exact_ folder name!
$cls_Task->s_description = "[test] Test Code Samples";

//add steps:
//$cls_Task->_add_step("[step-instruction]");
//

//add parameters to be validated:
//template:
$cls_Task->_add_property("Application name", "Ім'я програми", "TestTask_02.exe");
$cls_Task->_add_property("Form", "Form.Width", "673");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/course/view.php?id=1852";
$cls_Task->s_youtube_url = "https://www.youtube.com/watch?v=hP0UsFULLuU&list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>