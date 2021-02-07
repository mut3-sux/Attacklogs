<?php

$user = $_GET['user'];
$ip = $_GET['ip'];
$port = $_GET['port'];
$time = $_GET['time'];
$method = $_GET['method'];
$datatime = $_GET['datatime'];
$key = $_GET['key'];

$myKey = "yourkey";// put your key
if($key != $myKey) die("Error, Invalid key");


if(!isset($user, $ip, $port, $time, $method)) die("Error, Fill in all GETs to continue");

$valid_char = array("c", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "v", "b", "n", "m", " ", ".", ",", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "_");

$split_ip = str_split($ip);

$split_port = str_split($port);

$split_time = str_split($time);

$split_method = str_split($method);

$split_datatime = str_split($datatime);

foreach($split_ip as $g) {
if(!in_array(strtolower($g), $valid_char)) die("Error, Invalid character in message");
}

foreach($split_ip as $h) {
if(!in_array(strtolower($g), $valid_char)) die("Error, Invalid character in message");
}

foreach($split_ip as $i) {
if(!in_array(strtolower($g), $valid_char)) die("Error, Invalid character in message");
}

foreach($split_ip as $j) {
if(!in_array(strtolower($g), $valid_char)) die("Error, Invalid character in message");
}

foreach($split_datatime as $k) {
if(!in_array(strtolower($g), $valid_char)) die("Error, Invalid character in message");
}

add_ip($user,$ip, $port, $time, $method, $datatime);

function add_ip($usr, $ms, $port, $time, $method, $datatime) {
$db = fopen("attacklog.txt", "a"); 
fwrite($db, "$usr:     IP: $ms     PORT: $port     TIME: $time     METHOD: $method     DATE/TIME: $datatime\n");
fclose($db);
echo "Text added";
}
