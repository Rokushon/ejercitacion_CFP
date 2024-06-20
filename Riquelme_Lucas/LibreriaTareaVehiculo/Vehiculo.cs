namespace LibreriaTareaVehiculo
{
    public abstract class Vehiculo
    {
        protected string marca;
        protected string modelo;

        protected Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public abstract string Conducir();
        public virtual string Mostrarinfo()
        {
            return $"Marca: {marca}\nModelo: {modelo}";
        }
    }
}
