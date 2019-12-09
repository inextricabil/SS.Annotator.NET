$(function () {

    function paintPersons(personsArray) {
        personsArray.forEach(function(person) {
            console.log(person);
        });
    }

    $("#GetPersons").click(function () {
        const getPersonRequest = { "Text": $("#TextBoxControl").val() };
        const getPersonsApiUrl = window.location.protocol + "//" + window.location.host + "/api/TextProcessing/GetPersons";

        $.ajax({
            type: "POST",
            url: getPersonsApiUrl,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(getPersonRequest),
            success: function (jsonResponse) {
                //GetPersons response
                const personsArray = jsonResponse.personsArray;
                paintPersons(personsArray);
            }
        });
    });
});