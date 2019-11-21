<?php

include 'db_connect.php';

$username=$_GET['usern'];

$query="SELECT `status` FROM `ac_status` WHERE username='$username'";

$result=$conn->query($query);

$data=$result->fetch_assoc();
echo $data['status'];


?>