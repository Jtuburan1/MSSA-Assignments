// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showPosition() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            let positionInfo = "Your current location is latitude: " + position.coords.latitude + " longitude: " + position.coords.longitude + " altitude: " + position.coords.altitudeAccuracy;
            document.getElementById("position").innerHTML = positionInfo;
        });
    }
    else {
        alert("No geolocation available");
    }
}