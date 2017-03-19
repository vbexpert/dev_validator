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
       <h1 class='h1_main'>
         С# - це просто<sup>*</sup>!
       </h1>
       <div class='note'>
         <sup>* якщо попрацюеш :-)</sup>
       </div>
       <!-- header info block end: -------------------------------------------------------------------------------->
	
       <div class="jumbotron">
	   
		 <!-- task info block start --------------------------------------------------------------------------------->
         <h2 class=''>Доступні завдання:</h2>
         <hr>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.1/task.php">Завдання 1: "Winforms 5.1"</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.2/task.php">Завдання 2: "Winforms 5.2"</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.3/task.php">Завдання 3: "Winforms 5.3"</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.4/task.php">Завдання 4: "Winforms 5.4"</a>
         </div>
         <div class="row pic-centered task_desc_row">
           <a href="/validator/tasks/winforms5.1.5/task.php">Завдання 5: "Winforms 5.5"</a>
         </div>
         <hr>
         <!-- task info block end ----------------------------------------------------------------------------------->

		</div>
		
      </div>
    </div>
  </body>
</html>