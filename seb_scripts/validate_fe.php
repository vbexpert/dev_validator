<?php
header('Content-Type: text/html; charset=utf-8');
?>
<html>
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
	<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
	<link rel="stylesheet" media="none" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js">
</head>
<body>

<?php echo("Тест української!"); ?>

<form action="validate_be.php" method="post" enctype="multipart/form-data">
    Оберіть файл програми, для валідації:
    <input type="file" name="fileToUpload" id="fileToUpload">
	<br>
    <input type="submit" value="Відправити файл" name="submit">
</form>

</body>
</html>