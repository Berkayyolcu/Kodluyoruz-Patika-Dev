<!DOCTYPE html>
<html>
<head>
	
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Girilen Değeri 3'e Bölme</title>

	<!-- Bootstrap -->
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">

</head>
<body>


	<div class="container">
		<div class="row">
			<div class="col">

				<div class="p-3 border bg-light mx-auto mt-5 w-50 ">

					<form action="islem.php" method="post">

					<!--Baslık -->
					<h3 class="text-center text-dark mt-5"> Bir Sayı Giriniz</h3>
					
                    <!--input -->
					<input type="number" name="number" class="mt-5 mb-2 rounded" 
					style="margin:50px auto 0px auto; display:block;">

                    <!--Buton -->
					<button type="submit" class="btn btn-danger mb-5" name="gönder" 
					style="margin:50px auto 0px auto; display:block;">Gönder</button>

					</form>

				</div>

			</div>
		</div>	
	</div>



</body>
</html>