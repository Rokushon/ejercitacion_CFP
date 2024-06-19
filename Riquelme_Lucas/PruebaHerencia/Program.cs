using LibreriaDeHerencia;


namespace PruebaHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal loro1 = new Loro("Pepe", 500, 30);
            Animal gato1 = new Gato("Silvestre",5000,5,"naranja","Angora");
            Animal perro1 = new Perro("Boby",20000,5,"corto","Pastor aleman","Jorge");

            List<Animal> animales = new List<Animal>();

            animales.Add(loro1);
            animales.Add(perro1);
            animales.Add(gato1);

            foreach (Animal animal in animales) 
            {
                //if(animal is Perro)
                //{
                //    Console.WriteLine(((Perro)animal).EmitirSonido());
                //}
                //if (animal is Loro)
                //{
                //    Console.WriteLine(((Loro)animal).EmitirSonido());
                //}
                //if (animal is Gato)
                //{
                //    Console.WriteLine(((Gato)animal).EmitirSonido());
                //}
                //Console.WriteLine(animal.EmitirSonido());
                //Console.WriteLine($"Tipo de animal: {animal.GetType().Name} - Sonido {animal.EmitirSonido()}");
                Console.WriteLine(animal.MostrarInfo());
            }



        }
    }
}
