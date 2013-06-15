(function() {
  var priorities;
  var that = this;
  
  $('body').delegate("li", "click", function(item) {
  	console.log(that.priorities);
  	console.log($(this).text());
  });
  
  $.getJSON( "http://localhost:8080/priorities?callback=?")
  	.done(function( data ) {
      that.priorities = data;
	  $.each(data, function(index, item) {
	  	$("#prioritiesList").append("<li>" + item.label + "</li>");
	  });
  });
})();
