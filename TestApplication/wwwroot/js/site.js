// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
﻿// #id - id selector
// .class - class selector
// tag - tag selector
// * - all selector
// [attr] - attribute selector
//change table style

//change table style
$("#usersTable").addClass("table-hover text-center table-bordered table-sm userTable");

$("#usersTableHead").addClass("usersTableHead");
$("#usersTable thead").click(function () {
    $("#table1 tbody").toggle();
});
$("#usersTable thead").addClass("th");
$("#usersTable tr").hover(function () {
    $(this).toggleClass("table-primary");
});