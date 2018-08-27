﻿
$("#formEditCliente").on("submit", function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Cliente/Edit",
        type: "POST",
        dataType: "json",
        data: $(this).serialize(),
        success: function (json) {
            if (json.status == 0) {
                gridLoad();
            }

        },
        error: function (e) {
            alert("Erro interno");
            console.log(e);

        }
    });
});