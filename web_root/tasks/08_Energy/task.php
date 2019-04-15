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

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label2");
$cls_Task->_add_property("Text", "Текст ", "Радіус:");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label3");
$cls_Task->_add_property("Text", "Текст ", "Діаметр:");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label4");
$cls_Task->_add_property("Text", "Текст ", "Довжина кола:");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label5");
$cls_Task->_add_property("Text", "Текст ", "Площа круга:");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "label6");
$cls_Task->_add_property("Text", "Текст ", "Об'єм сфери:");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Radius");
$cls_Task->_add_property("Text", "Текст ", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Diameter");
$cls_Task->_add_property("Text", "Текст ", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Length");
$cls_Task->_add_property("Text", "Текст ", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Square");
$cls_Task->_add_property("Text", "Текст ", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Extent");
$cls_Task->_add_property("Text", "Текст ", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Button", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "btn_Calculate");
$cls_Task->_add_property("Text", "Текст", "Розрахувати");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>Click</b> для кнопки: <b>btn_Calculate</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Calculate_Click(object sender, EventArgs e)
{
    
}", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Написати код події <b>btn_Calculate_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код:", "

//Зчитування
double Radius = double.Parse(tb_Input.Text);
//Обрахунок
double Diameter = Radius * 2;
double Length = 2 * Math.PI * Radius;
double Square = Math.PI * Math.Pow(Radius,2);
double Extent =  Math.PI * Math.Pow(Radius,3) * 4 / 3;
//Виведення
lb_Radius.Text = Radius.ToString(\"#.##\");
lb_Diameter.Text = Diameter.ToString(\"#.##\");
lb_Length.Text = Length.ToString(\"#.##\");
lb_Square.Text = Square.ToString(\"#.##\");
lb_Extent.Text = Extent.ToString(\"#.##\");

", "");
$cls_Task->_add_property("lb_Radius.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Diameter.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Length.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Square.Text", "Текст ", "<i>Розраховані програмою значення</i>");
$cls_Task->_add_property("lb_Extent.Text", "Текст ", "<i>Розраховані програмою значення</i>");
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

$cls_Task->_block_end();
$cls_Task->_block_start("Написати код події <b>btn_Close_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код, який закриє програму:", "Close();", "");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: TextBox", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я поля для вводу", "tb_Info");
$cls_Task->_add_property("Width", "Ширина", "600");
$cls_Task->_add_property("Height", "Висота", "50");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "12");
$cls_Task->_add_property("Multiline", "Багаторядковість", "True");
$cls_Task->_add_property("Text", "Текст ", "Програма для розрахунку розмірностей кола та сфери створена у рамках вивчення програмування обчислювальних проектів.");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати новий компонент: Label", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "lb_Author");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "12");
$cls_Task->_add_property("ForeColor", "Колір тексту", "ControlDarkDark");
$cls_Task->_add_property("Text", "Текст ", "<i>Ввести інформацію про автора згідно зразка</i>");
$cls_Task->_block_end();

$cls_Task->_add_screen("Вигляд програми","0.png");


$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>