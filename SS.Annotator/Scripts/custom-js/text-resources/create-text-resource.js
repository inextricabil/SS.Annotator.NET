function readUrl(input) {
    if (input.files && input.files[0]) {
        const reader = new FileReader();
        reader.onload = () => {
            const textName = input.files[0].name;
            input.setAttribute("data-title", textName);

            var file = input.files[0];
            if (file) {
                reader.readAsText(file, "UTF-8");
                reader.onload = function (evt) {
                    $("#TextBoxControl").val(evt.target.result);
                    setTimeout(function () {
                        $("#pills-file").removeClass("show");
                        $("#PillsText").trigger("click");
                    }, 1000);
                };
                reader.onerror = function() {
                    $("#TextBoxControl").val("Error while reading the text file.");
                };
            }
        };
        reader.readAsDataURL(input.files[0]);
    }
}

function getSelected() {
    if (window.getSelection) {
        return window.getSelection();
    }
    else if (document.getSelection) {
        return document.getSelection();
    }
    else {
        const selection = document.selection && document.selection.createRange();
        if (selection.text) {
            return selection.text;
        }
        return false;
    }
}

$(document).ready(function () {

    const defaultTextBoxControlText = "I go to school at Stanford University, which is located in California.";

    $("#AnnotateButton").click(function () {
        $("#AnnotateModal").modal();
    });

    $("#TextBoxControl").val(defaultTextBoxControlText);
    
    $("#TextBoxControl").mouseup(function () {
        const selection = getSelected();

        if (selection) {
            $("#CurrentSelection").val(selection);
            $("#ModalSelection").text(selection);
            $("#AnnotateButton").removeAttr("disabled");
        } else {
            $("#AnnotateButton").attr("disabled", "disabled");
        }
    });
});