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

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_05.exe");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Заголовок Форми", "Робота з полем для вводу тексту");
$cls_Task->_add_property("Width", "Ширина форми (в пікселях)", "700");
$cls_Task->_add_property("Height", "Висота форми (в пікселях)", "500");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "36");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: TextBox", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_Input");
$cls_Task->_add_property("Text", "Текст ", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я напису", "lb_Result");
$cls_Task->_add_property("Text", "Текст ", "Тут з'явиться текст при натисканні на кнопку");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Button", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_CopyText");
$cls_Task->_add_property("Text", "Текст кнопки", "Скопіювати текст");
$cls_Task->_block_end();

$cls_Task->s_learn_url = "http://informatics.in.ua/programming_csharp/part_02.php";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>