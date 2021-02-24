using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     public abstract class Tamagotchi
    {
        //Estos serán los atributos de todos los animales, todos estos atributos son heredados para cada una de las clases hijo.
        protected string Color { get; set; }
        protected float Peso { get; set; }
        protected float Altura { get; set; }
        protected int Ojos { get; set; }

        //También, todos los animales contendran estos métodos que luego serán implementados.
        public abstract string Comer();
        public abstract string Crecer();
        public abstract string Respirar();
        public abstract string Reproducirse();
        public abstract string Defecar();
        public abstract string Moverse();

    }
}
