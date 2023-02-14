<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_04";
$cls_Task->s_id = "03_Button_04";
$cls_Task->s_description = "Розміщення кнопки на формі";

$cls_Task->_add_step("1. Створити проект <b>Button_04</b> у рішенні <b>Button</b>.");
$cls_Task->_add_step("2. Завантажити програму у <b>C-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_add_screen("Вигляд програми:", "0.png");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_04.exe");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Текст Форми", "Подія на кнопці");
$cls_Task->_add_property("Width", "Ширина форми (в пікселях)", "700");
$cls_Task->_add_property("Height", "Висота форми (в пікселях)", "500");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати об'єкт: Button", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я кнопки", "btn_ChangeText");
$cls_Task->_add_property("Text", "Текст кнопки", "Натисни для зміни напису кнопки");
$cls_Task->_add_property("Width", "Ширина кнопки", "250");
$cls_Task->_add_property("Height", "Висота кнопки", "50");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>_Click</b> для кнопки: <b>btn_ChangeText</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_ChangeText_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Написати код події <b>btn_ChangeText_click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "private void btn_ChangeText_Click(object sender, EventArgs e)
{
    btn_ChangeText.Text = \"Вітаю! Напис на кнопці змінено!!!\";
}", "");
$cls_Task->_add_property("Text", "Текст кнопки", "Вітаю! Напис на кнопці змінено!!!");
$cls_Task->_add_screen("Вигляд програми:", "1.png");
$cls_Task->_block_end();

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";

include($s_v_app_root."t_task.php");
?>