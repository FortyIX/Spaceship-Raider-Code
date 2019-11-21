<?php

include 'db_connect.php';

$username=$_GET['usern'];
$status=$_GET['sta'];

$query="UPDATE `ac_status` SET `status`='$status' WHERE username='$username'";

$conn->query($query);


?>