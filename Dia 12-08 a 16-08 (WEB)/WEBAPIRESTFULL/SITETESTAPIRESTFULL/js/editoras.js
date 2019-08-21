
	jQuery(document).ready(function()
	{	
		jQuery('#btnCancelar').click(function()
		{			
			$('#Id').val("")
			$('#Nome').val("")
			$('#Descricao').val("")
			$('#Ativo select').val("true")
		})
		
		GetMethod(null)
	})
    
	function GetMethod(object)
	{
		var settings = 
		{
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Editoras",
			"method": "GET",
			"headers": 
			{
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
			+ 		'<th>Nome</th>'
			+ 		'<th>Descrição</th>'
			+ 		'<th>Ativo</th>'
			+ 		'<th>Opções</th>'
			+ 	'</tr>'
			+ '</tbody>'
		)

		$.each(contentValue,function(index,value)
		{
			var row =     '<tr>'
		
				+ '<td>' + value.Id        + '</td>'
				+ '<td>' + value.Nome      + '</td>'
				+ '<td>' + value.Descricao + '</td>'
				+ '<td>' + value.Ativo     + '</td>'
				+ '<td>' 
				+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
				+ 		'<div    class=\'col-md-6\'>'
				+ 			'<button class=\'btn btn-block btn-danger col-md-3 ajax\' type=\'button\'  onclick=\'Deleting('+ value.Id +')\'>Remover</button>'
				+ 		'</div>'
				+ 		'<div     class=\'col-md-6\'>'
				+ 			'<button  class=\'btn btn-block btn-success col-md-3 btn-editing-event\' send-post=\'Editoras\' value=\''+ value.Id +'\' type=\'button\'\>Editar</button>'
				+ 		'</div>'
				+ 	'</div>'
				+ '</td>'
				+ '</tr>'

        	$('#tDataGrid').append(row)
		})

		SetGridClickEvents()
    }
	
	
  
  