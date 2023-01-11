<?php 

if (isset($_POST["number"])) { 

	$number = $_POST["number"]; // input alanına girilen değer bu kısma iletilir

	if($number == ""){  // gönderilen değeri $number değiskene atadıkdan sonra bosmu dolumu kontrol edilir

		echo "Boş Bırakmayın !"."<br>";
		echo "<strong>". " 2 Saniye İçinde Girişe Yönlendiriliyorsunuz " ."</strong>";
		header('Refresh:2 ; URL=index.php'); // gönderilen değer bos ise bir önceki sayfa yönlendirir.

	}else{

		if ($number % 3 == 0) { // $number değiskene gelen değer 3'e tam bölünüyormu kontrol edilir.
			
			echo "${number} sayısı 3 ile tam bölünüyor";
			header('Refresh:2 ; URL=index.php');

		}else {
			
			$farkKontrol = $number;
			$farkKontrol++;
			while ($farkKontrol % 3 !== 0) { 
			/* iletilen değer eger 3'e tam bölünmüyorsa 1 artırarak  3'e tam bölünebilcek en yakın sayı bulunur */
				$farkKontrol++;
			}

			echo "${number} Sayısı 3 İle Tam Bölünemiyor ve Girdiğin Değere En Yakın 3 İle Tam Bölünen Sayı:
			${farkKontrol}";

			header('Refresh:10 ; URL=index.php');

		}
	}
}



?>