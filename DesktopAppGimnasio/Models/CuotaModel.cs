using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MySql.Data.MySqlClient;

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
        public int CodigoCuota { get => codigoCuota; set => codigoCuota = value; }

        [DisplayName("Número de socio")]
        [Required(ErrorMessage = "El NÚMERO DE SOCIO es obligatorio para registrar la cuota.")]
        public int CodigoSocio { get => codigoSocio; set => codigoSocio = value; }

        [DisplayName("Nombre")]
        public string NombreSocio { get => nombreSocio; set => nombreSocio = value; }

        [DisplayName("Apellido")]
        public string ApellidoSocio { get => apellidoSocio; set => apellidoSocio = value; }

        [DisplayName("Tipo de cuota")]
        public string DescripcionCuota { get => descripcionCuota; set => descripcionCuota = value; }

        [DisplayName("Fecha de pago")]
        [Required(ErrorMessage = "La fecha de pago es obligatoria")]
        public DateTime FechaDePago { get => fechaDePago; set => fechaDePago = value; }

        [DisplayName("Fecha de vencimiento del pago")]
        public DateTime FechaDeVencimiento { get => fechaDeVencimiento; set => fechaDeVencimiento = value; }

        [DisplayName("Mes que abona")]
        [Required(ErrorMessage = "El campo MES QUE ABONA es obligatorio.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\\s]{1,10}$",
            ErrorMessage = "El campo MES QUE ABONA solo debe contener letras.")]
        public String MesQueAbona { get => mesQueAbona; set => mesQueAbona = value; }

        [DisplayName("Monto abonado ($)")]
        [Required(ErrorMessage = "El  campo MONTO ABONADO es obligatorio.")]
        [RegularExpression(@"^\d{1,8}(\.\d{1,2})?$",
            ErrorMessage = "El campo MONTO unicamente debe contener números.")]
        public float MontoAbonado { get => montoAbonado; set => montoAbonado = value; }

        [DisplayName("ID tipo de cuota")]
        [Required(ErrorMessage = "El tipo de cuota a registrar es obligatorio.")]
        public int IdTipoCuota { get => idTipoCuota; set => idTipoCuota = value; }
    }
}
