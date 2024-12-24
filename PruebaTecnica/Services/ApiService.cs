using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<FallaConsulta>> ObtenerRegistrosAsync(string descripcionFalla = null, DateTime? fechaFalla = null, string nombrePropietario = null)
    {
        var url = "https://www.apipruebatecnica.somee.com/api/Values/Registros";

        if (descripcionFalla != null || fechaFalla.HasValue || nombrePropietario != null)
        {
            url += "?";
            if (descripcionFalla != null)
                url += $"descripcionFalla={descripcionFalla}&";
            if (fechaFalla.HasValue)
                url += $"fechaFalla={fechaFalla.Value:yyyy-MM-dd}&";
            if (nombrePropietario != null)
                url += $"nombrePropietario={nombrePropietario}";
        }

        try
        {
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<IEnumerable<FallaConsulta>>(response);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al comunicar con la API: {ex.Message}");
        }
    }

    public async Task<bool> RegistrarFallaAsync(Falla falla)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("https://www.apipruebatecnica.somee.com/api/Values/RegistrarFalla", falla);
            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al comunicar con la API: {ex.Message}");
        }
    }
}
