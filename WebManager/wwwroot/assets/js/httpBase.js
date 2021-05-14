var http = "http://localhost:5000/";
function ajaxRequst(method, url, dataModel, callBack) {
    $.ajax({
        type:method,
        url: http +url,
        data: dataModel,
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded',
        success: callBack
    });
}