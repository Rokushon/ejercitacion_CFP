using LibreriaTareaVehiculo;

namespace ConsolaTareaVehiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear instancia de moto y coche
            //Llamar a los metodos Conducir() y MostrarInfo()
            //Utilizar GetType() y el casteo para llamar a los
            //métodos específicos de las  clases derivadas(AbrirMaletero() y HacerCaballito()).

            Vehiculo moto01 = new Moto("Yamaha","XY-250","Urbana",300);
            Vehiculo coche01 = new Coche("Fiat","Palio",3,13.4);

            Console.WriteLine(moto01.Conducir());
            Console.WriteLine(coche01.Conducir());

            Console.WriteLine($"\n {moto01.Mostrarinfo()}");
            Console.WriteLine("\n" + coche01.Mostrarinfo());

            Console.WriteLine($"\n{coche01.GetType().Name}\n{((Coche)coche01).AbrirMaletero()}");
            Console.WriteLine($"\n{moto01.GetType().Name}\n{((Moto)moto01).HacerCaballito()}");

        }
    }
}
