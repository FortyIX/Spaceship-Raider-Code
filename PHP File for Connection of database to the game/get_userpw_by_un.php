<?php

include 'db_connect.php';

$username=$_GET['usern'];

$query="SELECT `password` FROM `student_account` WHERE username='$username'";

$result=$conn->query($query);

$data=$result->fetch_assoc();
echo $data['password'];




?>