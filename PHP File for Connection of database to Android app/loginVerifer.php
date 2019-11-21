<?php
include 'db_connect.php';

$name = $_POST["user"];
$pass = $_POST["pass"];

$hash=hash("sha1",$pass,false);
//echo "flag2";

$query="SELECT `hash` FROM `users` WHERE username='$name'";
//echo "flag3";

$get_hash=$conn->query($query);


if($get_hash->num_rows !=0){
  $row =$get_hash->fetch_assoc();
  //fetch data

  $stored_hash=$row["hash"];
  //giving hash value to a sting for comparing with existing pasasword typed by user
  //echo "flag1";


  if($hash == $stored_hash){
  
    echo "2333";
  
  
  }

  else{
  
     echo "2444";
  
  }
   
}


else{

 echo"2555";


}

$conn->close();


?>