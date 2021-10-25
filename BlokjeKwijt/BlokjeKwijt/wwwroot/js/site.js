// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var colorPicker = document.getElementById('HexInput');
var anchor = document.getElementById('ColorPicker');

colorPicker.addEventListener("input", watchInput, false);
anchor.addEventListener("input", watchColourPicker, false);


function watchInput(event) {
    anchor.value = event.target.value;
}

function watchColourPicker(event) {
    colorPicker.value = event.target.value;
}