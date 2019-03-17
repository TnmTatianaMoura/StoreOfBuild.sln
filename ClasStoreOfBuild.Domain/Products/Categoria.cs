using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStoreOfBuild.Domain.Products
{
    public class Categoria
    {
        public int ID{ get; private set; }

        public string Name { get; private  set; }


        public Categoria(string name)
        {
            ValidateNameAndSetName(name);
        }
        public void Update(string name)
        {
            ValidateNameAndSetName(name);
        }

        private void ValidateNameAndSetName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "name is required");
            Name = name;
        }

        

    }
}
