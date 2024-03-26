using System;
using System.Threading.Channels;


namespace PR26._03_Shalimov
{
    public class Plane
    {
        private  string _brand;
        private string _model;
        private string _country;
        private int _year;
        private int _fuelQuantity;

        public Plane(string brand, int year, string model, string country, int fuelQuantity )
        {
            _brand = brand;
            _year = year;
            _model = model;
            _country = country;
            _fuelQuantity = fuelQuantity;
        }

        private  bool Charging()
        {
            if (_fuelQuantity > 60000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Flight()
        {
            if( Charging() )
            {
                Console.WriteLine("Ми можемо взлетіти!");
            }
            else
            {
                Console.WriteLine("Недостатньо топлива:(");
            }
        }

        public void Info() {
            Console.WriteLine($"Літак марки{_brand}, під назвою {_model} було випущено у {_year} році в {_country}");
        }
    }
}
