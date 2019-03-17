using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStoreOfBuild.Domain.Products
{
 public   class CategoriaStorer
 {
     private readonly IRepository<Categoria> _categoriaRepository;

        public CategoriaStorer(IRepository<Categoria> categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public void Store(CategoriaDto dto)
        {
            var categoria = _categoriaRepository.GetById(dto.Id)
                //para verificar se existe o produto
                if (categoria == null)
                {
                    categoria = new Categoria(dto.Name);
                    _categoriaRepository.Save(categoria);
                }
                else
                {
                    categoria.Update(dto.Name);
                }
        }
    }
}
