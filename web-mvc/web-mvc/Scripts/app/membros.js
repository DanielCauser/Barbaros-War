$(function () {
    GridMembros();
});


function GridMembros() {
    $.ajax({
        dataType: 'json',
        url: "/Membros/Index",
        type: "GET",
        success: function (data) {
            CarregarInformacoesBootstrapTable(data);
        }
    });
};


function CarregarInformacoesBootstrapTable(lista) {
    var json = jQuery.parseJSON(lista);
    $('#membros-table').bootstrapTable({
        data: json.items,
    });
};

function imageFormatter(value, row) {
    return '<img src="' + value + '" />';
}