using System;
using System.Collections.Generic;
using System.Text;
using ClassStoreOfBuild.Domain.Dtos;

namespace ClassStoreOfBuild.Domain.Products
{
    /// <summary>
    /// Calsse para armazenar os produtos
    /// </summary>
    public class ProductStorer
    {
        public readonly IRepository<Product> _productrepository;
        public readonly IRepository<Categoria> _categoriarepository;

        public ProductStorer(IRepository<Product> productrepository, IRepository<Categoria> categoriarepository)
        {
            _productrepository = productrepository;
            _categoriarepository = categoriarepository;
        }

        public void Store(ProductDto dto)
        {
            var categoria = _categoriarepository.GetById(dto.Categoriaid);
            DomainException.When(categoria == null, "Categoria invalid");

            //buscar o produto usando a persistencia
            var product = _productrepository.GetById(dto.ID);
            if (product == null)
            {
                product = new Product(dto.Name, categoria, dto.Price, dto.Categoriaid);
                _productrepository.Save(product);
            }
            else
            {
                product.Update(dto.Name, categoria, dto.Price, dto.Categoriaid);
            }

        }
    }

}
