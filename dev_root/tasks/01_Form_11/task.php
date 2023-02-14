<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_11";
$cls_Task->s_id = "01_Form_11";
$cls_Task->s_description = "Форма з фоновим малюнком";

$cls_Task->_add_step("1. Додати новий проект <b>Form_11</b> у створене рішення <b>WindowsForms</b>.");
$cls_Task->_add_step("2. Створити Windows форму відповідно специфікації.");
$cls_Task->_add_step("3. Фоновий малюнок на тему Природа імпортувати в <b>Файл ресурсов проекта - Resourses</b>.");
$cls_Task->_add_step("4. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("5. Добитися повної валідації програми.");
$cls_Task->_add_step("6. Зберегти скріншот <b>[Alt+PrintScreen]</b> результатів у папку <b>Production</b>.");
$cls_Task->_add_step("7. Скопіювати програму у папку <b>Production</b>.");
$cls_Task->_add_step("8. Зберегти проект та закрити рішення.");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_11");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Текст Форми", "BackgroundImage - Форма з фоновим малюнком");
$cls_Task->_add_property("Size.Width", "Ширина Форми (в пікселях)", "1024");
$cls_Task->_add_property("Size.Height", "Висота Форми (в пікселях)", "768");
$cls_Task->_add_property("BackgroundImage", "Фонове зображення - 'Природа'", "завантажити в Resourses");
$cls_Task->_add_property("BackgroundImageLayout", "Спосіб відображення фонового малюнку", "None");

$cls_Task->_add_screen("Кінцевий вигляд Форми:", "target_form.png");

$cls_Task->s_learn_url = "https://msdn.microsoft.com/ru-ru/library/system.windows.forms.control.backgroundimage(v=vs.110).aspx";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>