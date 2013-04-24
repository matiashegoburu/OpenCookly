using System;
using OpenCookly.Entities;

namespace OpenCookly.Modules.Core.Entities
{
    public class IngredientInRecipe : BaseEntity
    {
        public virtual Recipe Recipe { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public virtual decimal Quantity { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual string Comments { get; set; }



    }
}

