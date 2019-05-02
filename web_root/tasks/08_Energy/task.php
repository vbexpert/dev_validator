<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "08_Energy";
$cls_Task->s_id = "08_Energy";
$cls_Task->s_description = "Енергія";

$cls_Task->_add_step("1. Створити проект <b>Energy</b> відповідно специфікації у рішенні <b>Physics</b> .");
$cls_Task->_add_step("2. Завантажити програму у <b>C-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");
$cls_Task->_add_screen("Вигляд програми - Вкладка <b>Кінетична</b>","0.png");
$cls_Task->_add_screen("Вигляд програми - Вкладка <b>Потенціальна</b>","1.png");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Energy");
$cls_Task->_add_property("AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Text", "Заголовок Форми", "Енергія");
$cls_Task->_add_property("Width", "Ширина форми", "800");
$cls_Task->_add_property("Height", "Висота форми", "600");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "20");
$cls_Task->_add_property("StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: TabControl", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "tc_Energy");
$cls_Task->_add_property("TabPages", "Закладки", "<i>Додати три необхідні закладки згідно зразку</>");
$cls_Task->_block_end();

$cls_Task->_block_start("Налаштувати колекцію TabPages", "_add_object.png");
$cls_Task->_add_property("tabPage1.Text", "Текст", "Кінетична");
$cls_Task->_add_property("tabPage2.Text", "Текст", "Потенціальна");
$cls_Task->_add_property("tabPage3.Text", "Текст", "Пружини");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: TextBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_InfoKinetic");
$cls_Task->_add_property("Multiline", "Багаторядковість", "true");
$cls_Task->_add_property("Text", "Текст ", "Кінетична енергія — частина енергії фізичної системи, яку вона має завдяки руху.");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: PictureBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я зображення", "pb_PictureKinetic");
$cls_Task->_add_property("Size.Width", "Ширина", "200");
$cls_Task->_add_property("Size.Height", "Висота", "150");
$cls_Task->_add_property("BackgroundImage", "Зображення", "Circle.png");
$cls_Task->_add_property("BackgroundImageLayout", "Спосіб відображення", "Zoom");
$cls_Task->_add_screen("Формула кінетичної енергії","kin.png");
$cls_Task->_block_end();



$cls_Task->_block_start("Сгенерувати подію <b>Click</b> для кнопки: <b>btn_Calculate</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Calculate_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Написати код події <b>btn_Calculate_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "

//Зчитування

//Обрахунок

//Виведення


", "");
$cls_Task->_add_screen("Вигляд програми після введення значення та натискання на кнопку","2.png");
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


$cls_Task->_add_screen("Вигляд програми","0.png");


$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>