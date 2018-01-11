<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

require("main_config.php");

function _validate_uploaded_app(){
	
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
			} else {
			  //linux: 
			  //main command: [working example] $command = "xvfb-run -a mono validator.exe uploads/1.exe tasks/01_Form_01/code.txt 2>&1";
			  //$command = "xvfb-run -a mono validator.exe $s_uploaded_exe_fnp $s_codefile_fnp $s_original_app_ft 2>&1";
			  $command = "xvfb-run -a --server-args='-screen 0 1024x768x24 -dpi 90' mono validator.exe $s_uploaded_exe_fnp $s_codefile_fnp $s_original_app_ft 2>&1";
			  
			  
			  $ret = shell_exec($command);
			  //clean out rander error:
			  $s_v_output = substr($ret, 57, strlen($ret) - 57);
			}
			
			//save to file for debug:
			$fh = 'v-output.txt';
			file_put_contents($fh, $s_v_output);
			
			//first - delete the uploaded file, then - eval (son on eval fail, file is deleted anyway):
			unlink($s_uploaded_exe_fnp);
			
			//run v-core php output evaluation:
			eval($s_v_output);
			//at this point session vars are set.
			
			//send stats to the DB:
		    require($s_v_app_root."db_connect.php");
		    //send validation stats:
			$i_v_percent = $_SESSION["vr_percent"];
			$s_un = $_SESSION["s_user_name"];
			$s_email = $_SESSION["s_user_email"];
			$s_task_id = $_SESSION["s_task_id"];
			
		    $sql = "INSERT INTO v_stats (dt_datetime,s_user_email,i_score,s_task_id,s_user_name) VALUES(NOW(), '$s_email', $i_v_percent, '$s_task_id','$s_un');";
		    $result = $obj_connection->query($sql);
			
			//redirect to task page:
			echo("<script>history.go(-1);</script>");

		} else {
			echo "Вибачте, завантажити файл не вдалося!";
		}
	}
}

?>