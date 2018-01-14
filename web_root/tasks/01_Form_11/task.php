<?php
session_start();
include("../../task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_11";
$cls_Task->s_id = "01_Form_11";
$cls_Task->s_description = "Форма з фоновим малюнком";

$cls_Task->_add_step("1. Додати новий проект <b>Form_11</b> у створене рішення <b>Lesson_01</b>.");
$cls_Task->_add_step("2. Створити Windows форму відповідно специфікації.");
$cls_Task->_add_step("3. Фоновий малюнок на тему Природа імпортувати в <b>Файл ресурсов проекта - Resourses</b>.");
$cls_Task->_add_step("4. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("5. Добитися повної валідації програми.");
$cls_Task->_add_step("6. Зберегти скріншот <b>[Alt+PrintScreen]</b> результатів у папку <b>Production</b>.");
$cls_Task->_add_step("7. Скопіювати програму у папку <b>Production</b>.");
$cls_Task->_add_step("8. Зберегти проект та закрити рішення.");

$cls_Task->_add_step("<hr>");
$cls_Task->_add_step("Для коректної валідації програми: властивість <b>AutoScaleMode</b> - значення <b>None</b>");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_11.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "BackgroundImage - Форма з фоновим малюнком");
$cls_Task->_add_property("Form.Width", "Ширина Форми (в пікселях)", "1024");
$cls_Task->_add_property("Form.Height", "Висота Форми (в пікселях)", "768");
$cls_Task->_add_property("Form.BackgroundImage", "Фонове зображення - 'Природа'", "в Resourses");
$cls_Task->_add_property("Form.BackgroundImageLayout", "Спосіб відображення фонового малюнку", "None");

$cls_Task->s_learn_url = "https://msdn.microsoft.com/ru-ru/library/system.windows.forms.control.backgroundimage(v=vs.110).aspx";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include("../../t_task.php");
?>