
$(document).ready(function () {
    gridLoad();

});
function createCliente() {
    openModal('/Cliente/Create');
}

function createProduto() {
    openModal('/Produto/Create');
}
function editCliente(id) {
    openModal('/Cliente/Edit?id=' + id);

}
function editProduto(id) {
    openModal('/Produto/Edit?idProduto=' + id);

}
function gridLoad() {
    $.ajax({
        url: "/Produto/GetProdutos",
        dataType: "html",
        success: function (html) {
            $("#grid").html(html);
        }
    })
}