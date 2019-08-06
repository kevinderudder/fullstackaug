using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
