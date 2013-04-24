using System;
using OpenCookly.Entities;

namespace OpenCookly.Modules.Core.Entities
{
    public class Ingredient : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}

