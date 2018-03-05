<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_03";
$cls_Task->s_id = "02_Button_03";
$cls_Task->s_description = "Розміщення кнопки на формі";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_03.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Розміщення кнопки на формі");
$cls_Task->_add_property("Form.Width", "Ширина форми (в пікселях)", "700");
$cls_Task->_add_property("Form.Height", "Висота форми (в пікселях)", "500");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_add_object_creator("Додати об'єкт: Button");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_Close");
$cls_Task->_add_property("btn_Close.Text", "Текст кнопки", "Close");
$cls_Task->_add_property("btn_Close.Width", "Ширина кнопки", "300");
$cls_Task->_add_property("btn_Close.Height", "Висота кнопки", "100");
$cls_Task->_add_property("btn_Close.Location.X", "Ордината кнопки", "200");
$cls_Task->_add_property("btn_Close.Location.Y", "Абсциса кнопки", "250");
$cls_Task->_add_property("btn_Close.ForeColor", "Колір тексту", "Crimson");
$cls_Task->_add_property("btn_Close.Font.Bold", "Жирний текст", "True");
$cls_Task->_add_property("btn_Close.Font.Size", "Розмір шрифту", "22");


$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>