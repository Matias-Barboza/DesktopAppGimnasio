using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DesktopAppGimnasio.Models
{
    public class CuotaModel
    {

        //Fields
        private int codigoCuota;
        private int codigoSocio;
        private DateOnly fechaDePago;
        private DateOnly fechaDeVencimiento;
        private String mesQueAbona;
        private float montoAbonado;
        private int codigoTipoCuota;


        [DisplayName("Código de cuota")]
        public int CodigoCuota { get => codigoCuota; set => codigoCuota = value; }

        [DisplayName("Número de socio")]
        public int CodigoSocio { get => codigoSocio; set => codigoSocio = value; }

        [DisplayName("Fecha de pago")]
        [Required(ErrorMessage = "La fecha de pago es obligatoria")]
        public DateOnly FechaDePago { get => fechaDePago; set => fechaDePago = value; }

        [DisplayName("Fecha de vencimiento del pago")]
        public DateOnly FechaDeVencimiento { get => fechaDeVencimiento; set => fechaDeVencimiento = value; }

        [DisplayName("Mes que abona")]
        [Required(ErrorMessage = "El mes que se abona es obligatorio")]
        public String MesQueAbona { get => mesQueAbona; set => mesQueAbona = value; }

        [DisplayName("Monto abonado")]
        [Required(ErrorMessage = "El monto abonado es obligatoria")]
        public float MontoAbonado { get => montoAbonado; set => montoAbonado = value; }

        [DisplayName("Tipo de cuota")]
        [Required(ErrorMessage = "El tipo de cuota a registrar es obligatorio")]
        public int CodigoTipoCuota { get => codigoTipoCuota; set => codigoTipoCuota = value; }
    }
}
