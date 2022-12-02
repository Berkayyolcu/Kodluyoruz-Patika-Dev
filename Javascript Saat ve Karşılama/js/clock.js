
let adınız = prompt("Adınız Soyadınızı Yazınız");

let print =  document.querySelector("#myName");

print.innerHTML = `${adınız}`;



function clock() {

	let date = new Date();  //date formatını olusturuyoruz
    let hours = date.getHours();  //saat bilgisini verir
    let minutes = date.getMinutes(); //dakika bilgisini verir
    let seconds = date.getSeconds(); //saniye bilgisini verir

    const gunler = ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"];
    const tme = new Date(); //date formatını olusturuyoruz
    let gun = gunler[tme.getDay()]; // gün formatını olusturur

    hours = (hours < 10) ? "0" + hours : hours;
    minutes = (minutes < 10) ? "0" + minutes : minutes;
    seconds = (seconds < 10) ? "0" + seconds : seconds;

    let time = hours + ":" + minutes + ":" + seconds + " " + gun
    document.getElementById('myClock').innerHTML = time;

}

setInterval(clock, 1000); // her 1 saniyede bir yenileme yapılıyor.