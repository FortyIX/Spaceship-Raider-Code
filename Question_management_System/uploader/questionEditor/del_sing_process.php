<?php

include '../../db_connect.php';

$del_id=$_GET["id"];


$query= "DELETE FROM `image` WHERE id='$del_id'";

if($conn->query($query==true))
  {
       
          header("Location:succ_changed.php");
    }
    else
    {
         echo "Error".$conn->error;
    }
    

$conn->close();

?>