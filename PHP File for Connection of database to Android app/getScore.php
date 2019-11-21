<?php
include 'db_connect.php';

$name=$_GET["usern"];

$query="SELECT `score` FROM `scores` WHERE username='$name'";

//echo "flag";

$result=$conn->query($query);

//echo "flag2";


$data=$result->fetch_assoc();

//echo "flag3";
echo $data['score'];

  
$conn->close();

?>