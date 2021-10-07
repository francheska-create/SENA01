
var dataTable;
$ / (document).ready(function () {
    cargarDatatable();
});


function cargarDatatable() {
    
    dataTable = $("#tabla").dataTable({
        "processing": true,
        "serverside": true,
        "pagetlenght": 10,
        "filter": true,
        "reponsivePriority": 1,
        "data": null,
        "ajax": {
            "url": "/programa/json",
            "type": "POST",
             "datatype": "json"


        },

        "columns": [
            { "data": "Progrmaid", "name","Progrmaid","autowhidth":true  },
            { "data": "Nombre", "name": "Nombre", "autowhidth": true    },
            { "data": "Version", "name": "Version", "autowhidth": true},
            { "data": "Codigo", "name": "Codigo", "autowhidth": true},
            {
                "data": "Progrmaid",
                "render": function (data) {
                    return '<div class="text-center">
                        < a href = '/Programa/Edit/${data}'class='btn btn-succes text-white' style ='cursor:pointer;whith:100px;'>
                        <i class='fas fa-edit'></i>Editar
                    </a>
                    &nbsp;

                    < a 'onclik-Delete/Programa/Delete/${data}') class='btn btn-succes text-white' style ='cursor:pointer;whith:100px;'>
                        <i class='fas fa-trash alt'></i>Borrar
                    </a>
                       


                     ';

                
                },

                "widht":"auto"

            }
            
        ],
        "Languaje": {
            "empityTable":"No hay registros"
        },
        "whidth":"100"%
   });






    
       
