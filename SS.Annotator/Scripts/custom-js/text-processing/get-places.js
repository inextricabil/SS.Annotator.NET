$(function () {

    function paintPlaces(placesArray) {
        $("#ResultsModal").modal();
        $("#ResultsModalTitle").html("<strong>Places</strong>");
        $("#ResultsModalContent").html(placesArray.join("<br/>"));
        //placesArray.forEach(function(place) {
        //    console.log(place);
        //    $("#ResultsModalContent").innerText = $("#ResultsModalContent").innerText + place + "<br/>";
        //});
    }
    
    $("#GetPlaces").click(function() {
        const getPlaceRequest = { "Text": $("#TextBoxControl").val() };
        const getPlacesApiUrl =
            window.location.protocol + "//" + window.location.host + "/api/TextProcessing/GetPlaces";

        $.ajax({
            type: "POST",
            url: getPlacesApiUrl,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(getPlaceRequest),
            success: function (jsonResponse) {
                //GetPlaces response
                const placesArray = jsonResponse.placesArray;
                paintPlaces(placesArray);
            }
        });
    });
});