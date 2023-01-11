<?php 

function ucgen($deger){   // değişken tanımladı.

      for($i=0; $i<=$deger; $i++){   //$say değişkeni içine yazılan sayıya kadar tekrar etmesi için bir döngü tanımladık.
    
        $j=0; 

          while($j<=$i){  //j değiskeni i degiskene esit ve kücük oldugu takdirde while döngüsü calısmaya devam edecek.

             $j++;   //j degiskenine atanan sayısal degeri 1 artırır.

            echo $j*0; // sıfır sayısına ulaşmak i.in sıfırla çarptık.
  
          }     

     echo  "<br>"; // her while döngüsü bittiğinde bir alt satıra gecirir.

   } 

}

ucgen(15); // tanımlanan değiskene değer atıyoruz.


?>