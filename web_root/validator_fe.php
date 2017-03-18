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
	  .c_correct{
		 color:green;
		 text-align:left;
		 font-size:35px;
	  }
	  .c_wrong{
		 color:red;
		 text-align:left;
		 font-weight:bold !important;
		 padding:10px;
		 font-size:35px;
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
         <h2 class=''>Перевірка програми:</h2>
         <br>
         <p class="lead lead-top-fix">
		 <!-- validator code start:  -------------------------------------------------------------------------------->
		 
		 <?php _validate_uploaded_app(); ?>

         <!-- validator code end:  ---------------------------------------------------------------------------------->
		 
         <!-- task info block end ----------------------------------------------------------------------------------->

		</div>
		
      </div>
    </div>
  </body>
</html>