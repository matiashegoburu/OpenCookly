using System;
using Hegoburu.Presentation.Desktop.Core;
using OpenCookly.Modules.Core.Entities;
using OpenCookly.Common.UI;

namespace OpenCookly.Modules.Core.UI.Models
{
    public class TagModel : BaseEntityModel<Tag>
    {
        public virtual string Name { get; set; }
    }
}

