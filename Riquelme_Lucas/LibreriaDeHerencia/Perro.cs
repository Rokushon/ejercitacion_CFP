namespace LibreriaDeHerencia
{
    public class Perro : Animal
    {
        string tipoDePelo;
        string raza;
        string dueño;

        public Perro(string nombre, double peso, int edad, string tipoDePelo, string raza, string dueño):base(nombre,peso,edad)
        {
            this.tipoDePelo = tipoDePelo;
            this.raza = raza;
            this.dueño = dueño;
        }
        public override string EmitirSonido()
        {
            return "Guau Guau";
        }
        public override string EjercerAccion()
        {
            return "Ladrar";
        }
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} - Tipo de pelo: {tipoDePelo} - raza: {raza} - dueño: {dueño}";
        }

    }
}
