﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DesktopAppGimnasio.Models
{
    public class SocioModel
    {
        //Fields
        private int codigoSocio;
        private String dni;
        private String nombreYApellido;
        private bool estaActivo;

        //Properties
        [DisplayName("Número de socio")]
        public int CodigoSocio { get => codigoSocio; set => codigoSocio = value; }

        [DisplayName("DNI")]
        [RegularExpression(@"^[0-9]{6,8}$",
            ErrorMessage = "El DNI debe tener entre seis y ocho caracteres, y estos deben ser numéricos")]
        [StringLength(8)]
        public String DNI { get => dni; set => dni = value; }

        [DisplayName("Nombre y apellido")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\s]{1,100}$")]
        [Required(ErrorMessage = "El nombre y apellido del socio es requerido")]
        [StringLength(100)]
        public string NombreYApellido { get => nombreYApellido; set => nombreYApellido = value; }

        [DisplayName("Estado")]
        [Required]
        public bool EstaActivo { get => estaActivo; set => estaActivo = value; }
    }
}
