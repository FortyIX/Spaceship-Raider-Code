<?php

include 'db_connect.php';

$tmp_id=$_GET["id"];

$query="SELECT `image` FROM `image` WHERE id ='$tmp_id'";


$result=$conn->query($query);

$data=$result->fetch_assoc();

 header("Content-type: image/jpeg");
 //convert tp jpeg
  echo $data["image"];

?>