using System;
using Hegoburu.Presentation.Desktop.Core;
using OpenCookly.Modules.Core.Entities;
using OpenCookly.Common.UI;
using System.Collections.Generic;

namespace OpenCookly.Modules.Core.UI.Models
{
    public class RecipeModel : BaseEntityModel<Recipe>
    {
        public virtual string Name { get; set; }
        public virtual string Description{ get; set; }
        public virtual decimal Rating{ get; set; }
        public virtual int Servings{ get; set; }

        public virtual TimeSpan PreparationTime { get; set; }
        public virtual TimeSpan CookingTime { get; set; }
        public virtual ModelList<TagModel, Tag> Tags { get; set; }
        public virtual ICollection<IngredientInRecipe> Ingredients { get; set; }
        public virtual string Directions { get; set; }

        protected override void Initialize(Recipe item)
        {
            base.Initialize(item);
            Tags = new ModelList<TagModel, Tag>(item.Tags);
        } 
    }
}

