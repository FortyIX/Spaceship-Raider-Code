<?php
include 'db_connect.php';

$name = $_POST["user"];
$password3 = $_POST["password1"];

$enter_password=hash("sha1",$password3);
// change user's input into hash

$query="SELECT `hash` FROM `users` WHERE username = '$name'";
//querying hash from database

$hash_get=$conn->query($query);
// hash of password of username which user type


if($hash_get->num_rows !=0){
  $row =$hash_get->fetch_assoc();
  //fetch data

  $stored_hash=$row["hash"];
  //giving hash value to a sting for comparing with existing pasasword typed by user

  if($stored_hash==$enter_password){

 //echo $stored_hash;
 //echo "********";
 //echo $enter_password;
  session_start();

    $_SESSION['loggedin']=true;
    $_SESSION['username']=$name;

  if($_SESSION['loggedin']==true){
    header("Location:uploader\uploader.php");
}


  
  }
  else{
  header("Location:wrongpassword.php");
  }

       }

  else{
    header("Location:userdonesntexist.php");
  }



$conn->close();













 ?>
