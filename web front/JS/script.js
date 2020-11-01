var num = 15;
var jqBarStatus = false;

function load_item() {
	
	//$.get( 'http://188.134.65.35', {name: "Полужизнь", k: "5"}, function(data){ alert(data); });
	
	
	
	$.ajax({
	  url: 'http://188.134.65.35',
	  type: 'get',
	  data: {name: 'Полужизнь', k: num},
	  dataType: 'json',
	  beforeSend: function() {
		//запуск спинера
	  },
	  success: function(data){ item_includ(data); }
	});
  
}

function item_includ(data) { //генератор карточек
	
	var fineel_text = '';
	var cart_text = '';
	var elem = document.getElementById('card_includ');

	
	for(i = 0; i < num; i++) //создание элемента и ввод в него данных
	{
		
		cart_text = '<div class="card"><img src="img/book.svg" class="card-img-top svg" alt="post img"><div class="card-body"><h5 class="card-title">';
		cart_text += data['names'][i];
		cart_text += '</h5><p class="card-text"><small class="text-muted">';
		cart_text += data['authors'][i];
		cart_text += '</small></p></div></div>';
		
		
		fineel_text += cart_text;
		
		//alert(cart_text);

		/*	пример сформированной карточки
		<div class="card">
			<img src="img/post3.jpg" class="card-img-top" alt="post img">
			<div class="card-body">
				<h5 class="card-title">Название карточки</h5>
				<p class="card-text">This card has supporting text below as a natural lead-in to additional content.</p> 
				<p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
			</div>
		</div>
		*/
	}
	
	elem.innerHTML = fineel_text;
	jqBarStatus = true;
	num += 15; 
  
}


$(function () {
    var jqBar = $('#bottom');
    $(window).scroll(function() {
        var scrollEvent = ($(window).scrollTop() > (jqBar.position().top - $(window).height()));
        if (scrollEvent && jqBarStatus) { 
            load_item();
        }
    });
});


function getRandomInt(min, max) {
  return Math.floor(Math.random() * (max - min)) + min;
}