jQuery(document).ready(function()
{		
    jQuery('#btnCancelar').click(function()
    {        
        $('#Id').val("")
        $('#Livro').val("")
        $('#Usuario').val("")
        $('#Tipo').val("")
        $('#Devolucao').val("")
        $('#Ativo select').val("true")
    })
    
    GetMethod(null)		//null pq não está usando nada

})

function GetMethod(object)                                  //object pq está chamando um parametro, dai o null nos outros
{			
    var settings = 
    {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:59271/Api/Locacao",
        "method": "GET",
        "headers": {
            "Content-Type": "application/json",
            "Accept": "*/*"
          }
    }

    $.ajax(settings).done(function (response) 
    {
      RefrestGrid(response)
    })
    
    return false
}

function RefrestGrid(contentValue)
{
   $('#tDataGrid').empty()
   $('#tDataGrid').html
   (  '<tbody>'
        + 	'<tr>'
        + 		'<th>ID</th>'
        + 		'<th>Livro</th>'
        + 		'<th>Usuario</th>'
        + 		'<th>Tipo</th>'
        + 		'<th>Devolucao</th>'
        + 		'<th>Ativo</th>'
        + 		'<th>Opções</th>'
        + 	'</tr>'
        + '</tbody>'
    )

    $.each(contentValue,function(index,value) 
    {
        var row =     '<tr>'
        + '<td>' + value.Id        + '</td>'
        + '<td>' + value.Livro     + '</td>'
        + '<td>' + value.Usuario   + '</td>'
        + '<td>' + value.Tipo      + '</td>'
        + '<td>' + value.Devolucao + '</td>'
        + '<td>' + value.Ativo     + '</td>'
        + '<td>' 
        + 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
        + 		'<div    class=\'col-md-6\'>'
        + 			'<button class=\'btn btn-block btn-danger col-md-3 btn-delet-event\' type=\'button\' send-post=\'Usuarios\' value=\''+ value.Id +'\'>Remover</button>'
        + 		'</div>'
        + 		'<div     class=\'col-md-6\'>'
        + 			'<button  class=\'btn btn-block btn-success col-md-3 btn-editing-event\' send-post=\'Locacao\' value=\''+ value.Id +'\' type=\'button\'\>Editar</button>'
        + 		'</div>'
        + 	'</div>'
        + '</td>'
        + '</tr>'
        
        $('#tDataGrid').append(row)
    })

    SetGridClickEvents()
}