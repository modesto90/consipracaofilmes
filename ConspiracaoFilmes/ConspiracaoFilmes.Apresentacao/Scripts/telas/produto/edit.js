
$("#formEditProduto").on("submit", function (e) {
    e.preventDefault();
    $.ajax({
        url: "/Produto/Edit",
        type: "POST",
        dataType: "json",
        data: $(this).serialize() + "&tipoPeso=" + $("#tipoPeso").val(),
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





