using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

public class FallaController : Controller
{
    private readonly ApiService _apiService;

    public FallaController(ApiService apiService)
    {
        _apiService = apiService;
    }

    public IActionResult Index()
    {
        return View();  // Vista principal con los botones para consultar y registrar
    }

    public async Task<IActionResult> Consultar(string descripcionFalla, DateTime? fechaFalla, string nombrePropietario)
    {
        try
        {
            var fallas = await _apiService.ObtenerRegistrosAsync(descripcionFalla, fechaFalla, nombrePropietario);

            // Verificar si hay resultados
            if (fallas == null || !fallas.Any())
            {
                // Si no hay registros, pasar un mensaje de alerta a la vista
                ViewBag.AlertMessage = "No se encontraron registros que coincidan con los criterios de búsqueda.";
            }

            return View(fallas);
        }
        catch (Exception ex)
        {
            // Manejo de errores
            ViewBag.ErrorMessage = $"Error al obtener los datos: {ex.Message}";
            return View("Error");
        }
    }

    [HttpGet]
    public IActionResult Registrar()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Registrar(Falla falla)
    {
        if (ModelState.IsValid)
        {
            try
            {
                var exito = await _apiService.RegistrarFallaAsync(falla);
                if (exito)
                {
                    TempData["SuccessMessage"] = "Falla registrada exitosamente.";
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Error al registrar la falla.");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error del servidor: {ex.Message}");
            }
        }
        else
        {
            ModelState.AddModelError("", "Por favor, complete todos los campos.");
        }
        return View(falla);
    }
}
