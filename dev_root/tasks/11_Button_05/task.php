<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_05";
$cls_Task->s_id = "03_Button_05";
$cls_Task->s_description = "Робота з полем для вводу тексту";

$cls_Task->_add_step("1. Створити проект <b>Button_05</b> відповідно специфікації у рішенні <b>Button</b> .");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");
$cls_Task->_add_screen("Вигляд програми","target_form.png");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Button_05");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Заголовок Форми", "Робота з полем для вводу тексту");
$cls_Task->_add_property("Width", "Ширина форми", "700");
$cls_Task->_add_property("Height", "Висота форми", "500");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "20");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: TextBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_Input");
$cls_Task->_add_property("Text", "Текст ", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Result");
$cls_Task->_add_property("Text", "Текст ", "Тут з'явиться текст при натисканні на кнопку");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Button", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "btn_CopyText");
$cls_Task->_add_property("Text", "Текст", "Скопіювати текст");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>Click</b> для кнопки: <b>btn_CopyText</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_CopyText_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Написати код події <b>btn_CopyText_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "lb_Result.Text = tb_Input.Text;", "");
$cls_Task->_add_screen("Вигляд програми після введення тексту та натискання на кнопку","2.png");
$cls_Task->_block_end();


$cls_Task->_block_start("Додати новий компонент: Button", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "btn_Close");
$cls_Task->_add_property("Text", "Текст", "Закрити");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>Click</b> для кнопки: <b>btn_Close</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Close_Click(object sender, EventArgs e)
{
    
}", "");

$cls_Task->_block_end();
$cls_Task->_block_start("Написати код події <b>btn_Close_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код, який закриє програму:", "Close();", "");
$cls_Task->_block_end();


$cls_Task->s_learn_url = "http://informatics.in.ua/programming_csharp/part_02.php";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>