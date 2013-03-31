using System;
using OpenCookly.Entities;

namespace OpenCookly.Modules.Core.Entities
{
    public class Tag : BaseEntity
    {
        public virtual string Name { get; set; }
    }
}

