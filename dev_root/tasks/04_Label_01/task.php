<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_01";
$cls_Task->s_id = "03_Button_01";
$cls_Task->s_description = "Програма з кнопкою";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Form.BackColor.Name", "Колір Форми", "Sienna");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми (немаэ)", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_01.exe");
$cls_Task->_add_property("button1", "Додати кнопку", "");
$cls_Task->_add_property("button1.Text", "Текст кнопки", "BigButton");

$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf";
$cls_Task->s_discuss_url = "https://vk.com/club106906794";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>