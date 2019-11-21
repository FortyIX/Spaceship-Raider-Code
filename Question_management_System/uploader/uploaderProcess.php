
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



$difficulty=$_POST['diffi'];
$answer=$_POST['answer'];


$updated_image_name=$_FILES['image']['name'];
$image=addslashes(file_get_contents($_FILES['image']['tmp_name']));



$query="INSERT INTO `image`( `image_name`, `difficulty`, `answer`, `image`) VALUES ('$updated_image_name','$difficulty','$answer','$image')";


if($conn->query($query)==true)
      {


          header("Location:successfully_updated.php");
    }

$conn->close();


 ?>

