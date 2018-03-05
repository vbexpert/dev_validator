<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_00";
$cls_Task->s_id = "02_Button_00";
$cls_Task->s_description = "Додавання кнопки на форму";

$cls_Task->_add_step("1. Створити рішення <b>Lesson_02</b> і проект <b>Button_00</b>.");
$cls_Task->_add_step("2. Створити форму відповідно специфікації.");
$cls_Task->_add_step("3. Додати на форму кнопку з <b>Панелі елементів</b>.");
$cls_Task->_add_step("4. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("5. Добитися повної валідації програми.");
$cls_Task->_add_step("6. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("7. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_00.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Додавання кнопки на форму");
$cls_Task->_add_object_creator("Додати об'єкт:","Button");
$cls_Task->_add_property("button1.Name", "Ім'я кнопки", "button1");
$cls_Task->_add_property("button1.Text", "Текст кнопки", "button1");






$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>