using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA
{
    public class Adress
    {
        string city;
        string street;
        string houseNumber;
        int postalCode;
        public Adress()
        {
            city = string.Empty;
            street = string.Empty;
            houseNumber = string.Empty;
            postalCode = 0;
        }
        public Adress(string city, string street, string houseNumber, int postalCode)
        {
            this.city = city;
            this.street = street;
            this.houseNumber = houseNumber;
            this.postalCode = postalCode;
        }

        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string HouseNumber { get => houseNumber; set => houseNumber = value; }
        public int PostalCode { get => postalCode; set => postalCode = value; }
        public override string ToString()
        {
            return $"{street} {houseNumber}, {postalCode} {city}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Adress)
            {
                Adress other = (Adress)obj;
                return this.city == other.city && this.street == other.street && this.houseNumber == other.houseNumber && this.postalCode == other.postalCode;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(city, street, houseNumber, postalCode);
        }
    }
}
