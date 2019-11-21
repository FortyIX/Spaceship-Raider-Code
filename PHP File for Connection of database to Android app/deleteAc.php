<?php

include 'db_connect.php';

$name=$_GET["usern"];

$query="DELETE FROM `student_account` WHERE username='$name'";
$query2="DELETE FROM `ac_status` WHERE username='$name'";
$query3="DELETE FROM `scores` WHERE username='$name'";

$conn->query($query);
$conn->query($query2);
$conn->query($query3);

if($conn->query($query)==true)
  {
       if($conn->query($query2)==true)
       {
          if($conn->query($query3)==true)
              {
       
                   echo "2123";
          
              }
              else
               {
                  echo "Error".$conn->error;
               }
          
     }
     else
      {
          echo "Error".$conn->error;
      }
          
 }
 else
  {
         echo "Error".$conn->error;
  }
    

$conn->close();



?>