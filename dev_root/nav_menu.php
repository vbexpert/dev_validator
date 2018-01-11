<?php
$cur_dir_fp = explode('\\', getcwd());
$cur_dir_title = $cur_dir_fp[count($cur_dir_fp)-1];
$s_rip = $s_domain."/validator/_img/c-sharp-logo4.png";
?>
<div class="navbar navbar-default " role="navigation">
  <div class="container">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target=".navbar-collapse">
        <span class="sr-only">Відкрити навігатор</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <!-- <a class="navbar-brand" href="#">С# Валідатор</a> -->
    </div>
	
    <div class="navbar-collapse collapse">
      <ul class="nav navbar-nav">
	    <img class='nav-logo' src='<?php echo($s_rip); ?>' />
        <li><a href="/">Головна</a>
        </li>
        <li><a href="/validator/index.php">Всі завдання</a>
		<li><a href="/validator/progress_chart.php">Графік успіху</a>
        </li>
      </ul>
	  
	  <?php if(isset($_SESSION["s_user_fn"])) : ?>
      <ul class="nav navbar-nav navbar-right">
	    <li><a href="<?php echo($s_domain."/validator/logout.php"); ?>">
	      Вийти
	    </a></li>
      </ul>
	  
      <ul class="nav navbar-nav navbar-right">
        <li><a href="#">
		<?php 
		  echo("Вітаємо, ".$_SESSION["s_user_fn"]."!");
		?>
		</a></li>
      </ul>
	  <?php endif; ?>

	  
    </div>

  </div>
</div>