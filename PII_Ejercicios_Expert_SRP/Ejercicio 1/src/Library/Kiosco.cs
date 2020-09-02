using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}


/* 
La clase Kiosco se encarga de calcular el precio del alfajor, cuando en realidad esto podría hacerlo la propia clase "Alfajor",
pues posee toda la información para realizarlo (Expert).
Por otra parte, la clase Kiosco se está encargando de convertir a pesos el dinero del cliente. Se propone la implementación de una 
nueva clase cuya función sea calcular la conversión de moneda.
*/