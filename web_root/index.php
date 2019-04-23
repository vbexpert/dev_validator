﻿<?php
session_start();
//utf8 support:
header('Content-Type: text/html; charset=utf-8');
include_once("main_config.php");
?>
<html>
  <head>
    <!-- title -->
    <title>Перевірка:</title>
    <!-- utf8 support: -->
	<?php
	  include_once("head_includes.php");
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
            <div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#Form">Form</a>
                </h4>
              </div>
              <div id="Form" class="panel-collapse collapse">                
                <div class="panel-body">                                    	 
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_00/task.php">Завдання 0: Створення простої Windows форми</a></div>		 
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_01/task.php">Завдання 1: Моя власна програма із Windows Forms</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_02/task.php">Завдання 2: Розфарбуйте свою Windows форму</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_03/task.php">Завдання 3: Зміна розмірів вікна</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_04/task.php">Завдання 4: Розміщення вікна програми по центру екрану</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_05/task.php">Завдання 5: Ручне розміщення вікна</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_06/task.php">Завдання 6: Вікно на весь екран</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_07/task.php">Завдання 7: Напівпрозоре вікно</a></div>	
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_08/task.php">Завдання 8: Захопи весь екран!</a></div>			 
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_09/task.php">Завдання 9: Програма без іконки та елементів керування</a></div>		
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_10/task.php">Завдання 10: Не відображати програму в Панелі задач</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_11/task.php">Завдання 11: Форма з фоновим малюнком</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_12/task.php">Завдання 12: Вікно з повторюваною текстурою на весь екран</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/01_Form_13/task.php">Завдання 13: Розтягнення фонового малюнку</a></div>                  
                </div>                
              </div>
            </div>
            <!-- task Forms block end -->

            <!-- task Event block start -->
            <div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#Event">Event</a>
                </h4>
              </div>
              <div id="Event" class="panel-collapse collapse">                
                <div class="panel-body">                                    	 
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/02_Form_Load_01/task.php">Завдання 0: Створення події Load</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/02_Event_01/task.php">Завдання 1: Створення події Click</a></div>		                                     
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/02_Event_02/task.php">Завдання 2: Створення події DoubleClick</a></div>		                                     
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/02_Event_03/task.php">Завдання 3: Створення події MouseEnter</a></div>		                                     
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/02_Event_04/task.php">Завдання 4: Створення події MouseLeave</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/02_Event_05/task.php">Завдання 5: Створення події KeyPress</a></div>		                                     


                </div>                
              </div>
            </div>
            <!-- task Event block end -->
			
            <!-- task Button block start -->
			<div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#Button">Button+</a>
                </h4>
              </div>
              <div id="Button" class="panel-collapse collapse">                
                <div class="panel-body">  
                  <div class ="row pic-centered task_desc_row"><a href="/validator/tasks/03_Button_00/task.php">Завдання 0: Додавання кнопки на форму</a></div>
                  <div class ="row pic-centered task_desc_row"><a href="/validator/tasks/03_Button_01/task.php">Завдання 1: Зміна напису кнопки</a></div>
                  <div class ="row pic-centered task_desc_row"><a href="/validator/tasks/03_Button_02/task.php">Завдання 2: Зміна імені кнопки</a></div>
                  <div class ="row pic-centered task_desc_row"><a href="/validator/tasks/03_Button_03/task.php">Завдання 3: Розміщення кнопки на формі</a></div>
                  <div class ="row pic-centered task_desc_row"><a href="/validator/tasks/03_Button_04/task.php">Завдання 4: Подія на кнопці</a></div>
                </div>                
              </div>
            </div>
            <!-- task Button block end -->

            <!-- task Label block start -->
            <div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#Label">Label</a>
                </h4>
              </div>
              <div id="Label" class="panel-collapse collapse">                
                <div class="panel-body">                                    	 
                  <div class ="row pic-centered task_desc_row"><a href="/validator/tasks/03_Label_00/task.php">Завдання 0: Додавання напису на форму</a></div>
                  <div class ="row pic-centered task_desc_row"><a href="/validator/tasks/03_Label_01/task.php">Завдання 0: Додавання напису на форму</a></div> 
                  <div class ="row pic-centered task_desc_row"><a href="/validator/tasks/03_Label_02/task.php">Завдання 0: Додавання напису на форму</a></div>                     
                </div>                
              </div>
            </div>
            <!-- task Label block end -->

            <!-- task TextBox block start -->
            <div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#TextBox">TextBox</a>
                </h4>
              </div>
              <div id="TextBox" class="panel-collapse collapse">                
                <div class="panel-body">                                    	 
                                    
                </div>                
              </div>
            </div>
            <!-- task TextBox block end -->

			<!-- task PictureBox block start -->
            <div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#PictureBox">PictureBox</a>
                </h4>
              </div>
              <div id="PictureBox" class="panel-collapse collapse">                
                <div class="panel-body">                                    	 
                                    
                </div>                
              </div>
            </div>
            <!-- task PictureBox block end -->

            <!-- task Graphics block start -->
            <div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#Graphics">Graphics - Графіка</a>
                </h4>
              </div>
              <div id="Graphics" class="panel-collapse collapse">                
                <div class="panel-body">                                    	 
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/06_2D_Graphics_01/task.php">Завдання 0: </a></div>		 
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/06_2D_Black_White/task.php">Завдання 1: Black_White</a></div>                    
                </div>                
              </div>
            </div>
            <!-- task Graphics block end -->

            <!-- task Math block start -->
            <div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#Math">Mathematics - Математика</a>
                </h4>
              </div>
              <div id="Math" class="panel-collapse collapse">                
                <div class="panel-body">                                    	 
                  <div class="row pic-centered task_desc_row"><a href="">Завдання 0: Виведення введеного числа </a></div>	
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/07_Doubling/task.php">Завдання 0: Подвоєння введеного числа</a></div> 
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/03_Button_10/task.php">Завдання 1: Математичні дії</a></div>      
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/07_Square/task.php">Завдання 2: Квадрат</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/07_Circle/task.php">Завдання 3: Коло</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/07_Rectangular_Triangle/task.php">Завдання 4: Прямокутний трикутник</a></div>
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/07_App_Control/task.php">Завдання 4: Підсумковий урок</a></div>                    
                </div>                
              </div>
            </div>
            <!-- task Math block end -->

            <!-- task Phisics block start -->
            <div class="panel panel-default">
              <div class="panel-heading">
                <h4 class="panel-title">
                  <a data-toggle="collapse" data-parent="#collapse-group" href="#Physics">Physics - Фізика</a>
                </h4>
              </div>
              <div id="Physics" class="panel-collapse collapse">                
                <div class="panel-body">                                    	 
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/08_Energy/task.php">Завдання 0: Енергія </a></div>	
                  <div class="row pic-centered task_desc_row"><a href="/validator/tasks/08_Speed/task.php">Завдання 1: Швидкість рівномірного прямолінійного руху</a></div> 
                  <div class="row pic-centered task_desc_row"><a href="">Завдання 2: </a></div>      
                  <div class="row pic-centered task_desc_row"><a href="">Завдання 3: </a></div>
                  <div class="row pic-centered task_desc_row"><a href="">Завдання 4: </a></div>
                  <div class="row pic-centered task_desc_row"><a href="">Завдання 5: </a></div>                    
                </div>                
              </div>
            </div>
            <!-- task Phisics block end -->            
          </div> 
          <!-- help block start -->  
          <a class="btn btn-info btn-lg btn-block" href="https://docs.google.com/document/d/1ZZgKuX8jBzROxZpQMF0xoWBmxvjeD0nIIPz5oVXdhso/edit?usp=sharing" role="button" target="_blank">Читати навчальний матеріал</a>
          <a class="btn btn-info btn-lg btn-block" href="https://www.youtube.com/playlist?list=PLgNmtqlNFVjpYzErepZF2E8Mc4R27yXYf" role="button" target="_blank">Переглянути відеоуроки</a>
          <a class="btn btn-info btn-lg btn-block" href="http://informatics.in.ua/" role="button" target="_blank">Сайт Інформатика в школі</a>
          <!-- help block end -->          
          
        </div>
      </div>
    </div>  
  </body>
</html>