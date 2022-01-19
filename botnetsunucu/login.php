<?php

include("vt.php");

  ob_start();
  session_start();
  
  $admin1=htmlspecialchars(strip_tags($_POST['ad']));
  $sifre1=htmlspecialchars(strip_tags($_POST['sifre']));
  
  $admin="captankanka";
  $sifre="1234";
  
  if($admin=$admin1){
	  if($sifre=$sifre1)
	  {
		  
		  
		  $_SESSION["login"] = "true";
  $_SESSION["username"] = $ad;
  $_SESSION["password"] = $password;
  
  $_SESSION["id"] = $id;
  
  header("Location:icerik.php");
  exit;
		  
		  
	  }
  }
  ?>