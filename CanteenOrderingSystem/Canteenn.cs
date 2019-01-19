using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenOrderingSystem
{
    class Canteenn {

        public Canteenn()
        {
            newSamosa = 0.0;
            newNoodls = 0.0;
            newVegitable = 0.0;
            newChicken = 0.0;
            newSandwich = 0.0;
            newWater = 0.0;
            newLemon = 0.0;
            newSoft = 0.0;
            newParatha = 0.0;
            newKachchi = 0.0;
            newBhuna = 0.0;
            newPolao = 0.0;
            newPatla = 0.0;
            newRegular = 0.0;
            newChocolate = 0.0;
            newTea = 0.0;

        }
        //overload constructor

        public Canteenn(double Samosa,double Noodls,double Vegitable,double Chicken,double Sandwich,
            double Water,double Lemon,double Soft,double Paratha,double Kachchi,double Bhuna,
            double Polao, double Patla,double Regular,double Chocolate,double Tea)
        {
            newSamosa = Samosa;
            newNoodls = Noodls;
            newVegitable= Vegitable;
            newChicken = Sandwich;
            newWater= Water;
            newLemon = Lemon;
            newSoft = Soft;
            newParatha = Paratha;
            newKachchi= Kachchi;
            newBhuna= Bhuna;
            newPolao = Polao;
            newPatla = Patla;
            newRegular= Regular;
            newChocolate= Chocolate;
            newTea= Tea;


        }


        //accessor function 

        public double getSamosa()
        {
            return newSamosa;
        }
        public double getNoodls()
        {
            return newNoodls;
        }
        public double getVegitable()
        {
            return newVegitable;
        }
        public double getChicken()
        {
            return newChicken;
        }
        public double getWater()
        {
            return newWater;
        }
        public double getLemon()
        {
            return newLemon;
        }
        public double getSoft()
        {
            return newSoft;
        }
        public double getParatha()
        {
            return newParatha;
        }
        public double getKachchi()
        {
            return newKachchi;
        }
        public double getBhuna()
        {
            return newBhuna;
        }
        public double getPolao()
        {
            return newPolao;
        }
        public double getPatla()
        {
            return newPatla;
        }
        public double getRegular()
        {
            return newRegular;
        }
        public double getChocolate()
        {
            return newChocolate;
        }
        public double getTea()
        {
            return newTea;
        }


        //member variable declaration

        private double newSamosa;
        private double newNoodls;
        private double newVegitable;
        private double newChicken;
        private double newSandwich;
        private double newWater;
        private double newLemon;
        private double newSoft;
        private double newParatha;
        private double newKachchi;
        private double newBhuna;
        private double newPolao;
        private double newPatla;
        private double newRegular;
        private double newChocolate;
        private double newTea;
        
    }
}
