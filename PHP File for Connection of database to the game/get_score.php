<?php

include 'db_connect.php';


$query="SELECT `username`, `score` FROM `scores` ORDER BY score DESC";

$result=$conn->query($query);

$num_of_data=$result->num_rows;

for($i=0;$i<$num_of_data;$i++)
{

  $data=$result->fetch_assoc();
  //fetch data
  
  echo "\t"."\t".$data["username"]."\t"."\t"."\t".$data['score'].PHP_EOL;
  echo PHP_EOL;
    
}

 
  

 


?>