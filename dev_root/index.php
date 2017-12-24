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
        <!-- header info block start: -------------------------------------------------------------------------------->
		<?php
			include_once("header.php");
		?>
       <!-- header info block end: -------------------------------------------------------------------------------->
	
       <div class="jumbotron">
	   
		 <!-- task Winforms info block start --------------------------------------------------------------------------------->
         <h2 class=''>Доступні завдання:</h2>
         <hr>
		 <h3 class=''>Форми WindowsForms:</h2>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_01/task.php">Завдання 1: Моя перша Пргорама із Windows Forms</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_02/task.php">Завдання 2: Програма із прозорою формою</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_03/task.php">Завдання 3: Програма з вікном у центрі</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_04/task.php">Завдання 4: Програма з Фоновим зображенням - 'Природа'</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_05/task.php">Завдання 5: Моя велика програма</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/01_Form_06/task.php">Завдання 6: Програма із вікном без елементі контролю стану</a>
         </div>
		 <!-- task Winforms info block end --------------------------------------------------------------------------------->

		 <!-- task Controls Button info block start --------------------------------------------------------------------------------->
			<hr>
		 <h3 class=''>Елементи керування Control Buttons:</h2>
		  <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_01/task.php">Завдання 1</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_02/task.php">Завдання 2</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_03/task.php">Завдання 3</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_04/task.php">Завдання 4</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/02_Button_05/task.php">Завдання 5</a>
         </div>
		 <!-- task Controls Button info block end --------------------------------------------------------------------------------->

		 <!-- task Controls Label info block start --------------------------------------------------------------------------------->
		 <hr>
		 <h3 class=''>Елементи керування Controls TextBox:</h2>
		  <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/04_TextBox_01/task.php">Завдання 1</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/04_TextBox_02/task.php">Завдання 2</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/04_TextBox_03/task.php">Завдання 3</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/04_TextBox_04/task.php">Завдання 4</a>
         </div>
         <div class="row pic-centered task_desc_row">
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

		 
		</div>
		
      </div>
    </div>
  </body>
</html>