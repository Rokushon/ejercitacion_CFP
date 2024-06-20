using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTareaVehiculo
{
    public class Moto : Vehiculo
    {
        string tipo;
        int cilindrada;

        public Moto(string marca,string modelo,string tipo, int cilindrada) :base(marca,modelo)
        {
            this.tipo = tipo;
            this.cilindrada = cilindrada;
        }

        public override string Conducir()
        {
            return "Conduciendo una moto";
        }
        public string HacerCaballito()
        {
            return "La moto está haciendo un caballito";
        }
        public override string Mostrarinfo()
        {
            return $"{base.Mostrarinfo()}\nTipo: {tipo}\nCilindrada: {cilindrada}";
        }
    }
}
