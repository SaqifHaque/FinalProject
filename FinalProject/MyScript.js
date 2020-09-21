$(document).ready(function() {

    var split;
    var url = "https://localhost:44390/api/";

    $("#btnLogin").click(function() {
        alert('baal');
        validation();
    });

    function validation() {

        var uname = $("#uname").val();
        var password = $("#password").val();
        $.ajax({
            type: 'GET',
            url: "https://localhost:44390/api/Home",
            datatype: 'json',
            headers: {
                Authorization: 'Basic ' + btoa(uname + ':' + password)
            },
            success: function(data) {
                alert("Login");

            },
            error: function(data) {
                alert("Unauthorized");
            }
        });
    }


});