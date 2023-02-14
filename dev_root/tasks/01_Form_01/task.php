<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Form_01";
$cls_Task->s_id = "01_Form_01";
$cls_Task->s_description = "Моя власна програма із Windows формою";

$cls_Task->_add_step("1. Додати новий проект <b>Form_01</b> у створене рішення <b>WindowsForms</b>.");
$cls_Task->_add_step("https://youtu.be/3eJduWO4EtQ");
$cls_Task->_add_step("2. Створити Windows форму відповідно таблиці специфікації.");
$cls_Task->_add_step("3. Вибрати зі списку потрібну для компіляції програму");
$cls_Task->_add_step("4. Скомпілювати Windows форму, натиснувши зелений трикутник.");
$cls_Task->_add_step("https://youtu.be/VGgci4rdczI");
$cls_Task->_add_step("5. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("6. Добитися повної валідації програми.");
$cls_Task->_add_step("7. Зберегти скріншот <b>[Alt+PrintScreen]</b> результатів у папку <b>Production</b> під іменем <b>Form_01.png</b>");
$cls_Task->_add_step("8. Скопіювати програму у папку <b>Production</b>.");
$cls_Task->_add_step("9. Зберегти проект та закрити рішення.");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_01");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Текст Форми", "Прізвище Ім'я");

//f screen:
$cls_Task->_add_screen("Кінцевий вигляд Форми:", "target_form.png");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=9976";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?t=4m51s";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>