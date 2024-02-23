using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopAppGimnasio.Models
{
    public class CuotaModel
    {
        // Fields
        private int codigoCuota;
        private int codigoSocio;
        private String nombreSocio;
        private String apellidoSocio;
        private String descripcionCuota;
        private DateTime fechaDePago;
        private DateTime fechaDeVencimiento;
        private String mesQueAbona;
        private float montoAbonado;
        private int idTipoCuota;


        [DisplayName("Código de cuota")]
        [Required(ErrorMessage = "El CÓDIGO DE CUOTA es obligatorio para registrar la cuota.")]
        public int CodigoCuota { get => codigoCuota; set => codigoCuota = value; }

        [DisplayName("Número de socio")]
        [Required(ErrorMessage = "El NÚMERO DE SOCIO es obligatorio para registrar la cuota.")]
        [Range(1000, 100000, ErrorMessage = "El NÚMERO DE SOCIO es obligatorio para registrar la cuota y solamente puede contener números.")]
        public int CodigoSocio { get => codigoSocio; set => codigoSocio = value; }

        [DisplayName("Nombre")]
        [NotMapped]
        public string NombreSocio { get => nombreSocio; set => nombreSocio = value; }

        [DisplayName("Apellido")]
        [NotMapped]
        public string ApellidoSocio { get => apellidoSocio; set => apellidoSocio = value; }

        [DisplayName("Tipo de cuota")]
        [NotMapped]
        public string DescripcionCuota { get => descripcionCuota; set => descripcionCuota = value; }

        [DisplayName("Fecha de pago")]
        [Required(ErrorMessage = "El campo FECHA DE PAGO es obligatorio.")]
        public DateTime FechaDePago { get => fechaDePago; set => fechaDePago = value; }

        [DisplayName("Fecha de vencimiento del pago")]
        [Required(ErrorMessage = "El campo FECHA DE VENCIMIENTO DEL PAGO es obligatorio.")]
        public DateTime FechaDeVencimiento { get => fechaDeVencimiento; set => fechaDeVencimiento = value; }

        [DisplayName("Mes que abona")]
        [Required(ErrorMessage = "El campo MES QUE ABONA es obligatorio.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\\s]{1,10}$",
            ErrorMessage = "El campo MES QUE ABONA solo debe contener letras.")]
        public String MesQueAbona { get => mesQueAbona; set => mesQueAbona = value; }

        [DisplayName("Monto abonado ($)")]
        public float MontoAbonado { get => montoAbonado; set => montoAbonado = value; }

        [DisplayName("ID tipo de cuota")]
        [Required(ErrorMessage = "El tipo de cuota a registrar es obligatorio.")]
        [Range(1, 3, ErrorMessage = "El TIPO DE CUOTA elegido no es valido.")]
        public int IdTipoCuota { get => idTipoCuota; set => idTipoCuota = value; }
    }
}
