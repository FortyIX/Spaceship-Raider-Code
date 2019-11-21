<?php

  session_start();

if (isset($_SESSION['loggedin']) == false )
{
  header("Location:../index.php");
  //exit;
}

else{
      //var_dump($_SESSION);
      
      echo "Welcome to question uploder v1.0, " . $_SESSION['username'] . "!"."<html> </br> </html> "."Please don't forget to log off after finish uploading";
      
      
}
?>

<html>
<head>

<title>Uploader !</title>
<link rel="stylesheet" type="text/css" href="uploader_style.css">


</head>


<body>



 <div class="container">



   <form action="uploaderProcess.php" method="post" enctype="multipart/form-data">

     <h3 class="que_tex">Select Question<h3>

    <input type="file" name="image" id="image" class="picker">

    <input type="submit" value="Upload Image" name="submit" class="upload_image">

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
<button type="button" onclick="init_logout()" class="logoff">Log off</button>

 <button type="button" onclick="init_help()" class="help_but">Help</button>
<div>


</div>
 </div>

</br></br></br></br></br></br>
<button type="button" class="mana" onclick="init_question_manager()">Question Management</button>

 <script>

 function init_logout(){
  window.open("logoffProcess.php");
 }

 function init_help(){

var myWindow = window.open("uploader_help.html", "", "width=800,height=500");

 }

 function init_question_manager(){

var windows=window.open("question_manager.php", "", "width=1200,height=580");

 }
 </script>



</body>








</html>








</html>