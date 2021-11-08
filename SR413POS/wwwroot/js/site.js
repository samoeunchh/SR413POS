// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Get Unit
var options = "";
$.ajax({
    method: "GET",
    url: "/Products/GetUnits",
    dataType: "json",
    success: function (content) {
        $.each(content, function (i, v) {
            options += "<option value='" + v.unitId + "'>" + v.unitName + "</option>";
        });
    }, error: function (error) {
        console.log(error);
    }
});