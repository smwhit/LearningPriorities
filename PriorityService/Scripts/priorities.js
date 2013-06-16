(function () {
    var priorities;
    var that = this;

    $('body').delegate("li", "click", function (item) {
        console.log(that.priorities);
        //console.log($(this).text());
    });

    $("body").delegate("li", "dblclick", function () {
        //var src = $(this).attr("id");
        alert($(this).text());
    });

    $.getJSON("/priorities")
  	.done(function (data) {
  	    that.priorities = data;
  	    $.each(data, function (index, item) {
  	        var li = $("<li>" + item.label + "</li>").attr("data-id", item.id);  	       
  	        $("#prioritiesList").append(li);
  	    });
  	});
})();
