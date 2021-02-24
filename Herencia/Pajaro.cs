using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Pajaro : Tamagotchi
    {
        private int Pico;
        private int Plumas;
        private int Alas;

        public Pajaro()
        {
            this.Color = "Cian";
            this.Peso = 0.1F;
            this.Altura = 0.15F;
            this.Ojos = 2;
            this.Pico = 1;
            this.Plumas = 900;
            this.Alas = 2;
        }

        public override string Comer()
        {
            return "El pájaro se alimenta de gusanos.";
        }
        public override string Crecer()
        {
            return "El pichón se convierte en un pájaro.";
        }
        public override string Respirar()
        {
            return "El pájaro respira usando sus pulmones.";
        }
        public override string Reproducirse()
        {
            return "El pájaro pone huevos.";
        }
        public override string Defecar()
        {
            return "El pájaro hace sus necesidades sobre el parabrisas del auto.";
        }
        public override string Moverse()
        {
            return "El pájaro vuela libremente.";
        }

        //Métodos propios
        public string Cazar()
        {
            return "El pájaro caza gusanos.";
        }
        public string HacerNido()
        {
            return "El pájaro hace su nido en el árbol.";
        }
        public string Empollar()
        {
            return "El pájaro empolla sus huevos.";
        }
        public string Cantar()
        {
            return "El pájaro canta por la mañana.";
        }

        public override string ToString()
        {
            return "Color:" + Color + " Altura:" + Altura + "m. Peso:" + Peso + "kg. Ojos:" + Ojos + " Pico:" + Pico + " Plumas:" + Plumas + " Alas:" + Alas;
        }
    }
}
