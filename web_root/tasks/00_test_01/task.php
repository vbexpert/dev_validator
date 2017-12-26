<?php
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
//create UI validation webpage:
$cls_Task->s_title = "Нове классне завдання із кнопкою!";
$cls_Task->s_id = "00_test_01"; //_exact_ folder name!
$cls_Task->s_description = "Нове классне завдання із кнопкою!";

//add steps:
//$cls_Task->_add_step("[step-instruction]");
//$cls_Task->_add_step("1. Детальний опис крока - українською!");
$cls_Task->_add_step("2. Детальний опис крока - українською!");
$cls_Task->_add_step("3. Детальний опис крока - українською!");


//add parameters to be validated:
//template:
//$cls_Task->_add_property("Application name", "Ім'я програми", "Form_01.exe");
//$cls_Task->_add_property("Form", "Form.Width", "400");
$cls_Task->_add_property("Form", "Form.Width", "400");
$cls_Task->_add_property("Form", "Form.Width", "400");


$cls_Task->s_youtube_url = "[url-yutube]";
$cls_Task->s_discuss_url = "[url-discussion]";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>