using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskFlower.Models
{
    internal record Flower
    {
        string _name;
        string _color;
        float _price;

        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length>2 && value.Length<=20)
                _name = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public float Price
        {
            get { return _price; }
            set
            {
                if (value >= 0.10)
                {
                    _price = value;

                }
            }
        }
         
    }
}
