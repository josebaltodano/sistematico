using domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Activo
{
    public  class ActivoFijo
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }

        public decimal ValorActivo { get; set; }

        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaDeAdquisicion { get; set; }

        public EnumsActivo TipoActivo { get; set; }
        public Depreciacion depreciacion { get; set; }

    }
}
