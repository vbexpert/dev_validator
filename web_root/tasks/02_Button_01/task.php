<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_01";
$cls_Task->s_id = "02_Button_01";
$cls_Task->s_description = "Зміна напису кнопки";

$cls_Task->_add_step("1. Створити проект <b>Button_01</b> відповідно специфікації у рішенні <b>Button</b>.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

//$cls_Task->_add_property("Solution name", "Ім'я рішення", "Lesson_02");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_01.exe");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Текст Форми", "Зміна напису кнопки");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "CenterScreen");
$cls_Task->_add_object_creator("Додати об'єкт:", "Button");
$cls_Task->_add_property("Name", "Ім'я кнопки", "button1");
$cls_Task->_add_property("Text", "Текст кнопки", "NewButton");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>