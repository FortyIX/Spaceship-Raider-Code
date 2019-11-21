
<?php


include '../../db_connect.php';

session_start();

$tmp_id=$_SESSION['update_id'];

//echo $tmp_id;
$difficulty=$_POST['diffi'];
$answer=$_POST['answer'];



//echo "mark1";
$updated_image_name=$_FILES['image']['name'];
$image=addslashes(file_get_contents($_FILES['image']['tmp_name']));


//echo "mark2";

$query="UPDATE `image` SET image_name='$updated_image_name',difficulty='$difficulty',answer='$answer',image='$image' WHERE id ='$tmp_id'";

//echo "mark3";
if($conn->query($query)==true)
      {
         //echo "mark4";
          header("Location:succ_changed.php");
    }
    else
    {
         echo "Error".$conn->error;
    }
    

$conn->close();


 ?>