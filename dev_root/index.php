﻿<?php
session_start();
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
include("main_config.php");
?>
<html>
  <head>
    <!-- title -->
    <title>Перевірка:</title>
    <!-- utf8 support: -->
	<?php
	  include("head_meta_tags.php");
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
            include("nav_menu.php");
        ?>
       <!-- menu end: -->
	   
         <!-- header info block start: -------------------------------------------------------------------------------->
		 <?php
		    include("header.php");
		 ?>
         <!-- header info block end: -------------------------------------------------------------------------------->
         <hr>
		 <h2 class=''>Доступні завдання:</h2>
	   
		 <!-- task Winforms info block start ------------------------------------------------------------------------>
		 <h3 class=''>Форми WindowsForms</h2>
         <hr>	 
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_00/task.php">Завдання 0: Створення простої Windows форми</a>
         </div>		 
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_01/task.php">Завдання 1: Моя власна програма із Windows Forms</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_02/task.php">Завдання 2: Розфарбуйте свою Windows форму</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_03/task.php">Завдання 3: Зміна розмірів вікна</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_04/task.php">Завдання 4: Розміщення вікна програми по центру екрану</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_05/task.php">Завдання 5: Ручне розміщення вікна</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_06/task.php">Завдання 6: Вікно на весь екран</a>
         </div>
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_07/task.php">Завдання 7: Напівпрозоре вікно</a>
         </div>	
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_08/task.php">Завдання 8: Захопи весь екран!</a>
         </div>			 
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_09/task.php">Завдання 9: Програма без іконки та елементів керування</a>
         </div>		
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_10/task.php">Завдання 10: Не відображати програму в Панелі задач</a>
         </div>
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_11/task.php">Завдання 11: Форма з фоновим малюнком</a>
         </div>
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_12/task.php">Завдання 12: Вікно з повторюваною текстурою на весь екран</a>
         </div>
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_13/task.php">Завдання 13: Розтягнення фонового малюнку</a>
         </div>
		 
		 <!-- task Winforms info block end ------------------------------------------------------------------------->

		<!-- task Button block start ------------------------------------------------------------------------>
		 <h3 class=''>Об'єкт Кнопка Button</h2>
         <hr>	 
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_00/task.php">Завдання 0: Додавання кнопки на форму</a>
         </div>		 
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_01/task.php">Завдання 1: Зміна напису кнопки</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_02/task.php">Завдання 2: Зміна імені кнопки</a>
         </div>
		<div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_03/task.php">Завдання 3: Розміщення кнопки на формі</a>
         </div>
		 
		 <!-- task Button block end ------------------------------------------------------------------------->
		</div>
		
      </div>
    </div>
  </body>
</html>