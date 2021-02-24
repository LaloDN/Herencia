using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciación de los objetos
            Tamagotchi p = new Perro();
            Tamagotchi g = new Gato();
            Tamagotchi s = new Serpiente();
            Tamagotchi t = new Tiburon();
            Tamagotchi sa = new Salmon();
            Tamagotchi pa = new Pajaro(); 

            //Comparación de ciertos métodos

            Console.WriteLine(p.Crecer());
            Console.WriteLine(pa.Crecer());
            Console.WriteLine(s.Crecer());
            Console.WriteLine();
            Console.WriteLine(t.Defecar());
            Console.WriteLine(sa.Defecar());
            Console.WriteLine(s.Defecar());
            Console.WriteLine();
            Console.WriteLine(g.Comer());
            Console.WriteLine(s.Comer());
            Console.WriteLine(p.Comer());

            //Llamada a algunos métodos propios de los objetos, estos métodos necesitan ser ejecutados por las clases hijo
            /*
            Perro p1 = new Perro();
            Gato g1 = new Gato();
            Serpiente s1 = new Serpiente();
            Tiburon t1 = new Tiburon();
            Salmon sa1 = new Salmon();
            Pajaro pa1 = new Pajaro();

            Console.WriteLine();
            Console.WriteLine(p1.DarLaPata());
            Console.WriteLine(g1.Rasguñar());
            Console.WriteLine(s1.Cazar());
            Console.WriteLine(t1.Cazar());
            Console.WriteLine(sa1.Saltar());
            Console.WriteLine(pa1.Empollar());
            */

            //Características de cada uno de los objetos creados.
            /*
            Console.WriteLine("Características del tamagotchi p:");
            Console.WriteLine(p.ToString());
            Console.WriteLine("\nCaracterísticas del tamagotchi g:");
            Console.WriteLine(g.ToString());
            Console.WriteLine("\nCaracterísticas del tamagotchi s:");
            Console.WriteLine(s.ToString());
            Console.WriteLine("\nCaracterísticas del tamagotchi sa:");
            Console.WriteLine(sa.ToString());
            Console.WriteLine("\nCaracterísticas del tamagotchi pa:");
            Console.WriteLine(pa.ToString());
            Console.WriteLine("\nCaracterísticas del tamagotchi t:");
            Console.WriteLine(t.ToString());
            */

            //Obtención de el tipo de cada objeto
            /*
            Console.WriteLine("¿Qué tipo de animal es el tamaogtchi s?");
            Console.WriteLine(s.GetType());
            Console.WriteLine("¿Qué tipo de animal es el tamagotchi g?");
            Console.WriteLine(g.GetType());
            Console.WriteLine("¿Qué tipo de animal es el tamagotchi sa?");
            Console.WriteLine(sa.GetType());
            */

            Console.WriteLine("\nPresione una tecla para salir del aplicación");
            Console.ReadKey();

        }
    }
}
