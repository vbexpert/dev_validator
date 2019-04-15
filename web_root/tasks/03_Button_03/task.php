<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_03";
$cls_Task->s_id = "03_Button_03";
$cls_Task->s_description = "Розміщення кнопки на формі";

$cls_Task->_add_step("1. Створити проект <b>Button_03</b> у рішенні <b>Button</b> .");
$cls_Task->_add_step("2. Завантажити програму у <b>C-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_screen("Вигляд програми:", "0.png");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_03.exe");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Текст Форми", "Розміщення кнопки на формі");
$cls_Task->_add_property("Width", "Ширина форми (в пікселях)", "700");
$cls_Task->_add_property("Height", "Висота форми (в пікселях)", "500");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати об'єкт: Button", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_Close");
$cls_Task->_add_property("Text", "Текст кнопки", "Close");
$cls_Task->_add_property("Width", "Ширина кнопки", "300");
$cls_Task->_add_property("Height", "Висота кнопки", "100");
$cls_Task->_add_property("Location.X", "Ордината кнопки", "200");
$cls_Task->_add_property("Location.Y", "Абсциса кнопки", "200");
$cls_Task->_add_property("ForeColor", "Колір тексту", "Crimson");
$cls_Task->_add_property("Font.Bold", "Жирний текст", "True");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "22");

$cls_Task->s_learn_url = "https://docs.google.com/document/d/1ZZgKuX8jBzROxZpQMF0xoWBmxvjeD0nIIPz5oVXdhso/edit?usp=sharing";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>