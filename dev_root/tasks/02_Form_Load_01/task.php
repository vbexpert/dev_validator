<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "02_Form_Load_01";
$cls_Task->s_id = "02_Form_Load_01";
$cls_Task->s_description = "Подія завантаження форми";

$cls_Task->_add_step("1. Створити проект <b>Form_Load_01</b> у рішенні <b>Events</b>.");
$cls_Task->_add_step("2. Детальна інструкція <a href=\"http://informatics.in.ua/programming_csharp/part_03.php\" target=\"_blank\">informatics.in.ua</a>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти програму у папку <b>Production</b>.");
$cls_Task->_add_screen("Вигляд програми","0.png");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Form_Load_01");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Заголовок Форми", "Подія завантаження форми");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>Load</b> для кнопки: <b>Form1</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void Form1_Load(object sender, EventArgs e)
{

}", "");
$cls_Task->_add_screen("Вигляд програми","0.png");
$cls_Task->_block_end();

$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>