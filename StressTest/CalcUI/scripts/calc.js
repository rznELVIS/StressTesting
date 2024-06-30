$(document).ready(function(){
    $('#add-sum').click(function() {
        var agr1 = $("#add-agr-1").val();
        var agr2 = $("#add-agr-2").val();

        $.ajax({
            type: "post",
            url: "http://localhost:9001/Calc/Plus",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ first: agr1, second: agr2 })
        })
        .done(function(data) {
            $("#add-sum-result").text(data.result);
        })
    });
});
