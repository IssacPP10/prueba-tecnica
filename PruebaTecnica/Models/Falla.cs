using System.ComponentModel.DataAnnotations;

public class Falla
{
    [Required(ErrorMessage = "El nombre del equipo es obligatorio.")]
    public string NombreEquipo { get; set; }

    [Required(ErrorMessage = "La descripción de la falla es obligatoria.")]
    public string DescripcionFalla { get; set; }

    [Required(ErrorMessage = "La fecha de la falla es obligatoria.")]
    [DataType(DataType.Date)]
    public DateTime FechaFalla { get; set; }

    [Required(ErrorMessage = "El nombre del propietario es obligatorio.")]
    public string NombrePropietario { get; set; }

    [Required(ErrorMessage = "El email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El email no es válido.")]
    public string Email { get; set; }
}
