$(document).ready(function(){
    $('#add-sum').click(function() {
        var agr1 = $("#add-agr-1").val();
        var agr2 = $("#add-agr-2").val();

        $.post(
            "http://0.0.0.0:9001/Calc/Plus", 
            { first: agr1, second: agr2 })
        .done(function(data) {
            alert(data);
        })
    });
});
