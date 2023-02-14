<?php
session_start();
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
include_once("main_config.php");
?>
<html>
  <head>
    <!-- title -->
    <title>Завдання:</title>
    <!-- utf8 support: -->
	<?php
	  include_once("head_includes.php");
	?>
	<!-- external CSS: -->
    <!-- <link rel="stylesheet" type="text/css" href="_css/global.css"> -->
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
      
          <!-- header info block start: -->
          <?php
              include("header.php");
          ?>
          <!-- header info block end: -->

          <hr>
          <h2>Доступні завдання:</h2>

          <div class="panel-group" id="collapse-group">

            <!-- task Forms block start -->
            <?php
              include("tasks_list/01_Form.php");
            ?>

            <!-- task Event block start -->
            <?php
              include("tasks_list/02_Event.php");
            ?>
			
            <!-- task Button block start -->
            <?php
              include("tasks_list/03_Button.php");
            ?>

            <!-- task Label block start -->
            <?php
              include("tasks_list/04_Label.php");
            ?>

            <!-- task TextBox block start -->
            <?php
              include("tasks_list/05_TextBox.php");
            ?>

			      <!-- task PictureBox block start -->
            <?php
              include("tasks_list/07_PictureBox.php");
            ?>

            <!-- task Graphics block start -->
            <?php
              include("tasks_list/06_Graphics.php");
            ?>

            <!-- task Math block start -->
            <?php
              include("tasks_list/07_Math.php");
            ?>

            <!-- task Phisics block start -->
            <?php
              include("tasks_list/08_Physics.php");
            ?>  

          </div>

          <!-- help block start -->  
          <a class="btn btn-info btn-lg btn-block" href="" role="button" target="_blank">Читати навчальний матеріал</a>
          <a class="btn btn-info btn-lg btn-block" href="https://www.youtube.com/playlist?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf" role="button" target="_blank">Переглянути відеоуроки</a>
          <a class="btn btn-info btn-lg btn-block" href="http://informatics.in.ua/" role="button" target="_blank">Сайт Інформатика в школі</a>
          <!-- help block end -->          
          
        </div>
      </div>
    </div>  
  </body>

  	<!--Google auth-->
	<script type="module" src="_js/firebaseAuth.js"></script>
	<!--Google Firestore-->	
	<script src="https://www.gstatic.com/firebasejs/8.10.0/firebase-app.js"></script>
	<script src="https://www.gstatic.com/firebasejs/8.10.0/firebase-firestore.js"></script>
	
	
</html>