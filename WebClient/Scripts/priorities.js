(function() {
  $.getJSON( "http://localhost:8080/priorities?callback=?")
  .done(function( data ) {
	  $.each(data, function(index, item) {
	  	console.log(item);
	  	
	  	$("#prioritiesList").append("<li>" + item.label + "</li>");
	  	//alert(item.label);
	  });
   /*
    $.each( data.items, function( i, item ) {
      $( "<img/>" ).attr( "src", item.media.m ).appendTo( "#images" );
      if ( i === 3 ) {
        return false;
      }
    });
    */
  });
})();
