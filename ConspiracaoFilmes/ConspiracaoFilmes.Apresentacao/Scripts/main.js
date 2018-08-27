
function openModal(url) {
    $.get(url, null, function (data) {
        $('#myModal').empty().html(data);
        $('#myModal').modal('toggle');
    }, 'html').done(function () {
        //sys.concluido();
    });
}