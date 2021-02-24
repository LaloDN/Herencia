using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Salmon : Tamagotchi
    {
        private int Branqueas;
        private int Cola;
        private int Escamas;
        private int Aletas;

        public Salmon()
        {
            this.Color = "Salmon";
            this.Peso = 0.12F;
            this.Altura = 0.09F;
            this.Ojos = 2;
            this.Branqueas = 6;
            this.Cola = 2;
            this.Escamas = 50;
            this.Aletas = 2;
        }

        public override string Comer()
        {
            return "El salmón se alimenta de arenque.";
        }
        public override string Crecer()
        {
            return "El salmón esta creciendo.";
        }
        public override string Respirar()
        {
            return "El salmón respira por sus branqueas.";
        }
        public override string Reproducirse()
        {
            return "El salmón pone sus huevos en el agua dulce.";
        }
        public override string Defecar()
        {
            return "El salmón deja sus heces en el océano.";
        }
        public override string Moverse()
        {
            return "El salmón nada corriente río arriba.";
        }

        //Métodos propios
        public string Adaptarse()
        {
            return "El salmón se adapta a la corriente del río.";
        }
        public string Saltar()
        {
            return "El salmón salta sobre la cascada.";
        }

        public override string ToString()
        {
            return "Color:" + Color + " Altura:" + Altura + "m. Peso:" + Peso + "kg. Ojos:" + Ojos + " Branqueas:" + Branqueas + " Cola:" + Cola + " Escamas:" + Escamas + " Aletas:" + Aletas;    
        }
    }
}
