var dataTable;

$(document).ready(function () {
    
    cargarDatatable();

});

function cargarDatatable() {
    dataTable = $("#tablita").DataTable({
        "ajax": {
            "url": "/Programa/loadDatatable",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "programaId", "name": "programaId", "autowhidth" :true },
            { "data": "nombre", "name": "nombre", "autowhidth": true },
            { "data": "version", "name": "version", "auntowhidth": true },
            { "data": "codigo", "name": "codigo","autowhidth":true },
            {
                "data": "programaId",
                "render": function (data) {
                    return `<div class="text-center">
                    <a href = /Programa/Edit/${data} class='btn btn-success text-white' style ='cursor:pointer;whidth:100px;'>
                        <i class='fas fa-edit'></i>&nbsp;Editar
                    </a>
                    &nbsp;

                    <a onclick="Delete('/Programa/Delete/${data}')" class='btn btn-danger text-white' style ='cursor:pointer;whidth:100px;'>
                        <i class='fas fa-trash alt'></i>&nbsp;Borrar
                     </a>
                       </div>
                     `;

                },
                "width": "30%"


            }

        ],
        "languaje": {
            "emptyTable": "No hay registro"
        },

        "width": "100%"
    });
}

function Delete(url) {
    Swal.fire({

        title: "¿Esta seguro de borrar?",
        text: "¡Este contenido no se puede recuperar!",
        type: "warning",
        showCancelButton: true,
        confirmButtonControl: "#DD6B55",
        confirmButtonText: "¡Si  borrar!",
        closeOconfirm: true

    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: 'DELETE',
                url: url,
                datatype: "JSON",
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        let notifier = new AWN(globalOptions);
                        notifier.success(data.message);
                        
                    }
                    else {
                        toastr.error(data.message);

                    }
                }

            });


        }
        

    });
        
}