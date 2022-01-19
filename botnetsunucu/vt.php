<?php

$dsn = "mysql:host=localhost;dbname=botnet;charset=utf8mb4";//veritabanı adını girin
$user = "root";//kullanıcı adını girin
$passwd = "";//şifreyi adını girin

$db = new PDO($dsn, $user, $passwd);

$db-> setAttribute (PDO :: ATTR_ERRMODE, PDO :: ERRMODE_WARNING);


                  

?>