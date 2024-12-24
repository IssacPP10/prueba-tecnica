using Newtonsoft.Json;

public class FallaConsulta
{
    public int IdFalla { get; set; }

    [JsonProperty("equipoNombre")]
    public string NombreEquipo { get; set; }

    [JsonProperty("descripcionFalla")]
    public string DescripcionFalla { get; set; }

    [JsonProperty("fechaFalla")]
    public DateTime FechaFalla { get; set; }

    [JsonProperty("propietarioNombre")]
    public string NombrePropietario { get; set; }

    [JsonProperty("propietarioEmail")]
    public string Email { get; set; }
}
