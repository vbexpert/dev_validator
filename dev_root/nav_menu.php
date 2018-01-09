<?php
$cur_dir_fp = explode('\\', getcwd());
$cur_dir_title = $cur_dir_fp[count($cur_dir_fp)-1];
if($cur_dir_title == "validator"){
  $s_rip = "_img/c-sharp-logo4.png";
}
else{
  $s_rip = "../../_img/c-sharp-logo4.png";
}
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
        </li>
      </ul>
    </div>

  </div>
</div>