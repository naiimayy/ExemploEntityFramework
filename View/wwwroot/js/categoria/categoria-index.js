$(function () {
    $("#categoria-index").DataTable({
        ajax:"https://localhost:5001/categoria/obtertodos?colunaOder=nome&ordem=DESC",
        serverSide: true,
        columns: [
            { data: 'id' },
            { data: 'nome' },
            { data:'id' }
        ]
    })
})