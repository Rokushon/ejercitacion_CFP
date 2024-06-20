using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTareaVehiculo
{
    public class Coche : Vehiculo
    {
        int numeroPuertas;
        double capacidadMaletero;

        public Coche(string marca,string modelo,int numeroPuertas, double capacidadMaletero):base(marca,modelo)
        {
            this.numeroPuertas = numeroPuertas;
            this.capacidadMaletero = capacidadMaletero;
        }

        public override string Conducir()
        {
            return "Conduciendo un coche";
        }
        public string AbrirMaletero()
        {
            return "El maletero del coche se ha abierto";
        }
        public override string Mostrarinfo()
        {
            return $"{base.Mostrarinfo()}\nNumero de puertas: {numeroPuertas}\nCapacidad del maletero: {capacidadMaletero}";
        }
    }
}
