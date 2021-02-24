using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Gato : Tamagotchi
    {
        private int Garras;
        private int Cola;
        private int Bigotes;
        private int Orejas;

        public Gato()
        {
            this.Color = "Naranja";
            this.Peso = 15.2F;
            this.Altura = 0.22F;
            this.Ojos = 2;
            this.Garras = 4;
            this.Cola = 1;
            this.Bigotes = 9;
            this.Orejas = 2;
        }

        public override string Comer()
        {
            return "El gato come atún sabor a elote.";
        }
        public override string Crecer()
        {
            return "El minino crece como un gran felino.";
        }
        public override string Respirar()
        {
            return "El gato respira usando sus pulmones.";
        }
        public override string Reproducirse()
        {
            return "El gato se reproduce con otros gatos.";
        }
        public override string Defecar()
        {
            return "El gato hace del baño en su caja de arena.";
        }
        public override string Moverse()
        {
            return "El gato se mueve sobre el árbol.";
        }

        //Métodos propios
        public string Maullar()
        {
            return "El gato maulla por la noche noche.";
        }
        public string Cazar()
        {
            return "El gato ha casado un ratón.";
        }
        public string CaerDePie()
        {
            return "El gato ha caido parado en sus 4 patas.";
        }
        public string Rasguñar()
        {
            return "El gato rasguña a su dueñ@.";
        }
        public string Lamer()
        {
            return "El gato lame a su dueñ@.";
        }

        public override string ToString()
        {
            return "Color:" + Color + " Altura:" + Altura + "m. Peso:" + Peso + "kg. Ojos:" + Ojos + " Garras:" + Garras + " Cola:" + Cola + " Bigotes:" + Bigotes + " Orejas:" + Orejas;
        }
    }
}
