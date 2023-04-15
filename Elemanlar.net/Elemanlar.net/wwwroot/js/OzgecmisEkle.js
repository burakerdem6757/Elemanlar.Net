
function SehirleriGetir() {
    $.ajax({
        type: "GET",
        url: "/Home/OzgecmisSehirleriGetir",
        dataType: "json",
        async: false,
        data: null,
        success: function (result) {
            if (result.isSuccess == true) {
                var x = result.value;
                var html = "<option  value='0'>Seçiniz</option>";
                for (var i = 0; i < data.length; i++) {
                    html += '<option  value=' + data[i].Id + '>' + data[i].Name + '</option>';
                }
                $("#drdİl").html(html);
        },
        error: function (e) {
            console.log(e);
        }, //success: function (result) {
    });
}

$('#drdİl').on('change', function () {

    var mod = $("#drdİl").val();

    ilceleriGetir(mod);
});


function SehirleriDoldur() {

    Post("/JsonLocation/OSGBDoldur", null, function (data) {
        var html = "<option  value='0'>Seçiniz</option>";
        for (var i = 0; i < data.length; i++) {
            html += '<option  value=' + data[i].Id + '>' + data[i].Name + '</option>';
        }
        $("#drdosgb").html(html);

    }, function (err) { console.log(err); }, false)

}