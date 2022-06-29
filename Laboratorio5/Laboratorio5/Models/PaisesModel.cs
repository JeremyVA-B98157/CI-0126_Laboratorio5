using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio5.Models
{
    public class PaisesModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage= "Debe proporcionar un nombre")]
        [DisplayName("Nombre del país:")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un continente")]
        [DisplayName("Nombre del continente:")]
        public string Continente { get; set; }
        [Required(ErrorMessage = "Debe ingresar el idioma")]
        [DisplayName("Idioma:")]
        [RegularExpression("^[a-zA-ZÀ-ÿ\u00f1\u00d1]+$", ErrorMessage = "No puede ingresar números")]
        public string Idioma { get; set; }

    }
}
