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
        // Fields
        private int codigoSocio;
        private String dni;
        private String nombre;
        private String apellido;
        private bool estaActivo;

        // Properties
        [DisplayName("Número de socio")]
        public int CodigoSocio { get => codigoSocio; set => codigoSocio = value; }

        [DisplayName("DNI")]
        [RegularExpression(@"^[0-9]{6,8}$",
            ErrorMessage = "El DNI debe tener entre seis y ocho caracteres, y estos deben ser numéricos")]
        [StringLength(8)]
        public String DNI { get => dni; set => dni = value; }

        [DisplayName("Nombre")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\s]{1,100}$")]
        [Required(ErrorMessage = "El nombre del socio es requerido")]
        [StringLength(100)]
        public string Nombre { get => nombre; set => nombre = value; }

        [DisplayName("Apellido")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\s]{1,100}$")]
        [Required(ErrorMessage = "El apellido del socio es requerido")]
        [StringLength(100)]
        public string Apellido { get => apellido; set => apellido = value; }

        [DisplayName("Estado de actividad")]
        [Required]
        public bool EstaActivo { get => estaActivo; set => estaActivo = value; }
    }
}
