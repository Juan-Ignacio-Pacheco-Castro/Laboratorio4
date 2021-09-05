﻿using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Laboratorio4.Models
{
    public class PlanetaModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Es necesario que le indique el nombre del planeta")]
        [Display(Name = "Ingrese el nombre del planeta")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Es necesario que indique el tipo de planeta")]
        [Display(Name = "Seleccione el tipo de planeta")]
        public string tipo { get; set; }

        [Required(ErrorMessage = "Es necesario que ingrese el número de anillos")]
        [Display(Name = "Ingrese el número de anillos del planeta")]
        [RegularExpression("^[0-9]*$", ErrorMessage ="Debe ingresar números")]
        public int numeroAnillos { get; set; }

        [Required(ErrorMessage = "Debe agregar un archivo (imagen, pdf, etc...)")]
        [Display(Name = "Ingrese el archivo con los detalles del planeta")]
        public HttpPostedFileBase archivo { get; set; }

        public string tipoArchivo { get; set; }
    }
}