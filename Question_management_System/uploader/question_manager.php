<html>
<head>

<link rel="stylesheet" type="text/css" href="question_manager_style.css">
</head>

<?php

  session_start();

if (isset($_SESSION['loggedin']) == false )
{
  header("Location:../index.php");
  //exit;
}

          
?>

<?php


include '../db_connect.php';

$query="SELECT `id`, `image_name`, `difficulty`, `answer`, `image` FROM `image` WHERE 1";
$data_receive=$conn->query($query);

$row=$data_receive->fetch_assoc();

$row_num =$data_receive->num_rows;



echo "<table>";

   echo "<tr><th>Question ID</th><th>Image File Name</th><th>Difficulty</th><th>Answer</th><th>Image preview</th><th>Edit</th></tr>";

   while($row=$data_receive->fetch_assoc()){
     //while fetch_assoc() not return NULL
        
      $Id=$row["id"];
   echo "<tr><td>".$row["id"]."</td><td>".$row["image_name"]."</td><td>".$row["difficulty"]."</td><td>".$row["answer"]."</td><td>".'<img src="data:image/jpeg;base64,'.base64_encode( $row['image'] ).'"/>'."</td><td>".'<button><a href="questionEditor/edit_single_qu.php?id='.$Id.'">Update</a></button>'."</td></tr>";       
     
   } 


echo"</table>";



$conn->close();


?>






</html>