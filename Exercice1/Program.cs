using System;

namespace Exercice1 // Note: actual namespace depends on the project name.

    // class mére
{   abstract class vehicule
    {
        private static int matricule=0;
        private int _annee;
        private float _prix;
       
        public int Annee
        {
            get => _annee;
            set => _annee = value;
        }
        public float Prix
        {
            get => _prix;
            set => _prix = value;
        }
        public vehicule(int annee, float prix )
        {
            matricule++;
            Annee = annee;
            Prix = prix;
        }
        public abstract void accelerer();

        public abstract void demarrer();

        public void Tostring()
        {
            Console.WriteLine("Cette véhicule à pour matricule: " + matricule + ", pour l'année: " + this.Annee + " et de prix: " + this.Prix);
        }
       
    }
    class voiture : vehicule
    {
        public voiture(int annee,float prix) : base( annee, prix)
        {

        }
        public override void accelerer()
        {
            Console.WriteLine("la voirure  peut bien accélérer");
        }
        public override void demarrer()
        {
            Console.WriteLine("la voirure:  démarre vite");
        }
    }

    class camion : vehicule
    {
        public camion( int annee, float prix) : base(annee, prix)
        {

        }
        public override void accelerer()
        {
            Console.WriteLine("le camion  ne peut pas bien accélérer");
        }
        public override void demarrer()
        {
            Console.WriteLine("le camion:  démarre longtement");
        }
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            vehicule v = new voiture( 1998, 34560);
            v.demarrer();
            v.accelerer();
            v.Tostring();
            vehicule c = new camion( 2000, 88900);
            c.demarrer();
            c.accelerer();
            c.Tostring();
            vehicule e = new voiture(2001,45673);
            e.demarrer();
            e.accelerer();
            e.Tostring();
            vehicule d= new camion(2012, 77900);
            d.demarrer();
            d.accelerer();
            d.Tostring();

        }
    }
}