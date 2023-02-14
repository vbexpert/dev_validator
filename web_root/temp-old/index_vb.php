<?php
session_start();
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
include_once("main_config.php");
?>
<html>
  <head>
    <!-- title -->
    <title>Перевірка:</title>
    <!-- utf8 support: -->
	<?php
	  include_once("head_includes.php");
	?>
	<!-- external CSS: -->
    <link rel="stylesheet" type="text/css" href="_css/global.css">
</head>
<body>
  <div class="container">
    <div class="starter-template">
      <div class="jumbotron task_jumbotron_height_fix">
	   
         <!-- menu stat: -->
	     <?php
            include_once("nav_menu.php");
         ?>
         <!-- menu end: -->
	   
         <!-- header info block start: -------------------------------------------------------------------------------->
		 <?php
		    include_once("header.php");
		 ?>
         <!-- header info block end: -------------------------------------------------------------------------------->
         <hr>
		 <h2 class=''>Доступні завдання:</h2>
		 <!-- task Winforms info block start --------------------------------------------------------------------------------->
		 <hr>	 
		 <h3 class=''>Розділ 1: Знайомство із WindowsForms</h2>
         <div class="task_desc_row"><a href="/validator/tasks/01_Form_00/task.php">Завдання 0: Створення простої Windows форми</a></div>		 
         <div class="task_desc_row"><a href="/validator/tasks/01_Form_01/task.php">Завдання 1: Моя власна програма із Windows Forms</a></div>
         <div class="task_desc_row"><a href="/validator/tasks/01_Form_02/task.php">Завдання 2: Розфарбуйте свою Windows форму</a></div>
         <div class="task_desc_row"><a href="/validator/tasks/01_Form_03/task.php">Завдання 3: Зміна розмірів вікна</a></div>
         <div class="task_desc_row"><a href="/validator/tasks/01_Form_04/task.php">Завдання 4: Розміщення вікна програми по центру екрану</a></div>
         <div class="task_desc_row"><a href="/validator/tasks/01_Form_05/task.php">Завдання 5: Ручне розміщення вікна</a></div>
         <div class="task_desc_row"><a href="/validator/tasks/01_Form_06/task.php">Завдання 6: Вікно на весь екран</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/01_Form_07/task.php">Завдання 7: Напівпрозоре вікно</a></div>	
		 <div class="task_desc_row"><a href="/validator/tasks/01_Form_08/task.php">Завдання 8: Захопи весь екран!</a></div>			 
		 <div class="task_desc_row"><a href="/validator/tasks/01_Form_09/task.php">Завдання 9: Програма без іконки та елементів керування</a></div>		
		 <div class="task_desc_row"><a href="/validator/tasks/01_Form_10/task.php">Завдання 10: Не відображати програму в Панелі задач</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/01_Form_11/task.php">Завдання 11: Форма з фоновим малюнком</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/01_Form_12/task.php">Завдання 12: Вікно з повторюваною текстурою на весь екран</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/01_Form_13/task.php">Завдання 13: Розтягнення фонового малюнку</a></div>
		 <hr>
		 <!-- task Winforms info block end --------------------------------------------------------------------------------->

		 <!-- task Controls Button info block start --------------------------------------------------------------------------------->
         <h3 class=''>Розділ 2: Елемент керування Button</h2>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_00/task.php">Завдання 0: Додавання кнопки на форму</a></div>
         <div class="task_desc_row"><a href="/validator/tasks/02_Button_01/task.php">Завдання 1: Зміна напису кнопки</a></div>
         <div class="task_desc_row"><a href="/validator/tasks/02_Button_02/task.php">Завдання 2: Зміна імені кнопки</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_03/task.php">Завдання 3: Розміщення кнопки на формі</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_04/task.php">Завдання 4: Подія на кнопці</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_05/task.php">Завдання 5: Робота з текстом - Відображення введеного тексту</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_06/task.php">Завдання 6: Робота з 2 полями для вводу</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_07/task.php">Завдання 7: Подвоєння введеного числа</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_08/task.php">Завдання 8: Умовні оператори: Перевірка на введення цифр</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_09/task.php">Завдання 9: Умовні оператори: Перевірка числа на рівність нулю</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_10/task.php">Завдання 10: Умовні оператори: Математичний калькулятор</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/02_Button_11/task.php">Завдання 11: Квадрат</a></div>
		 <div class="task_desc_row"><a href="/validator/tasks/07_App_Control/task.php">Завдання 12: Підсумковий урок</a></div>
		 <!-- task Controls Button info block end --------------------------------------------------------------------------------->
		
      </div>
    </div>
  </div>
</body>
</html>