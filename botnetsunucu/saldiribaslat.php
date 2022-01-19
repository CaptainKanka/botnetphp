<?php

include("vt.php");

  ?>
<html>
<head>
<?php
include("vt.php");
	$id = '1';
	
		$sorgu = $db->prepare("SELECT * FROM genel WHERE id=:id");				//istenilen id deki veriyi çekme
		$sorgu->execute(array(':id'=>$id));
		if($sorgu->rowCount()){
			$row=$sorgu->fetch(PDO::FETCH_ASSOC);

?>
<title><?php 
if($row['baslat']==0){echo 'dur';}else{echo'saldir';}
?></title>

<?php
		}
		?>
		
		<meta http-equiv="refresh" content="3;">
</head>
<body>

</body>
</html>