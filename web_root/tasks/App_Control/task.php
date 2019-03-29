<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "App_Control";
$cls_Task->s_id = "App_Control";
$cls_Task->s_description = "Підсумковий урок";
//---------------------------------------->
$cls_Task->_add_step("1. Створити проект <b>App_Control</b> відповідно специфікації у рішенні <b>Control</b>.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");
$cls_Task->_add_screen("Вигляд програми", "target_form.png");
$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "App_Control.exe");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Заголовок", "Підсумковий урок");
$cls_Task->_add_property("Width", "Ширина форми", "500");
$cls_Task->_add_property("Height", "Висота форми", "400");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_add_property("BackColor", "Колір форми", "Білий");
$cls_Task->_add_property("ControlBox", "Кнопки керування вікном ", "Відсутні");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label1");
$cls_Task->_add_property("Text", "Текст", "Обчислення значення функції");
$cls_Task->_add_property("ForeColor", "Колір тексту", "Black");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "16");
$cls_Task->_add_property("Font.Bold", "Накреслення напівжирне", "True");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: PictureBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "pictureBox1");
$cls_Task->_add_property("BackgroundImage", "Фонове зображення", "1.png");
$cls_Task->_add_property("BackgroundImageLayout", "Спосіб відображення фонового малюнку", "Zoom");
$cls_Task->_add_screen("Формула", "1.png");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Button", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "btn_ChangeText");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Сгенерувати подію <b>_Click</b> для кнопки: <b>btn_ChangeText</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_ChangeText_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Написати код події <b>btn_ChangeText_click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "private void btn_ChangeText_Click(object sender, EventArgs e)
{
    btn_ChangeText.Text = \"Напис на кнопці змінено!!!\";
}", "");
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: CheckBox", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "checkBox1");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Сгенерувати подію <b>CheckedChanged</b> для cb: <b>1111</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void checkBox1_CheckedChanged(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();
//---------------------------------------->

$cls_Task->_block_start("Додати об'єкт: RadioButton", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "radioButton1");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Сгенерувати подію <b>CheckedChanged</b> для rb: <b>1111</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void radioButton1_CheckedChanged(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();

//---------------------------------------->
$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>