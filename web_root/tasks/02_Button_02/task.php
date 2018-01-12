<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_02";
$cls_Task->s_id = "02_Button_02";
$cls_Task->s_description = "Кнопка та її властивості";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Solution name", "Ім'я рішення", "Lesson_02");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_02.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.width", "Довжина Форми (в пікселях)", "400");
$cls_Task->_add_property("Form.height", "Висота Форми (в пікселях)", "300");
$cls_Task->_add_property("Form.BackColor.Name", "Колір Форми", "red");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Прізвище + Ім'я");
$cls_Task->_add_property("Form.Location.X", "Розміщення форми - Х", "200");
$cls_Task->_add_property("Form.Location.Y", "Розміщення форми - Y", "200");

$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf";
$cls_Task->s_discuss_url = "https://vk.com/club106906794";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>