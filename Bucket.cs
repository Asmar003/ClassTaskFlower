using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskFlower.Models
{
    internal class Bucket
    {
        string _flower;
        int _flowercount;
        float _discountpercent;
        Flower flower;

        public string Flower
        {
            get { return _flower; }
            set
            {
               if(value.Length>2 && value.Length < 20)
               {
                 _flower = value;
               }
            }
        }

        public int FlowerCount
        {
            get { return _flowercount; }
            set
            {
                if(value>0 && value <= 101)
                {
                    _flowercount = value; 
                }
            }
        }
        public float DiscountPercent
        {
            get { return _discountpercent; }
            set
            {
                if (value > 0 && value <= 90)
                {
                    _discountpercent = value;
                }
            }
        }

        public void AddFlower(Flower flower)
        {
            if (FlowerCount==0)
            {
                _flower = flower.ToString();
                FlowerCount=1;
            }
            else if (_flower == flower.ToString() && flower != null)
            {
                FlowerCount++;
            }
        }

        public (float Price, bool HasFlower) GetTotalPrice()
        {
            if (FlowerCount >= 1)
            {
                return (_flower.Price * FlowerCount * (100 - DiscountPercent) / 100, true);
            }
            else
            {
                return(0,false);
            }
        }
    }
}
