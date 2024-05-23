using System.Drawing;

namespace LibreriaClaseEvaluacion
{
    public class Auto
    {
        private string marca;
        private double cantCombustible;
        private Color color;

        public Auto(string marca, double cantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }

        public Auto(string marca, string cantCombustibleString, Color color)
        {
            this.marca = marca;
            this.cantCombustible = double.Parse(cantCombustibleString);
            this.color = color;
        }

        public string GetMarca() { return marca; }
        public double GetCantCombustible() { return cantCombustible; }
        public Color GetColor() { return color; }

        public string AutoToString()
        {
            return $"Marca = {marca}; \nCantidad de combustible = {cantCombustible} Litros;\n Color = {color.Name};";
        }

        public bool Avanzar(int km)
        {
            double combustibleNecesario = (double)km / 10; // 1 litro por cada 10 km
            if (combustibleNecesario <= cantCombustible)
            {
                cantCombustible -= combustibleNecesario;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Color> ColoresElegidos()
        {
            List<Color> list = new List<Color>() {Color.Blue,Color.Black,Color.White,Color.Yellow,Color.Red,};
            return list;
        }
        public override string ToString()
        {
            return AutoToString();
        }

    }
}
