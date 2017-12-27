<?php
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
//create UI validation webpage:
$cls_Task->s_title = "[task-title]";
$cls_Task->s_id = "[task-id]"; //_exact_ folder name!
$cls_Task->s_description = "[task-description]";

//add steps:
//$cls_Task->_add_step("[step-instruction]");
//[step-instructions]

//add parameters to be validated:
//template:
//$cls_Task->_add_property("Application name", "Ім'я програми", "Form_01.exe");
//[properties-validation-block-php]

$cls_Task->s_youtube_url = "[url-yutube]";
$cls_Task->s_discuss_url = "[url-discussion]";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>