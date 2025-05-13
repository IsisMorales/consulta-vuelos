
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[Route("api/vuelos")]
public class VuelosController : ControllerBase{

    [HttpGet("ciudades_origen")]
    public IActionResult CiudadOrigen(){
        var client = new MongoClient(CadenaConexion.MONGO_DB);
        var db = client.GetDatabase("Aereopuerto");
        var collection = db.GetCollection<Vuelo>("Vuelos");

        var lista = collection.Distinct<string>("CiudadOrigen",FilterDefinition<Vuelo>.Empty).ToList();
        return Ok(lista);
    }
    
    [HttpGet("ciudades_destino")]
    public IActionResult CiudadDestino(){
        return Ok();
    }

    [HttpGet("estatus")]
    public IActionResult ListarEstatus(){
        return Ok();
    }

    [HttpGet("listar-vuelos")]
    public IActionResult ListarVuelos(){
        return Ok();
    }
}
