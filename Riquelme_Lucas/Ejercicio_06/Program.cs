using Microsoft.Win32;

namespace ejercicio_repaso_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una empresa que se dedica a la comercialización de lamparitas de bajo consumo, registra de sus ventas, los siguientes datos: marca y cantidad.
            //El precio de cada lamparita es de $150(Sin importar la marca).
            //El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
            //A.Si compra 6 lamparitas o más, tiene un descuento del 50 %.
            //B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40 % y si es de otra marca, el descuento es del 30 %.
            //C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25 %, y si es de otra marca el descuento es del 20 %.
            //D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15 %, si es “FelipeLamparas se hace un descuento del 10 % y si es otra marca, 5 %.
            //E.Si el importe final con descuento suma más de $950, se debe agregar el 10 % de ingresos brutos.
            //Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.

            string marca;
            string marcaMinuscula;
            string descuento;
            int cantidadLamparas;
            int totalBruto;
            double total;
            int precio = 150;
            double ingresoBruto = 1.1;

            Console.WriteLine("Que marca de lamparas esta buscando?");
            marca = Console.ReadLine();
            marcaMinuscula = marca.ToLower();
            Console.WriteLine("Cuantas lamparas piensa llevar?");
            cantidadLamparas = int.Parse(Console.ReadLine());

            totalBruto = cantidadLamparas * precio;

            if (cantidadLamparas >= 6)
            {
                total = (precio * cantidadLamparas) * 0.50;
                descuento = "50%";
            }
            else
            {
                if (cantidadLamparas == 5 && marcaMinuscula == "argentinaluz")
                {
                    total = (precio * cantidadLamparas) * 0.60;
                    descuento = "40%";
                }
                else
                {
                    if (cantidadLamparas == 5)
                    {
                        total = (precio * cantidadLamparas) * 0.70;
                        descuento = "30%";
                    }
                    else
                    {
                        if (cantidadLamparas == 4 && (marcaMinuscula == "argentinaluz" || marcaMinuscula == "felipelamparas"))
                        {
                            total = (precio * cantidadLamparas) * 0.75;
                            descuento = "25%";
                        }
                        else
                        {
                            if (cantidadLamparas == 4)
                            {
                                total = (precio * cantidadLamparas) * 0.80;
                                descuento = "20%";
                            }
                            else
                            {
                                if (cantidadLamparas == 3 && marcaMinuscula == "argentinaluz")
                                {
                                    total = (precio * cantidadLamparas) * 0.85;
                                    descuento = "15%";
                                }
                                else
                                {
                                    if (cantidadLamparas == 3 && marcaMinuscula == "felipelamparas")
                                    {
                                        total = (precio * cantidadLamparas) * 0.90;
                                        descuento = "10%";
                                    }
                                    else
                                    {
                                        if (cantidadLamparas == 3)
                                        {
                                            total = (precio * cantidadLamparas) * 0.95;
                                            descuento = "5%";
                                        }
                                        else
                                        {
                                            total = (precio * cantidadLamparas);
                                            descuento = "0%";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("La cantidad de lamparas compradas fue de: " + cantidadLamparas);
            Console.WriteLine("La marca de lamparas comprada fue: " + marca);
            Console.WriteLine("El total sin descuento es de: " + totalBruto + "$");
            Console.WriteLine("El descuento fue de un " + descuento);
            Console.WriteLine("El total con descuento es de: " + total + "$");

            if (total > 950)
            {
                total = total * ingresoBruto;
                Console.WriteLine("Dado que supera los $950, debe abonar ingresos brutos.");
                Console.WriteLine("El total final con ingresos brutos quedaria en: " + total + "$");
            }
        }
    }
}