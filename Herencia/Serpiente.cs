using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Serpiente : Tamagotchi
    {
        private int Cola { get; set;}
        private int Colmillos { get; set;}

        public Serpiente()
        {
            this.Color = "Verde fosfo";
            this.Peso = 12.02F;
            this.Altura = 0.12F;
            this.Ojos = 2;
            this.Cola = 1;
            this.Colmillos = 2;
        }

        public override string Comer()
        {
            return "La serpiente se come una liebre (f).";
        }
        public override string Crecer()
        {
            return "La serpriente aumenta su tamaño.";
        }
        public override string Respirar()
        {
            return "La serpiente respira usando sus pulmones.";
        }
        public override string Reproducirse()
        {
            return "La serpiente se aparea y pone huevos.";
        }
        public override string Defecar()
        {
            return "La serpiente expulsa por la cloaca.";
        }
        public override string Moverse()
        {
            return "La serpiente se arrastra por el suelo.";
        }

        //Métodos propios
        public string Mudar()
        {
            return "La serpiente muda su piel por una nueva.";
        }
        public string Extrangular()
        {
            return "La serpiente extrangula a su vitima (F).";
        }
        public string Cazar()
        {
            return "La serpiente acecha a su presa desde la maleza.";
        }
        public string Morder()
        {
            return "La serpiente muerde usando sus colmillos.";
        }

        public override string ToString()
        {
            return "Color:" + Color + " Altura:" + Altura + "m. Peso:" + Peso + "kg. Ojos:" + Ojos + " Cola:" + Cola + " Colmillos:" + Colmillos;        
        }
    }
}
