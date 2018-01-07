<?php
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
include_once("validator_be.php");
?>
<html>
  <head>
    <!-- title -->
    <title>Перевірка:</title>
    <!-- utf8 support: -->
	<?php
	  include_once("head_meta_tags.php");
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
         <h2 class=''>Доступні завдання:</h2>
         <hr>	   
	   <!-- task Test info block start --------------------------------------------------------------------------------->
			
		 <h3 class=''>Тестові завдання:</h2>
		 
		 
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/00_test_01/task.php">Завдання 01: Тестове</a>
         </div>	
		 <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/00_test_02_Tech_Showdown/task.php">Завдання 02: Tech_Showdown</a>
         </div>	
		 <div class="">
           <a href="/validator/tasks/00_test_03/task.php">Завдання 03: Тестове</a>
         </div>	
		 <div class="">
           <a href="/validator/tasks/00_test_04/task.php">Завдання 04: Тестове</a>
         </div>	
		 <div class="">
           <a href="/validator/tasks/00_test_05/task.php">Завдання 05: Тестове</a>
         </div>	
		 <!-- task Test info block end --------------------------------------------------------------------------------->
		 
	   
		 <!-- task Winforms info block start --------------------------------------------------------------------------------->

		 <h3 class=''>Форми WindowsForms:</h2>
		 
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
		 <div class="">
           <a href="/validator/tasks/01_Form_13/task.php">Завдання 13: Розтягнення фонового малюнку</a>
         </div>
		 <div class="">
           <a href="/validator/tasks/01_Form_14/task.php">Завдання 14: Форма</a>
         </div>
		 <div class="">
           <a href="/validator/tasks/01_Form_15/task.php">Завдання 15: Форма</a>
         </div>
		 <div class="">
           <a href="/validator/tasks/01_Form_16/task.php">Завдання 16: Форма</a>
         </div>

		 <!-- task Winforms info block end --------------------------------------------------------------------------------->

		 <!-- task Controls Button info block start --------------------------------------------------------------------------------->
			<hr>
		 <h3 class=''>Елементи керування Control Buttons:</h2>
		  <div class="">
           <a href="/validator/tasks/02_Button_01/task.php">Завдання 1: Перша кнопка</a>
         </div>
         <div class="">
           <a href="/validator/tasks/02_Button_02/task.php">Завдання 2</a>
         </div>
         <div class="">
           <a href="/validator/tasks/02_Button_03/task.php">Завдання 3</a>
         </div>
         <div class="">
           <a href="/validator/tasks/02_Button_04/task.php">Завдання 4</a>
         </div>
         <div class="">
           <a href="/validator/tasks/02_Button_05/task.php">Завдання 5</a>
         </div>
		 <!-- task Controls Button info block end --------------------------------------------------------------------------------->
		 
		 <!-- task Controls Label info block start --------------------------------------------------------------------------------->
		 <hr>
		 <h3 class=''>Елементи керування Controls Label:</h2>
		  <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/03_Label_01/task.php">Завдання 1. Наявність напису</a>
         </div>
         <div class="">
           <a href="/validator/tasks/03_Label_02/task.php">Завдання 2. Напис з текстом</a>
         </div>
         <div class="">
           <a href="/validator/tasks/03_Label_03/task.php">Завдання 3</a>
         </div>
         <div class="">
           <a href="/validator/tasks/03_Label_04/task.php">Завдання 4</a>
         </div>
         <div class="">
           <a href="/validator/tasks/03_Label_05/task.php">Завдання 5</a>
         </div>
		 <!-- task Controls Label info block end --------------------------------------------------------------------------------->


		 <!-- task Controls Label info block start --------------------------------------------------------------------------------->
		 <hr>
		 <h3 class=''>Елементи керування Controls TextBox:</h2>
		  <div class="">
           <a href="/validator/tasks/04_TextBox_01/task.php">Завдання 1</a>
         </div>
         <div class="">
           <a href="/validator/tasks/04_TextBox_02/task.php">Завдання 2</a>
         </div>
         <div class="">
           <a href="/validator/tasks/04_TextBox_03/task.php">Завдання 3</a>
         </div>
         <div class="">
           <a href="/validator/tasks/04_TextBox_04/task.php">Завдання 4</a>
         </div>
         <div class="">
           <a href="/validator/tasks/04_TextBox_05/task.php">Завдання 5</a>
         </div>
		 <!-- task Controls Label info block end --------------------------------------------------------------------------------->

		 
		 <!-- task Events info block start --------------------------------------------------------------------------------->
         <hr>
		 <h3 class=''>Події Events Click:</h2>
		  <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 1</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 2</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 3</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 4</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 5</a>
         </div>
         <!-- task Events info block end --------------------------------------------------------------------------------->

		 <!-- task 2D Graphics block start --------------------------------------------------------------------------------->
         <hr>
		 <h3 class=''>Малювання графічниї примітивів:</h2>
		  <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/06_2d_graphics_01/task.php">Завдання 1: Моя перша лінія!</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 2</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 3</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 4</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/50_Click_01/task.php">Завдання 5</a>
         </div>
         <!-- task Events info block end --------------------------------------------------------------------------------->
		 
		 
		</div>
		
      </div>
    </div>
  </body>
</html>