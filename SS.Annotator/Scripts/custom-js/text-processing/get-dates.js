$(function () {
    
    function paintDates(datesArray) {
        $("#ResultsModal").modal();
        $("#ResultsModalTitle").html("<strong>Dates</strong>");
        $("#ResultsModalContent").html(datesArray.join("<br/>"));
        //datesArray.forEach(function(date) {
        //    console.log(date);
        //    $("#ResultsModalContent").innerText = $("#ResultsModalContent").innerText + date + "<br/>";
        //});
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