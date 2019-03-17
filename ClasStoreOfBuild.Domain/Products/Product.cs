using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStoreOfBuild.Domain.Products
{
   public class Product
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public Categoria Categoria { get; private set; }

        public decimal Price { get; private set; }

        public int StockQuantity { get; private set; }

        public Product(string name, Categoria categoria, decimal price, int stockquantity)
        {

            ValidateValues(name,categoria,price,stockquantity);
            SetProperties(name, categoria, price, stockquantity);
        }

        //para atualizar um produto já existente e retornar o produto atualizado
        public void Update(string name, Categoria categoria, decimal price, int stockquantity)
        {
            ValidateValues(name, categoria, price, stockquantity);
            SetProperties(name, categoria, price, stockquantity);
        }

        //set executar o conjunto
        private void SetProperties(string name, Categoria categoria, decimal price, int stockquantity)
        {
            Name = name;
            Categoria = categoria;
            Price = price;
            StockQuantity = stockquantity;
        }
        private static void ValidateValues(string name, Categoria categoria, decimal price, int stockquantity)
        {
            //metodo de validações
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(categoria == null, "Categoria is required");
            DomainException.When(price < 0, "Price is required");
            DomainException.When(stockquantity < 0, "Stock quantity is required");
        }
     
    }
}
