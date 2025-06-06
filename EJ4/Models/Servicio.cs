using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EJ4.Models
{
    internal class Servicio
    {
        public int contador = 0;
        public double[] valores = new double[100];
        public void Ordenar()
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        Inicial();
                    }
                }
            }
        }
        void Inicial()
        {
            double aux = valores[i];
            valores[i] = valores[j];
            valores[j] = aux;
        }
        public double Promedio()
        {
            double acumulador = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }
            double promedio = acumulador / contador;
            return promedio;
        }
        public void RegistrarValores(double valor)
        {
            valores[contador] = Convert.ToDouble(valor);
            contador++;
        }
    }
}
