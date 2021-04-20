using System;
using System.Collections.Generic;
using System.Text;

namespace пересдача_GUI
{
 public   class ComonWagon : Interface1
    {
        protected int id;
        protected string typeProdukt;
        protected string sohrProdukt;
        protected string name;
        protected int date;
        protected int dateSkor;
        protected double comonPrice;
        protected double comonWeight;
        public int dateReturn;

        public ComonWagon() 
        {
            Console.WriteLine("создался пустой объект");
        }
        public virtual double GetPrice()
        {
            return 0;
        }
        public virtual double GetWeight()
        {
            return 0;
        }
        public ComonWagon(int id, string typeProdukt, string sohrProdukt, string name, int date)
        {
            this.id = id;
            this.typeProdukt = typeProdukt;
            this.sohrProdukt = sohrProdukt;
            this.name = name;
            this.date = date;
            dateReturn = date + 10;
    }
        public int getId
        {
            get { return id; }
        }
        public string getTypeProdukt
        {
            get { return typeProdukt; }
        }
        public string getSohrProdukt
        {
            get { return sohrProdukt; }
        }
        public string getName
        {
            get { return name; }
        }
        public int getDate
        {
            get { return date; }
        }
        public virtual int getSrokGode()
        {
            return 0;
        }
        public double getComonPrice
        {
            get { return comonPrice; }
        }
        public double getComonWeight
        {
            get { return comonWeight; }
        }
        virtual public string Print()
        {
            return "";
        } 
    }
}
