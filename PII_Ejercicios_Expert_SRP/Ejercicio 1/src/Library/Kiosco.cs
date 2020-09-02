using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertidorAPesos.ConvertirPesos(dinero, moneda);
            return pesos >= a.Total;
        }

    }

    public class ConvertidorAPesos
    {   
        public static double ConvertirPesos(Double dinero, String moneda)
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