using System;
using OpenCookly.Modules.Core.Entities;
using Hegoburu.Presentation.Desktop.Core;
using OpenCookly.Common.UI;

namespace OpenCookly.Modules.Core.UI.Models
{
    public class IngredientInReceipeModel : BaseEntityModel<IngredientInRecipe>
    {      
        public virtual RecipeModel Recipe { get; set; }
        public virtual IngredientModel Ingredient { get; set; }
        public virtual decimal Quantity { get; set; }
        public virtual UnitModel Unit { get; set; }
        public virtual string Comments { get; set; }

        protected override void Initialize(IngredientInRecipe item)
        {
            base.Initialize(item);
            Ingredient = ModelManager.Instance.Get<IngredientModel, Ingredient>(item.Ingredient);
            Unit = ModelManager.Instance.Get<UnitModel, Unit>(item.Unit);
        } 
    }
}

