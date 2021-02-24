using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Perro : Tamagotchi
    {
        private int cola { get; set; }
        private int Orejas { get; set; }
        private int Hocico { get; set; }
        private int Uñas { get; set; }
        private int Nariz { get; set; }

        public Perro()
        {
            this.Ojos = 2;
            this.Altura = 2.12F;
            this.Peso = 25.5F;
            this.Color = "Marron";
            this.cola = 1;
            this.Orejas = 2;
            this.Hocico = 1;
            this.Uñas = 20;
            this.Nariz = 1;
        }

        public override string Comer()
        {
            return "El perrro come un filete.";
        }
        public override string Crecer()
        {
            return "El cachorro crece a un perro adulto.";
        }
        public override string Respirar()
        {
            return "El perro respira usando sus pulmones.";
        }
        public override string Reproducirse()
        {
            return "El perro se reproduce con mas perros.";
        }
        public override string Moverse()
        {
            return "El perro se mueve con sus 4 patas.";
        }
        public override string Defecar()
        {
            return "El perro hace popo.";
        }

        //Métodos propios
        public string Saltar()
        {
            return "El perro salta en el aire.";
        }
        public string Olfatear()
        {
            return "El perro huele su cola.";
        }
        public string DarLaPata()
        {
            return "El perro te da la pata derecha.";
        }
        public string Aullar()
        {
            return "El perro aulla.";
        }
        public string Excavar()
        {
            return "El perro excava en la tierra.";
        }
        public string Ladrar()
        {
            return "El perro ladra felizmente";
        }

        public override string ToString()
        {
            return "Color:" + Color + " Altura:" + Altura + "m. Peso:" + Peso + "kg. Ojos:" + Ojos + " Cola:" + cola + " Orejas:" + Orejas + " Hocico:" + Hocico + " Uñas:" + Uñas + " Nariz:" + Nariz;
        }
    }
}
