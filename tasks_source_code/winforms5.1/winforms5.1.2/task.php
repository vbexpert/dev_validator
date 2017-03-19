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
		 <h2 class=''>Завдання Winforms: </h2>
        
         <p class="lead lead-top-fix">Створити форму відповідно специфікації</p>
         
		 <table style="width:100%" class="table table-striped table-condensed">
			  <caption style="caption-side: top">Специфікація програми</caption>
			<thead>
			  <tr>
				<th>Номер</th>
				<th>Властивість</th>
				<th>Значення</th>
				<th>Стан</th>
			  </tr>
			</thead>
			 <tr>
				<td>1.</td>
				<td>Форма</td>
				<td>Windows Forms</td>
				<td><input type="checkbox" value=""></td>
			  </tr>
			  <tr>
				<td>2.</td>
				<td>Розмір форми</td>
				<td><b>500</b> x <b>500</b> пікселів</td>
				<td><input type="checkbox" value=""></td>
			  </tr>
			  
			  <tr>
				<td>3.</td>
				<td>Колір форми</td>
				<td><b>CadetBlue</b></td>
				<td><input type="checkbox" value=""></td>
			  </tr>

			  <tr>
				<td>4.</td>
				<td>Заголовок форми</td>
				<td><b>Програма 2</b></td>
				<td><input type="checkbox" value=""></td>
			  </tr>
			   <tr>
				<td>5.</td>
				<td>Початкова позиція</td>
				<td><b>Manual</b></td>
				<td><input type="checkbox" value=""></td>
			 </tr>
			   <tr>
				<td>6.</td>
				<td>Розміщення вікна</td>
				<td><b>Верхній лівий кут екрану</b></td>
				<td><input type="checkbox" value=""></td>
			 </tr>
			  <tr>
				<td>7.</td>
				<td>Прозорість вікна</td>
				<td><b>50%</b></td>
				<td><input type="checkbox" value=""></td>
			 </tr>
			
		</table>

         <div class="row pic-centered">
           <img src="target_form.png" alt="...">
         </div>
				 
         <!-- task info block end ----------------------------------------------------------------------------------->

		 <!-- help block start ----------------------------------------------------------------------------------->
	     <div style="text-align: center;"> 
		  <hr>
		  <p class="lead">
           <a class="btn btn-info " href="https://learn.ztu.edu.ua/mod/lesson/view.php?id=9977&pageid=8" role="button" target="_blank">Почитати на порталі ЖДТУ</a>
		   <a class="btn btn-danger" href="https://youtu.be/hP0UsFULLuU?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf" role="button" target="_blank">Подивитись відеоурок</a>
		   <a class="btn btn-warning" href="https://vk.com/club106906794" role="button" target="_blank">Обговорити у спільноті</a>
        
		 </p> 
		<hr> 
		</div>
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
