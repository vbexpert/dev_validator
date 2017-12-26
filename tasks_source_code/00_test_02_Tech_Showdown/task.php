<?php
include("../../task_core.php");
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
//$cls_Task->_add_property("Application name", "Ім'я програми", "Form_01.exe");
//$cls_Task->_add_property("Form", "Form.Width", "400");


$cls_Task->s_youtube_url = "[url-yutube]";
$cls_Task->s_discuss_url = "[url-discussion]";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>