using System;

namespace semana3_estructuras_de_control
{
    class Program
    {
        static void Main(string[] args)
        {

            principal();

        }

        static void principal()
        {
            int repetir_menu;
            System.Console.WriteLine("Estructuras de control en Visual C#");
            System.Console.WriteLine("1. Menú de opciones");
            System.Console.WriteLine("2. Salir");

            System.Console.WriteLine("Ingrese 1 para mostrar menú o 2 para salir. ");
            repetir_menu = Int32.Parse(Console.ReadLine());

            while (repetir_menu == 1)
            {
                opciones();
            }


        }


        static void opciones()
        {

            int opcion;

            System.Console.WriteLine("Ejemplos de estructuras de control");
            System.Console.WriteLine("1- Mostrar los requisitos para instalar versiones de windows");
            System.Console.WriteLine("opcion 2");
            System.Console.WriteLine("opcion 3");
            System.Console.WriteLine("opcion 4");

            System.Console.WriteLine("Ingrese la opción: ");
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    programa1();
                    break;
                case 2:
                    programa2();
                    break;
                case 3:
                    programa3();
                    break;
                case 4:
                    programa4();
                    break;
                default:
                    System.Console.WriteLine("Opción equivocada");
                    break;
            }
            //System.Console.ReadKey();
            principal();

        }

        static void programa1()
        {
            System.Console.WriteLine("Versiones de Windows");
            System.Console.WriteLine("Windows 7");
            System.Console.WriteLine("Procesador de 1 gigahercio ghz " +
                                     "o más rápido de 32 bits x86 o de 64 bits x64" +
                                     "1 GB de RAM 32 bits o 2 GB de RAM x64" +
                                     "16 GB de espacio disponible en el disco duro x32 bits 20 GB x64 bits" +
                                     "Tarjeta gráfica DirectX 9 con controlador WDDM 1.0 o superior.");
            System.Console.WriteLine("Windows 8");
            System.Console.WriteLine("Procesador Intel® Celeron® 847, 1,10 GHz o superior" +
                "Tarjeta gráfica: Dispositivo gráfico Directx 9 con controlador WDDM de 1.0 o mayor." +
                "Procesador de 1GHz o de mayor velocidad" +
                "Tarjeta gráfica: Dispositivo gráfico Directx 9 con controlador WDDM de 1.0 o mayor." +
                "Memoria RAM: 1GB (32 - bit) o 2GB (64 - bit)" +
                "Espacio de disco duro: 16GB (32 bits) o 20GB (64 bits).");
            System.Console.WriteLine("Windows 10");
            System.Console.WriteLine("Procesador a 1 GHz o más rápido o sistema en un chip (SoC)" +
                "1 GB para 32 bits o 2 GB para 64 bits" +
                "16 GB para SO de 32 bits; 32 GB para SO de 64 bits" +
                "DirectX 9 o posterior con controlador WDDM 1.0" +
                "Resolucio 800x600");
            System.Console.WriteLine("Windows 11");
            System.Console.WriteLine("Procesador: 1 giga Hertz (GHz) o más rápido con 2 o más núcleos en un procesador de 64 bits compatible o sistema en un chip (SoC)" +
                "RAM: 4 gigabyte (GB)" +
                "Almacenamiento: Dispositivo de almacenamiento de 64 GB o más" +
                "Tarjeta gráfica: Compatible con DirectX 12 o posterior con controlador WDDM 2.0" +
                "Pantalla: Pantalla de alta definición (720p) de más de 9″ en diagonal, con canal de 8 bits por color");







        }

        static void programa2()
        {
            System.Console.WriteLine("Programa 2");

        }

        static void programa3()
        {
            System.Console.WriteLine("Programa 3");

        }

        static void programa4()
        {
            System.Console.WriteLine("Programa 4");
        }

    }
}