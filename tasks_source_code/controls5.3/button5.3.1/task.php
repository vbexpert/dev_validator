<?php
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
?>
<html>
  <head>
    <!-- title -->
    <title>�������� button 5.3.1:</title>
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
         �# - �� ������<sup>*</sup>!
       </h1>
       <div class='note'>
         <sup>* ���� ��������� :-)</sup>
       </div>
       <!-- header info block end: -------------------------------------------------------------------------------->
	
       <div class="jumbotron">
	   
		 <!-- task info block start --------------------------------------------------------------------------------->
          
		 <h2 class=''><a href = "../../index.php">�������� ��������:</a></h2>
         <hr>
		 <h1 class=''>�������� button 5.3.1</h1>
         <h3 class=''>��������� ������ �������� �� 1 ������...</h3>
		
         <p class="lead lead-top-fix">�������� ����� �������� ������������</p>
         <br>
		 <table style="width:100%" class="table table-striped table-condensed">
			  <caption style="caption-side: top">������������ ��������</caption>
			<thead>
			  <tr>
				<th width="50px">�����</th>
				<th>����������</th>
				<th>��������</th>
				<th>����</th>
			  </tr>
			</thead>
			 <tr>
				<td>1.</td>
				<td>�����</td>
				<td>Windows Forms</td>
				<td><input type="checkbox" value=""></td>
			  </tr>
			  <tr>
				<td>2.</td>
				<td>����� �����</td>
				<td><b>400</b> x <b>300</b> ������</td>
				<td><input type="checkbox" value=""></td>
			  </tr>
			  
			  <tr>
				<td>3.</td>
				<td>���� �����</td>
				<td><b>��������</b></td>
				<td><input type="checkbox" value=""></td>
			  </tr>

			  <tr>
				<td>4.</td>
				<td>��������� �����</td>
				<td><b>������� �� ��'�</td>
				<td><input type="checkbox" value=""></td>
			  </tr>

			   <tr>
				<td>5.</td>
				<td>��������� ������� ����</td>
				<td><b>X: </b>200 <b>Y: </b>200 ������</td>
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
           <a class="btn btn-info " href="https://learn.ztu.edu.ua/mod/lesson/view.php?id=9977&pageid=8" role="button" target="_blank">�������� �� ������ ����</a>
		   <a class="btn btn-danger" href="https://youtu.be/hP0UsFULLuU?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf" role="button" target="_blank">���������� ��������</a>
		   <a class="btn btn-warning" href="https://vk.com/club106906794" role="button" target="_blank">���������� � �������</a>
        
		 </p> 
		<hr> 
		</div>
		<!-- help block end ----------------------------------------------------------------------------------->
         
         <!-- task validation block start --------------------------------------------------------------------------->
         <h2 class=''>��������:</h2>
           <!-- uploader start -->
           <form action="..\..\validator_fe.php" method="post" enctype="multipart/form-data">
             ������ ���� ��������, ��� ��������:
             <label class="btn btn-success btn-browse" for="fileToUpload">
             <input id="fileToUpload" name="fileToUpload" type="file" style="display:none;">
               ������ ����
             </label>
             <input class='btn btn-primary btn-upload' type="submit" value="³�������� ����" name="submit"></input>
			 <!-- uploader end -->
			 <input type="hidden" name="codefile" value="button5.3.1"> <!-- task id -->
         </form>
		 <!-- task validation block end ------------------------------------------------------------------------------>
		
		</div>
		
      </div>
    </div>
  </body>
</html>