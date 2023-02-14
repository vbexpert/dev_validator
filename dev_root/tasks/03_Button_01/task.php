<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_01";
$cls_Task->s_id = "03_Button_01";
$cls_Task->s_description = "Зміна напису кнопки";

$cls_Task->_add_step("1. Створити проект <b>Button_01</b> у рішенні <b>Button</b>.");
$cls_Task->_add_step("2. Завантажити програму у <b>С-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_screen("Вигляд програми:", "0.png");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_01.exe");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Текст Форми", "Зміна напису кнопки");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "CenterScreen");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати об'єкт: Button", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я кнопки", "button1");
$cls_Task->_add_property("Text", "Текст кнопки", "NewButton");
$cls_Task->_block_end();

$cls_Task->_add_screen("Вигляд програми:", "0.png");

$cls_Task->s_learn_url = "https://docs.google.com/document/d/1ZZgKuX8jBzROxZpQMF0xoWBmxvjeD0nIIPz5oVXdhso/edit?usp=sharing";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>