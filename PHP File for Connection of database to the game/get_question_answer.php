<?php
include 'db_connect.php';


$tmp_id=$_GET["id"];

$query="SELECT `answer` FROM `image` WHERE id ='$tmp_id'";

$result=$conn->query($query);

$data=$result->fetch_assoc();
  
  echo $data["answer"];



 ?>