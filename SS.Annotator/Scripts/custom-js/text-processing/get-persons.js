$(function () {

    function paintPersons(personsArray) {
        $("#ResultsModal").modal();
        $("#ResultsModalTitle").html("<strong>Persons</strong>");
        $("#ResultsModalContent").html(personsArray.join("<br/>"));
        //personsArray.forEach(function(person) {
        //    console.log(person);
        //    $("#ResultsModalContent").innerText = $("#ResultsModalContent").innerText + person + "<br/>";
        //});
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