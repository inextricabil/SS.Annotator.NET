$(function () {

    function paintTimexs(timexsArray) {
        $("#ResultsModal").modal();
        $("#ResultsModalTitle").html("<strong>TIMEXs</strong>");
        for (var i = 0; i < timexsArray.length; i++) {
            var newDiv = document.createElement("div");
            newDiv.innerText = timexsArray[i];
            document.getElementById("ResultsModalContent").appendChild(newDiv);
        }
        //timexsArray.forEach(function(timex) {
        //    console.log(timex);
        //    $("#ResultsModalContent").innerText = $("#ResultsModalContent").innerText + timex + "<br/>";
        //});
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