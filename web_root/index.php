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
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
	<!-- jq CDN (bootsrtrap reqired): -->
	<script src="https://code.jquery.com/jquery-3.1.1.slim.min.js" integrity="sha256-/SIrNqv8h6QGKDuNoLGA4iret+kyesCkHGzVUUV0shc=" crossorigin="anonymous"></script>
    <!-- tether	CDN (bootsrtrap reqired): -->
	<script src="https://npmcdn.com/tether@1.2.4/dist/js/tether.min.js"></script>
    <script src="https://npmcdn.com/bootstrap@4.0.0-alpha.5/dist/js/bootstrap.min.js"></script>
	<!-- bootstrap CDN: -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.5/css/bootstrap.min.css" integrity="sha384-AysaV+vQoT3kOAXZkl02PThvDr8HYKPZhNT5h/CXfBThSRXQ6jW5DO2ekP5ViFdi" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.5/js/bootstrap.min.js" integrity="sha384-BLiI7JTZm+JWlgKa0M0kGRpJbF2J8q+qreVrKBC47e3K6BW78kGLrCkeRX6I9RoK" crossorigin="anonymous"></script>
    <!-- favicon: -->
	<link rel="icon" href="favicon.ico?v=2" />
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
           <a href="/validator/tasks/winforms5.1.1/task.php">Завдання 1</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.2/task.php">Завдання 2</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.3/task.php">Завдання 3</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.4/task.php">Завдання 4</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.5/task.php">Завдання 5</a>
         </div>
		 <!-- task Winforms info block end --------------------------------------------------------------------------------->

		 <!-- task Events info block start --------------------------------------------------------------------------------->
         <hr>
		 <h3 class=''>Події Events:</h2>
		  <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.1/task.php">Завдання 1</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.2/task.php">Завдання 2</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.3/task.php">Завдання 3</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.4/task.php">Завдання 4</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.5/task.php">Завдання 5</a>
         </div>
		 
         <!-- task Events info block end --------------------------------------------------------------------------------->

		 <!-- task Controls Button info block start --------------------------------------------------------------------------------->
			<hr>
		 <h3 class=''>Елементи керування Controls Button:</h2>
		  <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.1/task.php">Завдання 1</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.2/task.php">Завдання 2</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.3/task.php">Завдання 3</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.4/task.php">Завдання 4</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.5/task.php">Завдання 5</a>
         </div>
		 <!-- task Controls Button info block end --------------------------------------------------------------------------------->

		 <!-- task Controls Label info block start --------------------------------------------------------------------------------->
		 <hr>
		 <h3 class=''>Елементи керування Controls TextBox:</h2>
		  <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/controls5.3.1/task.php">Завдання 1</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.2/task.php">Завдання 2</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.3/task.php">Завдання 3</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.4/task.php">Завдання 4</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.5/task.php">Завдання 5</a>
         </div>
		 <!-- task Controls Label info block end --------------------------------------------------------------------------------->

		</div>
		
      </div>
    </div>
  </body>
</html>