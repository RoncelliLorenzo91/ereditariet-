using System;

namespace ereditarietà
{



    class Quadrato
    {
        public double lato;
        public Quadrato(double lato)
        {

            this.lato = lato;
        }
        public void CalcolaAreaQuadrato(double lato)
        {
            double area;
            area = lato * lato;
            Console.WriteLine("l'area del quadrato è " + area);
        }

        public void CalcolaPerimetroQuadrato(double lato)
        {
            double perimetroq;
            perimetroq = lato * 4;
            Console.WriteLine("Il perimetro del quadrato è " + perimetroq);
        }
    }
    class Cubo : Quadrato
    {
        public double lato1;
        public Cubo(double lato1) : base(lato1)
        {
            this.lato1 = lato1;
        }
        public void CalcolaVolumeCubo(double lato1)
        {
            double volume;

            volume = lato1 * lato1 * lato1;
            Console.WriteLine("l'area è :" + volume);

        }

        public void CalcolaPerimetroCubo(double lato1)
        {
            double perimetroC;
            perimetroC = lato1 *lato1* 6;
            Console.WriteLine("il perimetro è :" + perimetroC);

        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci il lato del quadrato: ");
            double lato = double.Parse(Console.ReadLine());
            Quadrato quadrato = new Quadrato(lato);
            quadrato.CalcolaAreaQuadrato(lato);
            quadrato.CalcolaPerimetroQuadrato(lato);




            Console.WriteLine("Inserisci il lato del cubo");
            double lato1 = double.Parse(Console.ReadLine());
            Cubo cubo = new Cubo(lato1);
            cubo.CalcolaVolumeCubo(lato1);
            cubo.CalcolaPerimetroCubo(lato1);
            Console.ReadLine();

        }

    }






}
