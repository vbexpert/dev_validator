<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Button_10";
$cls_Task->s_id = "03_Button_10";
$cls_Task->s_description = "Математичний калькулятор";

$cls_Task->_add_step("1. Створити форму відповідно специфікації.");
$cls_Task->_add_step("2. Завантажити програму у <b>DEV-VALIDATOR</b>.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти скріншот [Alt+PrintScreen] результатів у папку <b>Production</b>.");
$cls_Task->_add_step("5. Зберегти програму у папку <b>Production</b>.");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Solution name", "Назва рішення", "Exam");
$cls_Task->_add_property("Application name", "Ім'я програми", "Math_Calc.exe");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Арифметичні операції");
$cls_Task->_add_property("Form.Width", "Ширина форми (в пікселях)", "");
$cls_Task->_add_property("Form.Height", "Висота форми (в пікселях)", "");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "label1");
$cls_Task->_add_property("label1.Text", "Текст ", "Арифметичні операції");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "label2");
$cls_Task->_add_property("label2.Text", "Текст ", "Число a:");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "label3");
$cls_Task->_add_property("label3.Text", "Текст ", "Число b:");

$cls_Task->_block_start("Додати компонент: TextBox (текстове поле)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "tb_Input_a");
$cls_Task->_add_property("tb_Input_a", "Текст ", "");

$cls_Task->_block_start("Додати компонент: TextBox (текстове поле)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я кнопки", "tb_Input_b");
$cls_Task->_add_property("tb_Input_b", "Текст ", "");

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "label4");
$cls_Task->_add_property("label4.Text", "Текст ", "Результат:");

$cls_Task->_block_start("Додати компонент: RichTextBox (редактор тексту)", "_add_object.png");
$cls_Task->_add_property("Name", "Ім'я", "rtb_Result");
$cls_Task->_add_property("rtb_Result.Text", "Текст ", "");

$cls_Task->_add_code("Формат виводу результатів:", "
5 + 7 = 12
5 - 7 = -2
5 * 7 = 35
5 / 7 = 0,7142

", "<i>Виводити результат в даний напис!</i>");

$cls_Task->_add_object_creator("Додати об'єкт: ","Button");
$cls_Task->_add_property("Name", "Ім'я ", "btn_Sum");
$cls_Task->_add_property("btn_Sum.Text", "Текст ", "Сума");
$cls_Task->_add_code("Обробник події Click", "
int a = Int16.Parse(tb_Input_a.Text);
int b = Int16.Parse(tb_Input_a.Text);
int c = a + b;
rtb_Result.Text = tb_Input_a.Text + \" + \" + tb_Input_a.Text + \" = \" + c.ToString();
", "");

$cls_Task->_add_object_creator("Додати об'єкт: ","Button");
$cls_Task->_add_property("Name", "Ім'я ", "btn_Minus");
$cls_Task->_add_property("btn_Minus.Text", "Текст ", "Різниця");
$cls_Task->_add_code("Обробник події Click", "
	Аналогічний попередньому
", "");

$cls_Task->_add_object_creator("Додати об'єкт: ","Button");
$cls_Task->_add_property("Name", "Ім'я ", "btn_Multiply");
$cls_Task->_add_property("btn_Multiply.Text", "Текст ", "Добуток");
$cls_Task->_add_code("Обробник події Click", "
	Аналогічний попередньому
", "");

$cls_Task->_add_object_creator("Додати об'єкт: ","Button");
$cls_Task->_add_property("Name", "Ім'я ", "btn_Division");
$cls_Task->_add_property("btn_Division.Text", "Текст ", "Частка");
$cls_Task->_add_code("Обробник події Click", "
	Аналогічний попередньому
", "");

$cls_Task->s_learn_url = "https://learn.ztu.edu.ua/mod/page/view.php?id=10041";
$cls_Task->s_youtube_url = "https://youtu.be/hP0UsFULLuU";
$cls_Task->s_discuss_url = "https://www.facebook.com/groups/1487277621317029/";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>