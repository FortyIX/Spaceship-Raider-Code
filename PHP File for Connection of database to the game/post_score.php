<?php

include 'db_connect.php';


$scores=$_GET['sco'];
$username=$_GET['usern'];


$tmp_query="SELECT `score` FROM `scores` WHERE username='$username'";

$result=$conn->query($tmp_query);
$data=$result->fetch_assoc();

$tmp_store=$data['score'];

//echo $tmp_store;
//check if the existing score is higher than player's new score 


if($tmp_store < $scores){

   //echo $scores;
   $query="UPDATE `scores` SET `score`='$scores' WHERE username='$username'";
   $conn->query($query);
   echo "done";

}
else{

echo "do nothing";

}




$conn->close();



?>