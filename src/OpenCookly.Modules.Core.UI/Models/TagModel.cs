using System;
using Hegoburu.Presentation.Desktop.Core;
using OpenCookly.Modules.Core.Entities;

namespace OpenCookly.Modules.Core.UI.Models
{
    public class TagModel : Model<Tag>
    {
        public virtual string Name { get; set; }
    }
}

