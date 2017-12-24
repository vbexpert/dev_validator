<?php
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
//create UI validation webpage:
$cls_Task->s_title = "Form_04";
$cls_Task->s_id = "01_Form_04"; //_exact_ folder name!
$cls_Task->s_description = "Програма з Фоновим зображенням - 'Природа'";

//add steps:
$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

//add parameters to be validated:
//template:
//$cls_Task->_add_property("", "", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_04.exe");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Програма 4");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "CenterScreen");
$cls_Task->_add_property("Form.width", "Довжина Форми (в пікселях)", "600");
$cls_Task->_add_property("Form.height", "Висота Форми (в пікселях)", "400");
$cls_Task->_add_property("Form.BackgroundImage", "Фонове зображення - 'Природа' (загуглити картинку)", "[картинка-фото]");
$cls_Task->_add_property("Form.BackgroundImageLayout", "Спосіб відображення фонового малюнку", "Stretch");
$cls_Task->_add_property("Form.Opacity", "Прозорість вікна", "0.8");

$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf";
$cls_Task->s_discuss_url = "https://vk.com/club106906794";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>