var generoList
var editoraList

jQuery(document).ready(function()
{
	//PUXANDO GENEROS
	var settings = 
	{
		"async": true,
		"crossDomain": true,
		"url": "http://localhost:59271/Api/Generos",
		"method": "GET",
		"headers": 
		{
			"Content-Type": "application/json",
			"Accept": "*/*"
		}
	}
	
	$.ajax(settings).done(function (response) 
	{
		generoList = response

	  	$.each(response,function(index,value)
	  	{
			$('#Genero')[0].innerHTML += '<option value=\''+ value.Id +'\'>'+ value.Tipo +'</option>'
	  	})
	})

	//PUXANDO EDITORAS
	settings = 
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
		editorasList = response

	  $.each(response,function(index,value)
	  {
		  $('#Editora')[0].innerHTML += '<option value=\''+ value.Id +'\'>'+ value.Nome +'</option>'
	  })
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
	  RefrestGrid(response);
	})
	
	return false
}

function translateField(filedValue,listTranslate,toValue)
{
	var retorno

	$.each(listTranslate,function(index,value)
	{
        if(value.Id == filedValue)
		retorno = value[toValue];
	})

	return retorno
}


function RefrestGrid(contentValue)
	{
	   $('#tDataGrid').empty()
	   $('#tDataGrid').html
	   (  '<tbody>'
			+ 	'<tr>'
			+ 		'<th>ID</th>'
			+ 		'<th>Título</th>'
			+ 		'<th>Gênero</th>'
			+ 		'<th>Editora</th>'
			+ 		'<th>Observações</th>'
			+ 		'<th>Opções</th>'
			+ 	'</tr>'
			+ '</tbody>'
		)

		$.each(contentValue,function(index,value)
		{
			var row =     '<tr>'
		
				+ '<td>' + value.Id        + '</td>'
				+ '<td>' + value.Titulo      + '</td>'
				+ '<td>' + translateField(value.Genero,generoList,'Tipo') + '</td>'
				+ '<td>' + translateField(value.Editora,editoraList,'Nome') + '</td>'
				+ '<td>' + value.Observacoes + '</td>'
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

