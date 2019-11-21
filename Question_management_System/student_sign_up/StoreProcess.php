<?php

include 'db_connect.php';

$name = $_POST['user_n'];
$rpass=$_POST['user_rp'];
$this_password=hash("sha1",$_POST['user_p']);



//$query="INSERT INTO `student_account`(`username`, `hash`) VALUES ('$name','$this_password')";


if($_POST['user_p']==$rpass){

 $tmp_query="SELECT `username` FROM `student_account` WHERE username='$name'";
 $tmp_value=$conn->query($tmp_query);

 if($tmp_value->num_rows == 0){
   $query="INSERT INTO `student_account`(`username`, `hash`) VALUES ('$name','$this_password')";

  if($conn->query($query)==true)
      {

          header("Location:notice.php");
    }

    else{
       echo "Error".$conn->error;
    }
 
  
       }
  
       
     else{
         // repeated user
       header("Location:repeated_username.html");
   }
   
   }
  else{

 // password not match
  header("Location:pwnomathch.html");


     }
  







$conn->close();





?>