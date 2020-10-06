//Ekleme İşlemi
$(document).on("click", "#mznEkle", async function () {
    const { value: formValues } = await Swal.fire({
        title: 'Mezun Ekle',
        html:
            '<input id="mznAd" class="swal2-input">'
        
  
    })

        var mznAd = $("#mznAd").val();
        $.ajax({
            type: 'Post',
            url: '/Mezun/EkleJson',
            data: { "mznAd": mznAd },
            dataType: 'Json',
            success: function (data) {

                var mznId = data.Result.Id;
                var mznAd = '<td>' + data.Result.Ad + '</td>';
                var mznSoyad = '<td>' + data.Result.Soyad + '</td>';
                var mznTel = '<td>' + data.Result.Tel + '</td>';
                var mznEposta = '<td>' + data.Result.Eposta + '</td>';
                var mznFirma = '<td>' + data.Result.Firma + '</td>';
                var Pozısyon = '<td>' + data.Result.Pozısyon + '</td>';
                var CalısmaAlanları = '<td>' + data.Result.CalısmaAlanları + '</td>';
                var YabancıDil = '<td>' + data.Result.YabancıDil + '</td>';
                var guncelleButon = "<td><button class='guncelle btn btn-primary' value='" + mznId + "' > Güncelle</button></td > ";
                var silButon = "<td><button class='sil btn btn-danger' value='" + mznId + "' > Sil</button></td > ";


                $("#example tbody").prepend('<tr>' + mznAd + mznSoyad + mznTel + mznEposta + mznFirma + Pozısyon + CalısmaAlanları + YabancıDil + guncelleButon + silButon + '</tr>');
                Swal.fire({
                    type: 'success',
                    title: 'Mezun Eklendi',
                    text: 'İşlem başarıyla gerçekleşti!'
                });
            },
            error: function () {
                Swal.fire({
                    type: 'error',
                    title: 'Mezun Eklenemedi',
                    text: 'Bir sorunla karşılaşıldı!'
                });
            }
        });          
});

//Güncelleme İşlemi
$(document).on("click", ".guncelle", async function () {

    var mznId = $(this).val();
    var mznAdTd = $(this).parent("td").parent("tr").find("td:first");
    var mznAd = mznAdTd.html();
    const { value: formValues } = await Swal.fire({
        title: 'Mezun Güncelle',
        html:
            '<input id="mznAd" value="' + mznAd + '" class="swal2 - input">'


    })
    mznAd = $("#mznAd").val();

        $.ajax({
            type: 'Post',
            url: '/Mezun/GuncelleJson',
            data: { "mznId": mznId,"mznAd": mznAd },
            dataType: 'Json',
            success: function (data) {
                if (data == "1") {
                    mznAdTd.html(mznAd);
                    Swal.fire({
                        type: 'success',
                        title: 'Mezun Güncellendi',
                        text: 'İşlem başarıyla gerçekleşti!'
                    });
                }
                else {
                    Swal.fire({
                        type: 'error',
                        title: 'Mezun Güncellenemedi',
                        text: 'Bir sorunla karşılaşıldı!'
                    });
                }
            },
            error: function () {
                Swal.fire({
                    type: 'error',
                    title: 'Mezun Güncellenemedi',
                    text: 'Bir sorunla karşılaşıldı!'
                });
            }
        }); 
});

//Silme İşlemi
$(document).on("click", ".sil", async function () {
    var tr = $(this).parent("td").parent("tr");
    var mznId = $(this).val();
    $.ajax({
        type: 'Post',
        url: '/Mezun/SilJson',
        data: { "mznId": mznId },
        dataType: 'Json',
        success: function (data) {
            if (data == "1") {
                tr.remove();
                Swal.fire({
                    type: 'success',
                    title: 'Mezun Silindi',
                    text: 'İşlem başarıyla gerçekleşti!'
                });
            }
            else {
                Swal.fire({
                    type: 'error',
                    title: 'Mezun Silinemedi',
                    text: 'Bir sorunla karşılaşıldı!'
                });
            }
        },
        error: function () {
            Swal.fire({
                type: 'error',
                title: 'Mezun Silinemedi',
                text: 'Bir sorunla karşılaşıldı!'
            });
        }
    });

});

