/*jslint browser:true */

// Task 03. Refactor the following examples to produce code with well-named identifiers in JavaScript.

function isBrowserMozilla(event, args) {
    'use strict';       // /\ I'm guessing I should get rid of these as they are never used but it's a homework for naming identifiers so...
    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        isMozilla = (browser === "Mozilla");

    if (isMozilla) {
        myWindow.alert("Yes");
    } else {
        myWindow.alert("No");
    }
}
