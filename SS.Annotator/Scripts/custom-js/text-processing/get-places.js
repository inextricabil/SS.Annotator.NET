$(function () {

    function paintPlaces(placesArray) {
        placesArray.forEach(function(place) {
            console.log(place);
        });
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