<?php
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
?>
<html>
  <head>
    <!-- title -->
    <title>Завдання Winforms 5.1.1:</title>
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
	<!-- embedded CSS: -->
    <style media="screen" type="text/css">
      .btn-browse{
         width:200px !important;
         margin-left:46px;
         margin-top:9px;
      }
      .btn-upload{
         width:200px !important;
         margin-left:10px;
      }
      .c-dropdown{
         margin-top:10px;
	  }
      .h1_main{
         padding:30px;
         text-align:center;
         font-size:55px;
       }
       .lead-top-fix{
         padding-top:0px;	  
       }
       .pic-centered{
        text-align:center;
         padding:20px;
       }
       .bold{
        font-weight:bold !important;
       }
       .note{
         padding:10px;
       }
	</style>
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
         <h2 class=''>Завдання Winforms 5.1.1: 'Створення простої програми із 1 формою'</h2>
         <br>
         <p class="lead lead-top-fix">1. Створи новий проект програми С# із Winforms.</p>
		 <p class="lead lead-top-fix">2. Встановити розмір вікна форми 400x300 пікселів.</p>
		 <p class="lead lead-top-fix">3. Встановити колір вікна форми на "яскраво червоний".</p>
		 <p class="lead lead-top-fix">4. Змінити назву вікна форми на власне імя та прізвище.</p>
		 <p class="lead lead-top-fix">5. Встановити початкову позицію вікна на х:200 y:200.</p>
		 <p class="lead lead-top-fix">6. Побудувати проект.</p>
		 <p class="lead lead-top-fix">7. Знайти побудовану програму та завантажити у Валідатор.</p>
		 <p class="lead lead-top-fix">8. Добитися повної алідації програми.</p>
		 
         <div class="row pic-centered">
           <img src="target_form.png" alt="...">
         </div>
		 <!-- 
         <p class="lead">
           <a class="btn btn-info btn-warning" href="//youtube.com" role="button">Подивитися відео</a>
         </p>  
         <hr>
		 -->
		 
         <!-- task info block end ----------------------------------------------------------------------------------->

         <!-- task validation block start --------------------------------------------------------------------------->
         <h2 class=''>Перевірка:</h2>
           <!-- uploader start -->
           <form action="..\..\validator_fe.php" method="post" enctype="multipart/form-data">
             Оберіть файл програми, для валідації:
             <label class="btn btn-info btn-browse" for="fileToUpload">
             <input id="fileToUpload" name="fileToUpload" type="file" style="display:none;">
               Обрати файл
             </label>
             <input class='btn btn-primary btn-upload' type="submit" value="Відправити файл" name="submit"></input>
			 <!-- uploader end -->
			 <input type="hidden" name="codefile" value="5.1.1"> <!-- task id -->
         </form>
		 <!-- task validation block end ------------------------------------------------------------------------------>
		
		</div>
		
      </div>
    </div>
  </body>
</html>