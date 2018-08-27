    carregaDrop();
    $("#ddl").on("change", function () {
        $("#idCliente").val($(this).val());
        console.log($("#idCliente").val());
    });

    $("#formPostProduto").on("submit", function (e) {
        e.preventDefault();
        $.ajax({
            url: "/Produto/Create",
            type: "POST",
            dataType: "json",
            data: $(this).serialize()+"&tipoPeso="+$("#tipoPeso").val(),
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

    $("#tipoPeso").on("change", function () {
        var field = $(this);
        var peso = $("#peso");
        $(peso).val("");
        if ($(field).val() != "NA") {
            $(peso).prop("disabled", false);
        }
        else {
            $(peso).prop("disabled", true);

        }
    });


function carregaDrop() {
    $.ajax({
        url: "/Cliente/GetClientes",
        dataType: "json",
        success: function (json) {
            var drop = $("#ddl")
            $.each(json, function (index, item) {
                if (index == 0) {
                    $("#idCliente").val(item.id);
                }
                var opt = "<option value=" + item.id + ">" + item.nome + "</option>";
                $(drop).append(opt);
            });
        }
    })
}


