<?php
include 'db_connect.php';


$tmp_diffi=$_GET["di"];

$query="SELECT `id` FROM `image` WHERE difficulty ='$tmp_diffi'";

$result=$conn->query($query);

$num_of_data=$result->num_rows;

for($i=0;$i<$num_of_data;$i++)
{

  $data=$result->fetch_assoc();
  echo $data["id"];
  if($i<$num_of_data-1){
  
  echo ",";
  
  
  }
}




 ?>