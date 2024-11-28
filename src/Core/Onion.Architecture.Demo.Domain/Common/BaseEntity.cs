using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Architecture.Demo.Domain.Common
{
    public  class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
