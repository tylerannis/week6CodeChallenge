$(document).ready(function () {

    $('#content').on('click', '.ajax-get', function () {
        
        var urlRequest = $(this).data('url');
        //alert("Geting the Html");
        $.get(urlRequest, function (data) {
            $('#content').html(data);
        });
    });

});