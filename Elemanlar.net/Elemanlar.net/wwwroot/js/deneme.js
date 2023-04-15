
function Kaydet() {

    var AdSoyad = $("#adsoyad").val();
    var model = {
        AdSoyad: AdSoyad
    };

    $.ajax({
        type: "POST",
        url: "/Home/SaveKullanici",
        dataType: "json",
        data: model,
        async: false,
        success: function (result) {
            if (result.isSuccess == true) {
                alertim.toast("Kaydedildi.", alertim.types.success);
                icerikID = result.value.tabloID;
                /*location.href = "/CareerPost/Create?Id="+icerikID+"";*/
                modalAc(icerikID);

            } else {
                alertim.toast(result.reasons[0].message, alertim.types.danger);
            }
        },
        error: function (e) {
            console.log(e);            
            alertim.toast(result.reasons[0].message, alertim.types.danger);
        },
    });
}