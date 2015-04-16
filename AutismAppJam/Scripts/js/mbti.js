$(document).ready(function() {

   $(".group2, .group3, .group4, .group5, .group6, .group7").hide();

   $("#popup_close_one").click(function () {
        $(".group2").show();
        $("#popup_button_one").hide();
        $(".group1").hide();
        window.scrollTo(0, 0);

   });

   $("#popup_close_two").click(function () {
       $(".group3").show();
       $("#popup_button_two").hide();
       $(".group2").hide();
       window.scrollTo(0, 0);

   });

   $("#popup_close_three").click(function () {
       $(".group4").show();
       $("#popup_button_three").hide();
       $(".group3").hide();
       window.scrollTo(0, 0);

   });

   $("#popup_close_four").click(function () {
       $(".group5").show();
       $("#popup_button_four").hide();
       $(".group4").hide();
       window.scrollTo(0, 0);

   });

   $("#popup_close_five").click(function () {
       $(".group6").show();
       $("#popup_button_five").hide();
       $(".group5").hide();
       window.scrollTo(0, 0);

   });

   $("#popup_close_six").click(function () {
       $(".group7").show();
       $("#popup_button_six").hide();
       $(".group6").hide();
       window.scrollTo(0, 0);

   });

});



// Semicolon (;) to ensure closing of earlier scripting
// Encapsulation
// $ is assigned to jQuery
