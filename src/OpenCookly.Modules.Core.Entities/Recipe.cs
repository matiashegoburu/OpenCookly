using System;
using OpenCookly.Entities;
using System.Collections.Generic;

namespace OpenCookly.Modules.Core.Entities
{
    public class Recipe : BaseEntity
    {
        public virtual string Name{ get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Rating { get; set; }
        public virtual int Servings { get; set; }
        public virtual TimeSpan PreparationTime { get; set; }
        public virtual TimeSpan CookingTime { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public virtual List<IngredientInRecipe> Ingredients { get; set; }
        public virtual string Directions { get; set; }
    }
}

