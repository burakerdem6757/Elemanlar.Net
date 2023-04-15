function ModalKaydet() {
    $("#loader").show();

    var BaslangicTarihi = eventGun;
    var BitisTarihi = eventGun;

    var dt = new Date();
    //var time = dt.getHours() + ":" + dt.getMinutes() + ":" + dt.getSeconds();
    //var timebas = 09 + ":" + 00 + ":" + 00;
    //var timebit = 19 + ":" + 00 + ":" + 00;

    //if (eventBaslik == "Diğer") {
    //    RezerveTipID = 4;
    //}
    //else if (eventBaslik == "Kişisel Maruziyet") {
    //    RezerveTipID = 3;
    //}
    //else if (eventBaslik == "Toplantı") {
    //    RezerveTipID = 2;
    //}
    //else if (eventBaslik == "Mülakat") {
    //    RezerveTipID = 1;
    //}
    //else if (eventBaslik == "Hatırlatma") {
    //    RezerveTipID = 5;
    //}
    var OncekiBaslangicZamani = oncekibaslangicsaati;
    var BaslangicZamani = $('#txtBaslangicSaati').val();
    if (OncekiBaslangicZamani == undefined) {
        OncekiBaslangicZamani = BaslangicZamani;
    }
    var BitisZamani = $('#txtBitisSaati').val();
    var Baslik = $('#txtBaslik').val();
    var Not = $('#txtNot').val();
    var egitim = $('#drdegitim').val();
    var CalismaDosyasiID = $("#drdCalismaDosyasi").val();
    var ProjeAdi = $("#txtProjeAdi").val();
    var Kisi;
    var KisiAdi;
    if (CalismaDosyasiID > 0) {
        Kisi = $('#drdKisi').val();
        KisiAdi = $('#drdKisi option:selected').text();
    }
    else {
        Kisi = $("#drdAramaliKisi").val();
        KisiAdi = $('#drdAramaliKisi option:selected').text();
    }
    if (Kisi == 0 || Kisi == null) {
        alertim.toast("Aday seçmelisiniz", alertim.toast.danger);
        $("#loader").hide();
        return;
    }
    var TabloID = $("#btnModalKaydet").attr("save");

    var doluZaman = { TabloID: TabloID, BaslangicTarihi: BaslangicTarihi, BitisTarihi: BitisTarihi, RezerveTipID: RezerveTipID, OncekiBaslangicZamani: OncekiBaslangicZamani, BaslangicZamani: BaslangicZamani, BitisZamani: BitisZamani, Baslik: Baslik, Kisi: Kisi, Not: Not, CalismaDosyasiID: CalismaDosyasiID, ProjeAdi: ProjeAdi, AksiyonİlgiliEgitimTipiID: egitim, KisiAdi: KisiAdi };


    setTimeout(function () {
        $.ajax({
            type: "POST",
            url: "/TakvimDoluZamanlar/Index",
            dataType: "json",
            async: false,
            data: doluZaman,
            success: function (result) {
                if (result.isSuccess == true) {
                    $("#loader").hide();

                    alertim.toast("Kayıt eklenmiştir.", alertim.types.success);
                    window.location.reload();
                } else {
                    $("#loader").hide();

                    alertim.toast(result.reasons[0].message, alertim.types.danger);
                }
            },
            error: function (e) {
                $("#loader").hide();
                console.log(e);
            },
        })
    }, 1000);
}