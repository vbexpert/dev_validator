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
//---------------------------------------->
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
$cls_Task->_add_property("Name", "Ім'я", "pb_Image");
$cls_Task->_add_property("Width", "Розмір", "335");
$cls_Task->_add_property("Height", "Розмір", "85");
$cls_Task->_add_property("BackgroundImage", "Фонове зображення", "1.png");
$cls_Task->_add_property("BackgroundImageLayout", "Спосіб відображення фонового малюнку", "Zoom");
$cls_Task->_add_screen("Формула", "1.png");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label2");
$cls_Task->_add_property("Text", "Текст", "Введіть значення аргументу:");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "14");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label4");
$cls_Task->_add_property("Text", "Текст", "Значення функції:");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "14");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label3");
$cls_Task->_add_property("Text", "Текст", "x=");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "14");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label5");
$cls_Task->_add_property("Text", "Текст", "y=");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "14");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати новий компонент: TextBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_Input");
$cls_Task->_add_property("Text", "Текст ", "");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати новий компонент: TextBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_Result");
$cls_Task->_add_property("Text", "Текст ", "");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Button", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "btn_Calculate");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Сгенерувати подію <b>_Click</b> для кнопки: <b>btn_Calculate</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Calculatet_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Написати код події <b>btn_Calculate_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "
double x, y;
x = double.Parse(tb_Input.Text);
y = (Math.Sqrt(x + 2) - Math.Pow(x, 5)) / (Math.Pow(x, 2) - 7 * x + 4) + 2019;
tb_Result.Text = y.ToString();
", "");
$cls_Task->_add_property("tb_Result.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Button", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "btn_Clear");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Сгенерувати подію <b>_Click</b> для кнопки: <b>btn_Clear</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Clear_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Написати код події <b>btn_Clear_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "
tb_Input.Clear();
tb_Result.Clear();
", "");
$cls_Task->_add_property("tb_Input.Text", "Текст", "");
$cls_Task->_add_property("tb_Result.Text", "Текст", "");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Додати об'єкт: Button", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "btn_Close");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Сгенерувати подію <b>_Click</b> для кнопки: <b>btn_Close</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Close_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_block_start("Написати код події <b>btn_Close_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "
Close();
", "");
$cls_Task->_block_end();
//---------------------------------------->
$cls_Task->_add_screen("Вигляд програми", "target_form.png");

$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>