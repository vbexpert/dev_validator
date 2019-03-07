<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_05";
$cls_Task->s_id = "02_Button_05";
$cls_Task->s_description = "Робота з полем для вводу тексту";

$cls_Task->_add_step("1. Створити проект <b>Button_05</b> відповідно специфікації у рішенні <b>Button</b> .");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_05.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Заголовок Форми", "Робота з полем для вводу тексту");
$cls_Task->_add_property("Form.Width", "Ширина форми (в пікселях)", "1000");
$cls_Task->_add_property("Form.Height", "Висота форми (в пікселях)", "500");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");

$cls_Task->_add_object_creator("Додати об'єкт: ", "Button");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_Close");
$cls_Task->_add_property("Text", "Текст кнопки", "Закрити");
$cls_Task->_add_property("Width", "Ширина кнопки", "300");
$cls_Task->_add_property("Height", "Висота кнопки", "120");
$cls_Task->_add_property("BackColor", "Колір кнопки", "LightCoral");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "36");
$cls_Task->_add_property("btn_Close_Click", "При натисканні на кнопку", "Закрити форму");

$cls_Task->_add_object_creator("Створити подію Click: ","btn_Close_Click");
$cls_Task->_add_code("Написати код:", "Close();", "");

$cls_Task->_add_object_creator("Додати об'єкт: ", "textBox");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_Input");
$cls_Task->_add_property("Text", "Текст ", "");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "36");

$cls_Task->_add_object_creator("Додати об'єкт: ", "Label");
$cls_Task->_add_property("Name", "Ім'я напису", "lb_Target");
$cls_Task->_add_property("Text", "Текст ", "Тут з'явиться текст при натисканні на кнопку");
$cls_Task->_add_property("Font.Bold", "Жирний текст", "True");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "24");

$cls_Task->_add_object_creator("Додати об'єкт: ", "Button");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_CopyText");
$cls_Task->_add_property("Text", "Текст кнопки", "Скопіювати текст");
$cls_Task->_add_property("Width", "Ширина кнопки", "300");
$cls_Task->_add_property("Height", "Висота кнопки", "120");
$cls_Task->_add_property("BackColor", "Колір кнопки", "PaleGreen");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "36");

$cls_Task->_add_object_creator("Створити подію: ","btn_CopyText_Click");
$cls_Task->_add_code("Написати код:", " lb_Target.Text = tb_Input.Text;", "");

$cls_Task->s_learn_url = "http://informatics.in.ua/programming_csharp/part_02.php";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>