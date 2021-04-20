using System;
using System.Collections.Generic;
using System.Text;

namespace пересдача_GUI
{
   public class OneWagon : ComonWagon
    {
        private int count;
        private double weight;
        private double onePrice;

        public OneWagon() : base()
        {
        }
        public override double GetPrice()
        {
            return count * onePrice;
        }
        public override double GetWeight()
        {
            return count * weight;
        }

        public OneWagon(int id, string typeProdukt, string sohrProdukt, string name, int date, int count, double weight, double onePrice) : base(id, typeProdukt, sohrProdukt, name, date)
        {
            this.count = count;
            this.weight = weight;
            this.onePrice = onePrice;
        }


        public int getCount
        {
            get { return count; }

        }
        public double getWeight
        {
            get { return weight; }

        }
        public double getOnePrice
        {
            get { return onePrice; }

        }
         public override string Print() 
         {
            
            return " id " + id+ "\n" +" name "+name+"\n"+" штучный долгохранящийся "+ "\n" +"дата формирования "+ date + "\n"+ "Вес "+ weight+"\n"+"цена"+ onePrice+ "\n"+"количество"+count+"\n";
         }
        


    }
}
