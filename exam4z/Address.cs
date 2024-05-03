using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam4z
{
    class Address
    {
        string index, country, city, street;
        int house,apartment;

        public string Index { get => index; set => index = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int House { get => house; set => house = value; }
        public int Apartment { get => apartment; set => apartment = value; }
        public Address(string index,string country,string city,string street,int house,int apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
        public override string ToString()
        {
            return $"{index} {country} {city} {street} {house} {apartment}";
        }
        
    }
}
