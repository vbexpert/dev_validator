<?php

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
	if ($_FILES["fileToUpload"]["size"] > 500000) {
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
			echo "Файл ". basename( $_FILES["fileToUpload"]["name"]). " завантажено на сервер Ок! Запускаемо валідатор...";
	
			if (strtoupper(substr(PHP_OS, 0, 3)) === 'WIN') {
			  //windows:
			  $command = "validator.exe $s_uploaded_exe_fnp $s_codefile_fnp 1.exe";
			  //echo($command);
			  $out = system($command);
			} else {
			  //linux: 
			  //main command: [working example] $command = "xvfb-run -a mono validator.exe uploads/1.exe tasks/01_Form_01/code.txt 2>&1";
			  $command = "xvfb-run -a mono validator.exe $s_uploaded_exe_fnp $s_codefile_fnp 1.exe 2>&1";
			  $ret = shell_exec($command);
			  //clean out rander error:
			  $out = substr($ret, 55, strlen($ret) - 55);
			  //display:
			  echo($out);
			}
			//delete file:
			unlink($s_uploaded_exe_fnp);
		} else {
			echo "Вибачте, завантажити файл не вдалося!";
		}
	}
}

?>