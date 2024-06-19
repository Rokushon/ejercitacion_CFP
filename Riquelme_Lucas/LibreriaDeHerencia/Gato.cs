using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public class Gato : Animal
    {
        string colorDePelo;
        string raza;

        public Gato(string nombre, double peso, int edad, string colorDePelo, string raza) : base(nombre,peso,edad)
        {
            this.colorDePelo = colorDePelo;
            this.raza = raza;
        }
        public override string EmitirSonido()
        {
            return "Miau Miau";
        }
        public override string EjercerAccion()
        {
            return "Rasguñar";
        }
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} - Color de pelo: {colorDePelo} - raza: {raza}";
        }

    }
}
