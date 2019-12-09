$(function () {

    function paintDates(datesArray) {
        datesArray.forEach(function(date) {
            console.log(date);
        });
    }

    $("#GetDates").click(function () {
        const getDatesRequest = { "Text": $("#TextBoxControl").val() };
        const getDatesApiUrl = window.location.protocol + "//" + window.location.host + "/api/TextProcessing/GetDates";

        $.ajax({
            type: "POST",
            url: getDatesApiUrl,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(getDatesRequest),
            success: function (jsonResponse) {
                //GetDates response
                const datesArray = jsonResponse.datesArray;
                paintDates(datesArray);
            }
        });
    });
});