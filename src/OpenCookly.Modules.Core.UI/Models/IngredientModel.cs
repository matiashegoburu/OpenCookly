using System;
using OpenCookly.Modules.Core;
using OpenCookly.Common.UI;

namespace OpenCookly.Modules.Core.UI.Models
{
    public class IngredientModel : BaseEntityModel<Entities.Ingredient>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }


}

