$(function () {

    function paintTimexs(timexsArray) {
        timexsArray.forEach(function(timex) {
            console.log(timex);
        });
    }

    $("#GetTIMEXs").click(function () {
        const getTimexRequest = { "Text": $("#TextBoxControl").val() };
        const getTimexsApiUrl = window.location.protocol + "//" + window.location.host + "/api/TextProcessing/GetTimeXs";

        $.ajax({
            type: "POST",
            url: getTimexsApiUrl,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(getTimexRequest),
            success: function (jsonResponse) {
                //GetTimeXs response
                const timexsArray = jsonResponse.timexsArray;
                paintTimexs(timexsArray);
            }
        });
    });
});