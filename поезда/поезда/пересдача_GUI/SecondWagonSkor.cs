using System;
using System.Collections.Generic;
using System.Text;

namespace пересдача_GUI
{
   public class SecondWagonSkor : ComonWagon
    {
       private double allWeight;
       private double allPrice;
       private int srokGod;

        public SecondWagonSkor() : base()
        {
        }
        public override double GetPrice()
        {
            return allWeight * allPrice;
        }
        public override double GetWeight()
        {
            return allWeight ;
        }
        public SecondWagonSkor(int id, string typeProdukt, string sohrProdukt, string name, int date, double allWeight, double allPrice, int srokGod) : base(id, typeProdukt, sohrProdukt, name, date)
        {
            this.allWeight = allWeight;
            this.allPrice = allPrice;
            this.srokGod = srokGod;

        }
        public double getAllPrice
        {
            get { return allPrice; }

        }
        public double getAllWeight
        {
            get { return allWeight; }
        }
       

        public  override int getSrokGode()
        {
            return srokGod; 

        }
        public override string Print()
        {

            return "id " + id + "\n" + "name " + name + "\n" + " весовой скоропортящийся " + "\n" + "дата формирования " + date + "\n" + "Вес " + allWeight + "\n" + "цена" + allPrice + "\n"+"срок годности " + srokGod+"\n";
        }


    }
}
