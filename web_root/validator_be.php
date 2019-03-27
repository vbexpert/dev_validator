<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");

function _validate_uploaded_app(){
	
	include_once("main_config.php");
	
	//!using DIRECTORY_SEPARATOR - for linux and windows:
	$s_codefile_fnp = "tasks" . DIRECTORY_SEPARATOR . $_POST["codefile"] . DIRECTORY_SEPARATOR . "code.txt";
	//using unique name: (for multiple users):
	$s_uploaded_exe_fnp = "uploads". DIRECTORY_SEPARATOR . uniqid(rand(), true) . '.exe';
	
	$uploadOk = 1;
	$imageFileType = pathinfo($s_uploaded_exe_fnp,PATHINFO_EXTENSION);
	// Check if file already exists:
	if (file_exists($s_uploaded_exe_fnp)) {
		echo "Sorry, file already exists.";
		$uploadOk = 0;
	}
	// Check file size:
	if ($_FILES["fileToUpload"]["size"] > 2000000) {
		echo "Sorry, your file is too large.";
		$uploadOk = 0;
	}
	// Allow certain file formats:
	if($imageFileType != "exe") {
		echo "Вибачте, лише файли типу EXE дозволені!";
		$uploadOk = 0;
	}
	// Check if $uploadOk is set to 0 by an error:
	if ($uploadOk == 0) {
		echo "Sorry, your file was not uploaded.";
		
	// if everything is ok, try to upload file:
	} else {
		if (move_uploaded_file($_FILES["fileToUpload"]["tmp_name"], $s_uploaded_exe_fnp)) {
			$s_original_app_ft = $_FILES["fileToUpload"]["name"];
			echo "Файл ". basename( $_FILES["fileToUpload"]["name"]). " завантажено на сервер Ок! Запускаемо валідатор...<br><br>";
	
			if (strtoupper(substr(PHP_OS, 0, 3)) === 'WIN') {
			  //windows:
			  $command = "validator.exe $s_uploaded_exe_fnp $s_codefile_fnp $s_original_app_ft";
			  //echo($command);
			  $s_v_output = shell_exec($command);
			  file_put_contents("v-output-windows-raw.txt", $s_v_output);
			} else {
			  //linux: 
			  //main command: [working example] $command = "xvfb-run -a mono validator.exe uploads/1.exe tasks/01_Form_01/code.txt 2>&1";
			  //$command = "xvfb-run -a mono validator.exe $s_uploaded_exe_fnp $s_codefile_fnp $s_original_app_ft 2>&1";
			  $command = "xvfb-run -a --server-args='-screen 0 1024x768x24 -dpi 90' mono validator.exe $s_uploaded_exe_fnp $s_codefile_fnp $s_original_app_ft 2>&1";

			  $s_v_output = shell_exec($command);
			  file_put_contents("v-output-linux-raw.txt", $s_v_output);

			  //clean out rander error:
			  $i_pos = strpos($s_v_output, ":99\".") + 6;
			  $s_v_output = substr($s_v_output, $i_pos, strlen($s_v_output) - $i_pos);
			}
			
			//save to file for debug:
			//file_put_contents("v-output-clean.txt", $s_v_output);
			
			//first - delete the uploaded file, then - eval (son on eval fail, file is deleted anyway):
			unlink($s_uploaded_exe_fnp);
			
			//reset session vars:
			for($i = 0; $i <= 50; $i++){
				$s_s_title="vr".$i."_reslt";
				unset($_SESSION[$s_s_title]);
				unset($_SESSION["vr".$i."_score"]);
				unset($_SESSION["vr".$i."_error"]);
			}
			
			//run v-core php output evaluation:
			eval($s_v_output);
			
			//at this point session vars are set.
			
		    //send validation stats:
			$i_v_percent = $_SESSION["vr_percent"];
			$s_un = $_SESSION["s_user_name"];
			$s_email = $_SESSION["s_user_email"];
			$s_task_id = $_SESSION["s_task_id"];
			
			//universal:
			echo("<script>window.location = \"".$_SESSION['s_task_page']."\";</script>");

		} else {
			echo "Вибачте, завантажити файл не вдалося!";
		}
	
	}
}
?>