using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Lapicera
    {
        Color color;
        int precio;
        string marca;
        int nivelDeTinta;

        public Color Color { get => color;}
        public int Precio { get => precio;}
        public string Marca { get => marca;}
        public int NivelDeTinta { get => nivelDeTinta;}
        public Lapicera()
        {
            nivelDeTinta = 100;
        }
        public Lapicera(Color color, int precio, string marca):this()
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
        }
        public bool Escribir(int cantLetras)
        {
            bool bandera = false;
            if(cantLetras < NivelDeTinta)
            {
                nivelDeTinta -= cantLetras;
                bandera = true;
            }
            return bandera;
        }
        public void Recargar()
        {
            nivelDeTinta = 100;
        }
        public override string ToString()
        {
            string mensaje = $"Color:{color.Name} - Precio:{Precio} - Marca:{Marca} - Nivel de tinta:{NivelDeTinta}";
            return mensaje;
        }
    }
}
