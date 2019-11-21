
<html>

<?php
session_start();
$_SESSION = array();
session_destroy();
//echo $_SESSION['loggedin'];



 ?>

<script>

 alert("you has been successfully logedd off");

</script>
<a href="../index.php">click here to come back to login page</a>


</html>
