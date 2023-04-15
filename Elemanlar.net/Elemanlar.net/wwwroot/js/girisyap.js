function GirisYap() {

    var Eposta = $("#txtEposta").val();
    var Sifre = $("#txtSifre").val();

    var model = { Eposta: Eposta, Sifre, Sifre };

    $.ajax({
        type: "GET",
        url: "/Home/GirisYap",
        dataType: "json",
        async: false,
        data: model,
        success: function (result) {                      
            
        },
        error: function (e) {
            console.log(e);
        },
    });

}