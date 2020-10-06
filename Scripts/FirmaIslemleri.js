//Ekleme İşlemi
$(document).on("click", "#frmEkle", async function () {
    const { value: formValues } = await Swal.fire({
        title: 'Firma Ekle',
        html:
            '<input id="frmAd" class="swal2-input">'
        
  
    })

        var frmAd = $("#frmAd").val();
        $.ajax({
            type: 'Post',
            url: '/Firma/EkleJson',
            data: { "frmAd": frmAd },
            dataType: 'Json',
            success: function (data) {

                var frmId = data.Result.Id;
                var frmAd = '<td>' + data.Result.Ad + '</td>';
                var frmSoyad = '<td>' + data.Result.Soyad + '</td>';
                var frmTel = '<td>' + data.Result.Tel + '</td>';
                var frmEposta = '<td>' + data.Result.Eposta + '</td>';
                var frmFirma = '<td>' + data.Result.Firma + '</td>';
                var Pozısyon = '<td>' + data.Result.Pozısyon + '</td>';
                var CalısmaAlanları = '<td>' + data.Result.CalısmaAlanları + '</td>';
                var YabancıDil = '<td>' + data.Result.YabancıDil + '</td>';
                var frmguncelleButon = "<td><button class='frmguncelle btn btn-primary' value='" + frmId + "' > Güncelle</button></td > ";
                var silButon = "<td><button class='sil btn btn-danger' value='" + frmId + "' > Sil</button></td > ";


                $("#example tbody").prepend('<tr>' + frmAd + frmSoyad + frmTel + frmEposta + frmFirma + Pozısyon + CalısmaAlanları + YabancıDil + frmguncelleButon + silButon + '</tr>');
                Swal.fire({
                    type: 'success',
                    title: 'Firma Eklendi',
                    text: 'İşlem başarıyla gerçekleşti!'
                });
            },
            error: function () {
                Swal.fire({
                    type: 'error',
                    title: 'Firma Eklenemedi',
                    text: 'Bir sorunla karşılaşıldı!'
                });
            }
        });          
});

//Güncelleme İşlemi
$(document).on("click", ".frmguncelle", async function () {

    var frmId = $(this).val();
    var frmAdTd = $(this).parent("td").parent("tr").find("td:first");
    var frmAd = frmAdTd.html();
    var frmAlanTd = $(this).parent("td").parent("tr").find("td:nth-child(2)");
    var frmAlan = frmAlanTd.html();    
    const { value: formValues } = await Swal.fire({
        title: 'Firma Güncelle',
        html:
            '<input id="frmAd" value="' + frmAd + '" class="swal2 - input">' +
            '<input id="frmAlan" value="' + frmAlan + '" class="swal2 - input">'
        


    })
    frmAd = $("#frmAd").val();
    frmAlan = $("#frmAlan").val();
  

        $.ajax({
            type: 'Post',
            url: '/Firma/GuncelleJson',
            data: { "frmId": frmId, "frmAd": frmAd, "frmAlan": frmAlan },
            dataType: 'Json',
            success: function (data) {
                if (data == "1") {
                    frmAdTd.html(frmAd);
                    frmAlanTd.html(frmAlan);                   
                    Swal.fire({
                        type: 'success',
                        title: 'Firma Güncellendi',
                        text: 'İşlem başarıyla gerçekleşti!'
                    });
                }
                else {
                    Swal.fire({
                        type: 'error',
                        title: 'Firma Güncellenemedi',
                        text: 'Bir sorunla karşılaşıldı!'
                    });
                }
            },
            error: function () {
                Swal.fire({
                    type: 'error',
                    title: 'Firma Güncellenemedi',
                    text: 'Bir sorunla karşılaşıldı!'
                });
            }
        }); 
});

//Silme İşlemi
$(document).on("click", ".sil", async function () {
    var tr = $(this).parent("td").parent("tr");
    var frmId = $(this).val();
    $.ajax({
        type: 'Post',
        url: '/Firma/SilJson',
        data: { "frmId": frmId },
        dataType: 'Json',
        success: function (data) {
            if (data == "1") {
                tr.remove();
                Swal.fire({
                    type: 'success',
                    title: 'Firma Silindi',
                    text: 'İşlem başarıyla gerçekleşti!'
                });
            }
            else {
                Swal.fire({
                    type: 'error',
                    title: 'Firma Silinemedi',
                    text: 'Bir sorunla karşılaşıldı!'
                });
            }
        },
        error: function () {
            Swal.fire({
                type: 'error',
                title: 'Firma Silinemedi',
                text: 'Bir sorunla karşılaşıldı!'
            });
        }
    });

});

