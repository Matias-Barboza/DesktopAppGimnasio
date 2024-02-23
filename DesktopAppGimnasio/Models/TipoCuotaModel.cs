using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesktopAppGimnasio.Models
{
    public class TipoCuotaModel
    {
        // Fields
        private int idTipoCuota;
        private String descripcion;
        private float monto;

        // Properties
        [DisplayName("ID tipo de cuota")]
        [Range(1, 3, ErrorMessage = "El TIPO DE CUOTA elegido no es valido.")]
        public int IdTipoCuota { get => idTipoCuota; set => idTipoCuota = value; }

        [DisplayName("Tipo de cuota")]
        [Required(ErrorMessage = "La DESCRIPCIÓN DEL TIPO DE CUOTA es obligatoria.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\\s]{6,7}$")]
        public string Descripcion { get => descripcion; set => descripcion = value; }

        [DisplayName("Valor Actual")]
        [Range(1, 100000, ErrorMessage = "El MONTO debe ser un número mayor a 0 y no puede contener letras.")]
        public float Monto { get => monto; set => monto = value; }
    }
}
