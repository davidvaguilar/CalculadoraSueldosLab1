using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSueldosLab1
{
    internal class JefeDeTienda
    {
        public string Nombre { get; set; }
        public double ValorNormal;
        public double ValorExtra;

        public double TotalNormal { get; set; }
        public double TotalExtra { get; set; }
        public double Sueldo { get; set; }

        public JefeDeTienda()
        {
            this.ValorNormal = 2000;
            this.ValorExtra = 3000;
        }

        public void CalcularSueldo(int horasTrabajadas) 
        {
            
            if ( horasTrabajadas <= 40 )
            {
                // Calcular Sueldo Hora Normal
                this.TotalNormal = horasTrabajadas * this.ValorNormal;
                this.TotalExtra = 0;
                this.Sueldo = horasTrabajadas * this.ValorNormal;
            }
            else
            {
                // Calcular Sueldo Hora Normal mas Horas Extra
                TotalNormal = 40 * this.ValorNormal;
                TotalExtra = ( horasTrabajadas - 40 ) * this.ValorExtra;
                this.Sueldo = this.TotalNormal + this.TotalExtra;                 
            }
        }


    }
}
