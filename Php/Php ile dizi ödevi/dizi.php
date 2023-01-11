
<?php 

$planets = ["Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "", "", NULL];



function myarray($array, $value)
{

$filter_array = array_filter($array); //filtre'den gecirip değikene aktarıyoruz.

$random_array = array_rand($filter_array, $value); 
/*rastgele veri getirmesi için array_rand'i kullanıyoruz ve 
parantez icinde $filter_array değiskenimizden rastgele gelceğini belirtiyoruz*/

$result = array_map(function ($value) use ($filter_array){
/*array_map olusturuyoruz parantez icinde fonksiyonumuzu olusturup 
$value parametresini belirtiyoruz sonra $filter_array
değiskeni belirtiyoruz sonrasında $result değiskenimize aktarıyoruz */

return $filter_array[$value]; 
},$random_array);
return $result; // geriye veri döndürür

}


echo "<pre>";
print_r(myarray($planets, 2)); //dizimizden 2 eleman gösterir.
print_r(myarray($planets, 3)); //dizimizden 3 eleman gösterir. 
print_r(myarray($planets, 2)); //dizimizden 2 eleman gösterir.
print_r(myarray($planets, 4)); //dizimizden 4 eleman gösterir. 
print_r(myarray($planets, 5)); //dizimizden 5 eleman gösterir. 


?>