
<?php

session_start();
$_SESSION["update_id"]=$_GET["id"];


?>

<html>


<head>

<link rel="stylesheet" type="text/css" href="update_Style.css">
</head>

 <div class="container">

   

   <form action="updateProcess.php" method="post" enctype="multipart/form-data">

     <h1 class="title">Update Question</h1>
     <h3 class="que_tex">Select Question<h3>

    <input type="file" name="image" id="image" class="picker">

    <input type="submit" value="Update question" name="submit" class="upload_image">

    <h3 class="ans_tex">Answer</h3>
    <input type="text" name="answer" class="ans">


    <h3 class="dif_tex">Select Difficulty</h3>
    <input type="text" name="diffi" class="dif" list="difficulty">


    <datalist id="difficulty">
      <<option value="1"></option>>
      <<option value="2"></option>>
      <<option value="3"></option>>
      <<option value="4"></option>>
      <<option value="5"></option>>
    </datalist>


</from>

</div>





</html>