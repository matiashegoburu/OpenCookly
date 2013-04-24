using System;
using OpenCookly.Modules.Core;

namespace OpenCookly.Modules.Core.UI.Models
{
    public class IngredientModel : Model<Entities.Ingredient>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }


}

