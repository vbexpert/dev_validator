<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_06";
$cls_Task->s_id = "02_Button_06";
$cls_Task->s_description = "Робота з полями для вводу";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_06.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Робота з 2 полями для вводу");
$cls_Task->_add_property("Form.Width", "Ширина форми (в пікселях)", "1000");
$cls_Task->_add_property("Form.Height", "Висота форми (в пікселях)", "500");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");

$cls_Task->_add_object_creator("Додати об'єкт: ", "Button");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_ChangeText");
$cls_Task->_add_property("btn_ChangeText.Text", "Текст кнопки", "Змінити напис");
$cls_Task->_add_property("btn_ChangeText.Width", "Ширина кнопки", "300");
$cls_Task->_add_property("btn_ChangeText.Height", "Висота кнопки", "120");
$cls_Task->_add_property("btn_ChangeText.BackColor", "Колір кнопки", "Crimson");
$cls_Task->_add_property("btn_ChangeText.Font.Size", "Розмір шрифту", "36");

$cls_Task->_add_object_creator("Створити подію для: ","btn_ChangeText");
$cls_Task->_add_code("Написати код:", "private void btn_ChangeText_Click(object sender, EventArgs e)
{
       btn_ChangeText.Text = \"Напис на кнопці змінено!!!\";
}", "");

$cls_Task->_add_property("btn_ChangeText.Text", "Текст кнопки", "Напис на кнопці змінено!!!");

$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>