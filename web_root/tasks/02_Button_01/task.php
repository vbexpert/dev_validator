<?php
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
//create UI validation webpage:
$cls_Task->s_title = "Button_01";
$cls_Task->s_id = "02_Button_01"; //_exact_ folder name!
$cls_Task->s_description = "Програма з кнопкою";

//add steps:
$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

//add parameters to be validated:
//template:
//$cls_Task->_add_property("", "", "");
$cls_Task->_add_property("Solution name", "Ім'я рішення", "Lesson_02");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_01.exe");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Знайомство з кнопкою");
$cls_Task->_add_property("", "", "");
$cls_Task->_add_property("button1", "Додати кнопку", "");
$cls_Task->_add_property("button1.Text", "Текст кнопки", "NewButton");


$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf";
$cls_Task->s_discuss_url = "https://vk.com/club106906794";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>