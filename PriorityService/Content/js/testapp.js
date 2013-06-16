//	        $.ajax({
//	            url: '/priorities',
//	            type: 'POST',
//	            data: JSON.stringify({'Label': 'omg', 'id': 123}),
//	            contentType: 'application/json; charset=utf-8',
//	            dataType: 'json',
//	            async: false,
//	            success: function (msg) {
//	                alert(msg);
//	            }
//	        });
$.fn.editable.defaults.mode = 'inline';
$.fn.editable.defaults.ajaxOptions = { contentType: 'application/json; charset=utf-8' };
//$().editable({
//    ajaxOptions: {
//        contentType: 'application/json; charset=utf-8'
//    }
//});
$('#Label').editable({
    type: 'text',
    url: '/priorities',
    pk: 1,
    params: function (params) {
        var payload = { 'label': params.value };
        return JSON.stringify(payload);
    },
    success: function (data, config) {
        console.log(data);
    }
});