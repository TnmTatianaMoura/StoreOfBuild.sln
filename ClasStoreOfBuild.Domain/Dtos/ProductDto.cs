using System;
using System.Collections.Generic;
using System.Text;
using ClassStoreOfBuild.Domain.Products;

namespace ClassStoreOfBuild.Domain.Dtos
{
 public class ProductDto
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public int Categoriaid { get; private set; }

        public decimal Price { get; private set; }

        public int StockQuantity { get; private set; }
    }
}
