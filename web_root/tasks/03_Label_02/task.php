<?php
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
//create UI validation webpage:
$cls_Task->s_title = "Label_02";
$cls_Task->s_id = "03_Label_02"; //_exact_ folder name!
$cls_Task->s_description = "Тестове завдання із написом.";

//add steps:
//$cls_Task->_add_step("[step-instruction]");
$cls_Task->_add_step("1. Запустити");
$cls_Task->_add_step("2. Створити");
$cls_Task->_add_step("3. Валідувати");


//add parameters to be validated:
//template:
$cls_Task->_add_property("Application name", "Ім'я програми", "Label_02");
$cls_Task->_add_property("<span class=\"btn btn-success\"> Додати об'єкт </span>", "<h5>Label</h5>", "");
$cls_Task->_add_property("Label", "Label.Text", "Привіт!");



$cls_Task->s_youtube_url = "[url-yutube]";
$cls_Task->s_discuss_url = "[url-discussion]";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>