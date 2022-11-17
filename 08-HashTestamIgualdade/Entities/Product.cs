﻿

namespace _08_HashTestamIgualdade.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode()+Price.GetHashCode();  
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Product))
            {
                return false;
            } Product product = obj as Product;
              return Name.Equals(product.Name) && Price.Equals(product.Price);
        }
        public override string ToString()
        {
            return Name+ " - "+Price;
        }
    }
}
