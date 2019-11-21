<?php
$servername = "localhost";
$username = "fuzhang0_spr";
$password = "zhangzhang";
$dbname= "fuzhang0_spr_data";

// Create connection
$conn = new mysqli($servername, $username, $password,$dbname);


// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

 ?>