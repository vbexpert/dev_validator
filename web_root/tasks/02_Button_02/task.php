<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_02";
$cls_Task->s_id = "02_Button_02";
$cls_Task->s_description = "Зміна імені кнопки";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_02.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Зміна імені кнопки");
$cls_Task->_add_property("Form.Width", "Довжина Форми (в пікселях)", "500");
$cls_Task->_add_property("Form.height", "Висота Форми (в пікселях)", "500");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "Manual");
$cls_Task->_add_property("Form.Location.X", "Розміщення форми - Х", "400");
$cls_Task->_add_property("Form.Location.Y", "Розміщення форми - Y", "400");
$cls_Task->_add_object_creator("Додати об'єкт: Button");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_Close");
$cls_Task->_add_property("btn_Close.Text", "Текст кнопки", "Close");


$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>