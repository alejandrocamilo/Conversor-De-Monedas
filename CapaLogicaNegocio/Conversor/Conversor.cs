using CapaLogicaNegocio.Dinero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Conversor
{
    public static class Conversor
    {
        public static Moneda PesoADolar(Moneda moneda)
        {
            double pesos = moneda.cantidad;
            double dolares = pesos * 0.018;

            moneda.nombre = "Dolar";
            moneda.cantidad = dolares;

            return moneda;
        }

        public static Moneda PesoAEuro(Moneda moneda)
        {
            double pesos = moneda.cantidad;
            double euros = pesos * 0.016;

            moneda.nombre = "Euro";
            moneda.cantidad = euros;

            return moneda;
        }



        public static Moneda DolarAPeso(Moneda moneda)
        {
            double dolares = moneda.cantidad;
            double pesos = dolares * 56.40;

            moneda.nombre = "Peso";
            moneda.cantidad = pesos;

            return moneda;
        }

        public static Moneda DolarAEuro(Moneda moneda)
        {
            double dolares = moneda.cantidad;
            double euros = dolares * 0.93;

            moneda.nombre = "Euro";
            moneda.cantidad = euros;

            return moneda;
        }



        public static Moneda EuroAPeso(Moneda moneda)
        {
            double euros = moneda.cantidad;
            double pesos = euros * 60.92;

            moneda.nombre = "Peso";
            moneda.cantidad = pesos;

            return moneda;
        }

        public static Moneda EuroADolar(Moneda moneda)
        {
            double euros = moneda.cantidad;
            double dolares = euros * 1.08;

            moneda.nombre = "Dolar";
            moneda.cantidad = dolares;

            return moneda;
        }
    }
}
