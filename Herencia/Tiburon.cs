using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Tiburon : Tamagotchi
    {
        private int Colmillos;
        private int Branqueas;
        private int Aletas;

        public Tiburon()
        {
            this.Color = "Celeste";
            this.Peso = 292.38F;
            this.Altura = 2.2F;
            this.Ojos = 2;
            this.Colmillos = 500;
            this.Branqueas = 12;
            this.Aletas = 2;
        }

        public override string Comer()
        {
            return "El tiburón se alimenta de otros peces.";
        }
        public override string Crecer()
        {
            return "El tiburoncín crece en un tiburón muy grande.";
        }
        public override string Respirar()
        {
            return "El tiburón respira usando sus branqueas.";
        }
        public override string Reproducirse()
        {
            return "El tiburón se reproduce con otros tiburones.";
        }
        public override string Defecar()
        {
            return "El tiburón deja sus heces en el océano.";
        }
        public override string Moverse()
        {
            return "El tiburón nada por el mar.";
        }

        //Métodos propios
        public string Morder()
        {
            return "El tiburón muerde con su mandíbula.";
        }
        public string Olfatear()
        {
            return "El tiburón olfatea a otros organismos por su sangre.";
        }
        public string Cazar()
        {
            return "El tiburón caza a sus presas salvajemente.";
        }

        public override string ToString()
        {
            return "Color:" + Color + " Altura:" + Altura + "m. Peso:" + Peso + "kg. Ojos:" + Ojos + " Colmillos:" + Colmillos + " Branqueas:" + Branqueas + " Aletas:" + Aletas;
        }
    }

}
