using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStoreOfBuild.Domain.Products
{
    public class DomainException: Exception
    {
        public DomainException(string error) : base(error)
        {

        }
        /// <summary>
        /// quando não for valido ele chamara a exeção
        /// </summary>
        /// <param name="valid"></param>
        /// <param name="error"></param>
        public static void When(bool hasError, string error)
        {
            if(!hasError)

                throw new DomainException(error);
        }
    }
}
