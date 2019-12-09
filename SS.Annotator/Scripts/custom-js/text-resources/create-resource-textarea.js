//function highlightBlue() {
//    return $("#blue-word").val();
//}

//function highlightPink() {
//    return $("#pink-word").val();
//}

//function updateHighlights() {
//    $("textarea").highlightWithinTextarea("update");
//}

//$("textarea").highlightWithinTextarea({
//    highlight: [
//        {
//            highlight: highlightBlue,
//            className: "blue"
//        },
//        {
//            highlight: highlightPink,
//            className: "pink"
//        }
//    ]
//});

//$("input").on("input", updateHighlights);


$(".TextBoxControl").highlightWithinTextarea({
    highlight: [
        {
            highlight: "strawberry",
            className: "red"
        },
        {
            highlight: "blueberry",
            className: "blue"
        },
        {
            highlight: /ba(na)*/gi,
            className: "yellow"
        }
    ]
});