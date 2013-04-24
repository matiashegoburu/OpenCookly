using System;
using OpenCookly.Modules.Core.Entities;
using Hegoburu.Presentation.Desktop.Core;

namespace OpenCookly.Modules.Core.UI.Models
{
    public class IngredientInReceipeModel : Model<IngredientInRecipe>
    {      
        public virtual RecipeModel Recipe { get; set; }
        public virtual IngredientModel Ingredient { get; set; }
        public virtual decimal Quantity { get; set; }
        public virtual UnitModel Unit { get; set; }
        public virtual string Comments { get; set; }

        protected override void Initialize(IngredientInRecipe item)
        {
            base.Initialize(item);
            IngredientModel = ModelManager.GetInstance().Get<IngredientModel, Ingredient>(item.Ingredient);
            UnitModel = ModelManager.GetInstance().Get<UnitModel, Unit>(item.Unit);
        } 
    }
}

