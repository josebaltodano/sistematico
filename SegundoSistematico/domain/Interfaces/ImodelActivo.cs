using domain.Activo;
using domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Interfaces
{
    public class ImodelActivo : IModel<ActivoFijo>
    {
        public ActivoFijo[] activoFijo { get; set; }
        public void Add(ActivoFijo t)
        {
            if (activoFijo == null)
            {
                activoFijo = new ActivoFijo[1];
                activoFijo[0] = t;
            }
            else
            {
                ActivoFijo[] temp = new ActivoFijo[activoFijo.Length + 1];
                Array.Copy(activoFijo, temp, activoFijo.Length);
                temp[temp.Length - 1] = t;
                activoFijo = temp;
            }
        }

        public void Create(ActivoFijo t)
        {
            Add(t);
        }

        public ActivoFijo[] FindAll()
        {
            return activoFijo;
        }

       
        public decimal[] SDA(ActivoFijo e)
        {
            int Suma = 0;
            decimal[] depreciacion = new decimal[e.VidaUtil];

            for (int i = 1; i <= e.VidaUtil; i++)
            {
                Suma += i;
            }
            for (int i = 0; i < e.VidaUtil; i++)
            {
                decimal a = (i + 1) * (e.ValorActivo - e.ValorResidual);

                decimal total = a / Suma;

                depreciacion[i] = total;
            }
            return depreciacion;
        }
        public decimal[] linearecta(ActivoFijo e)
        {
            decimal[] LineaRecta = new decimal[e.VidaUtil];
            for (int i = 0; i < e.VidaUtil; i++)
            {
                decimal a = (e.ValorActivo - e.ValorResidual) / e.VidaUtil;
                LineaRecta[i] = a;
            }
            return LineaRecta;
        }

        public int VidaUtil(EnumsActivo e)
        {

            int i = 0;
            if (e == Enums.EnumsActivo.Edificio)
            {
                i = 20;

            }
            else if (e == EnumsActivo.Vehiculo)
            {
                i = 5;
            }
            else if (e == EnumsActivo.Maquinaria)
            {
                i = 3;

            }
            else if (e == EnumsActivo.Mobiliaria)
            {
                i = 2;
            }
            else if (e == EnumsActivo.EquipoComputo)
            {
                i = 1;
            }
            return i;
        }
    }
}
