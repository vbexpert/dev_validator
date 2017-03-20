<?php
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
?>
<html>
  <head>
    <!-- title -->
    <title>Завдання winforms 5.1.2:</title>
	
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
    <link rel="stylesheet" type="text/css" href="../../_css/global.css">
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
         <h2 class=''><a href = "../../index.php">Доступні завдання:</a></h2>
         <hr>
		 <h2 class=''>Завдання Winforms: 5.1.3</h2>
         <p class="lead lead-top-fix">1. Відкрити <b>Освітній портал ЖДТУ</b>.</p>
         <p class="lead lead-top-fix">2. Ознайомитись з матеріалом <b>ТЕМА 1. Середовище розробки Microsoft Visual Studio</b>.</p>
         <p class="lead lead-top-fix">3. Виконати <b>Практичне завдання</b>.</p>
		 <p class="lead lead-top-fix">4. Виконати <b>Практичне завдання</b>.</p>
		 <p class="lead lead-top-fix">5. Перевірити програми  <b>самостійно</b>.</p>
		 <p class="lead lead-top-fix">6. У папці своеї команди підготувати папку <b>Release</b>:</p>
		 <blockquote>
		 	<p class="lead lead-top-fix">- Чотири програми готові до запуску</p>
		 	<p class="lead lead-top-fix">- Два скріншота з результатами <b>DEV-VALIDATOR</b></p>
		 </blockquote>
		 

         <div class="row pic-centered">
           <img src="target_form.png" alt="...">
         </div>
				 
         <!-- task info block end ----------------------------------------------------------------------------------->

		
		<!-- help block start ----------------------------------------------------------------------------------->
			<hr>
				<?php
					include_once("../../help.php");
				?>
			<hr> 
		<!-- help block end ----------------------------------------------------------------------------------->

        

         
         <!-- task validation block start --------------------------------------------------------------------------->
         <h2 class=''>Перевірка:</h2>
           <!-- uploader start -->
           <form action="..\..\validator_fe.php" method="post" enctype="multipart/form-data">
             Оберіть файл програми, для валідації:
             <label class="btn btn-success btn-browse" for="fileToUpload">
             <input id="fileToUpload" name="fileToUpload" type="file" style="display:none;">
               Обрати файл
             </label>
             <input class='btn btn-primary btn-upload' type="submit" value="Відправити файл" name="submit"></input>
			 <!-- uploader end -->
			 <input type="hidden" name="codefile" value="winforms5.1.2"> <!-- task id -->
         </form>
		 <!-- task validation block end ------------------------------------------------------------------------------>
		
		</div>
		
      </div>
    </div>
  </body>
</html>
