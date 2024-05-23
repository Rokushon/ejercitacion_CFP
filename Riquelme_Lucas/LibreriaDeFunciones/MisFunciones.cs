

namespace LibreriaDeFunciones
{
    public static class MisFunciones
    {
        //aca adentro van las funciones
        //static void no devuelve nada ni recibe nada (creo)
        //funcion = public + static + tipo de dato que devuelve + nombre + (dato + nombre; dato + nombre)
        //en el archivo que quiero usar funciones, arriba de todo poner using LibreriaDeFunciones;
        //en el archivo que quiero usar estas funciones, click derecho en el nombre, agregar, referencia del proyecto, este archivo
        //en el archivo donde se usan las funciones, se llama al metodo como MisFunciones.nombredelafuncion
        public static bool IsEmpty(string word) 
        {
            bool result = false;
            if (word == "")
            {
                result = true;
            }
            return result; 
        }
        public static bool IsString(string word)
        {
            bool result = false;
            if (word.Any(char.IsDigit))
            {
                result = true;
            }
            return result;
        }
        public static bool IsNumber(string word)
        {
            bool result = true;
            if (word.All(char.IsDigit))
            {
                result = false;
            }
            return result;
        }

    }
}
