using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Architecture.Demo.Domain.Common;

namespace Onion.Architecture.Demo.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }

        public decimal Value { get; set; }
        public int Quantity { get; set; }


    }
}
