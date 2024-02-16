using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogicaNegocio.Dinero;

namespace CapaLogicaNegocio.Conversor
{
    public class OpcionConvertir
    {
        public Moneda convertir(Moneda moneda)
        {
            if(moneda.nombre == "Peso" && moneda.conversion == "Dolar")
            {
                
                return Conversor.PesoADolar(moneda);
            }
            else
            if (moneda.nombre == "Peso" && moneda.conversion == "Euro")
            {
                return Conversor.PesoAEuro(moneda);
            }
            else
            if (moneda.nombre == "Dolar" && moneda.conversion == "Peso")
            {
                return Conversor.DolarAPeso(moneda);
            }
            else
            if (moneda.nombre == "Dolar" && moneda.conversion == "Euro")
            {
                return Conversor.DolarAEuro(moneda);
            }
            else
            if (moneda.nombre == "Euro" && moneda.conversion == "Peso")
            {
                return Conversor.EuroAPeso(moneda);
            }
            else
            if (moneda.nombre == "Euro" && moneda.conversion == "Dolar")
            {
                return Conversor.EuroADolar(moneda);
            }
            return moneda;
        }
    }
}