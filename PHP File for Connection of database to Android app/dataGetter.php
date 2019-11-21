<?php
include 'db_connect.php';

$query="SELECT * FROM `ac_status` WHERE 1";

$data_receive=$conn->query($query);

$output_array=array();

while($row=$data_receive->fetch_assoc()){

$output_array[]=$row;


}

echo json_encode($output_array);


?>