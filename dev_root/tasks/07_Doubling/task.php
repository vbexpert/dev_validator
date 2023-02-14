<?php
session_start();
require("../../main_config.php");
require($s_v_app_root."task_core.php");
$cls_Task = new cls_Task();
//-------------------------------------------------->
$cls_Task->s_title = "Doubling";
$cls_Task->s_id = "07_Doubling";
$cls_Task->s_description = "Як зробити так, щоб Приватбанк подвоїв ваші гроші!";

$cls_Task->_add_step("<b>Опис:</b> <i>дана програма повинна, при натисканні на кнопку, збільшити введене в текстове поле число вдвічі і відобразити результат в напис. Щоб було приємніше створювати програму, уявіть що збільшуватись будуть ваші введені кошти ;)</i>");
$cls_Task->_add_step("1. Створити проект <b>Doubling</b> у рішенні <b>Math</b>.");
$cls_Task->_add_step("2. Налаштувати програму відповідно до специфікації.");
$cls_Task->_add_step("3. Добитися повної валідації програми.");
$cls_Task->_add_step("4. Зберегти програму у папку <b>Production</b>.");
$cls_Task->_add_screen("Вигляд програми","0.png");

$cls_Task->_block_start("Добитися валідації головної форми:", "_form.png");
$cls_Task->_add_property("Availability of Form", "Наявність форми", "");
$cls_Task->_add_property("Application name", "Ім'я програми", "Doubling");
$cls_Task->_add_property("Form.AutoScaleMode", "Режим перерахунку форми", "None");
$cls_Task->_add_property("Form.Text", "Текст Форми", "Збільшення числа вдвічі");
$cls_Task->_add_property("Form.Width", "Ширина", "500");
$cls_Task->_add_property("Form.Height", "Висота", "300");
$cls_Task->_add_property("Font.Size", "Розмір шрифту", "20");
$cls_Task->_add_property("Form.StartPosition", "Початкова позиція", "По центру екрана");
$cls_Task->_block_end();

$cls_Task->_block_start("Розмістити об'єкти на формі:", "_form.png");
$cls_Task->_add_screen("","0.png");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: TextBox (текстове поле)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я поля", "tb_Input");
$cls_Task->_add_property("Text", "Текст поля", "0");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Label (напис)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я напису", "lb_Result");
$cls_Task->_add_property("Text", "Текст напису", "Результат");
$cls_Task->_block_end();

$cls_Task->_block_start("Додати компонент: Button (кнопка)", "_add_object.png");
$cls_Task->_add_property("Exists", "Наявність", "");
$cls_Task->_add_property("Name", "Ім'я", "btn_Doubling");
$cls_Task->_add_property("Text", "Текст", "Подвоїти");
$cls_Task->_add_property("Width", "Ширина кнопки", "250");
$cls_Task->_add_property("Height", "Висота кнопки", "50");
$cls_Task->_block_end();

$cls_Task->_block_start("Сгенерувати подію <b>Click</b> для кнопки: <b>btn_Doubling</b>", "_add_event.png");
$cls_Task->_add_code_validated("Код події:", "private void btn_Doubling_Click(object sender, EventArgs e)
{

}", "");
$cls_Task->_block_end();


$cls_Task->_block_start("Написати код обробника події <b>btn_Doubling_Click</b>:", "_add_code.png");
$cls_Task->_add_code_validated("Вписати код, який вдвічі збільшує введене у tb_Input число, та результат виводить у lb_Result.Text::", "private void btn_Doubling_Click(object sender, EventArgs e)
{       
        //зчитування даних
        int a = int.Parse(tb_Input.Text);
        //обрахунок
        int b = a * 2;
        //виведення даних
        lb_Result.Text = b.ToString();
}", "");
$cls_Task->_add_property("lb_Result.Text", "Текст ", "<i>Значення введене в текстове поле</i>");
$cls_Task->_add_screen("Вигляд програми після введення значення та натискання на кнопку <b>Подвоїти</b>","2.png");
$cls_Task->_block_end();

$cls_Task->s_learn_url = "";
$cls_Task->s_youtube_url = "";
$cls_Task->s_discuss_url = "";
//-------------------------------------------------->
//run:
include($s_v_app_root."t_task.php");
?>