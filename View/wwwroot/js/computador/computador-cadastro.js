$(function () {
    $("#computador-cadastro-categoria").select2({
        ajax: {
            url: "/categoria/",
            dataType:"json"
        }
    })
});