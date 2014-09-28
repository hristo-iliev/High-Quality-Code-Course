function clickOnButton(event, argumenti) {
    var myWindow = window;
    var browser = myWindow.navigator.appCodeName;
    var isMozilla = browser;
    if (isMozilla == "Mozilla") {
        alert("The Browser is Mozilla!");
    } else {
        alert("The Browser isn't Mozilla!");
    }
}