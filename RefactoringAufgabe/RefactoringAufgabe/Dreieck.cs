using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringAufgabe
{
    internal class Dreieck
    {
        private double seitenlaenge1;
        private double seitenlaenge2;
        private double seitenlaenge3;
        private double winkel1;
        private double winkel2;

        public Dreieck(double seitenlaenge1, double seitenlaenge2, double seitenlaenge3)
        {
            this.seitenlaenge1 = seitenlaenge1;
            this.seitenlaenge2 = seitenlaenge2;
            this.seitenlaenge3 = seitenlaenge3;
        }

        public double Fläche
        {
            get
            {
                double temp = (seitenlaenge1 + seitenlaenge2 + seitenlaenge3) / 2;
                return Math.Sqrt(temp * (temp - seitenlaenge1) * (temp - seitenlaenge2) * (temp - seitenlaenge3));
            }
        }

        public double Seitenlaenge1
        {
            get => seitenlaenge1;
        }

        public double Seitenlaenge2
        {
            get => seitenlaenge3;
        }

        public double Seitenlaenge3
        {
            get => seitenlaenge3;
        }
        public double Seitenlänge2
        {
            get => seitenlaenge2;
        }

    }
}
