using System;
using Hegoburu.Presentation.Desktop.Core;
using OpenCookly.Modules.Core.Entities;
using OpenCookly.Common.UI;
using System.Collections.Generic;

namespace OpenCookly.Modules.Core.UI.Models
{
    public class RecipeModel : BaseEntityModel<Recipe>
    {
        public RecipeModel(Recipe item)
            : base(item)
        {
            
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        private decimal _rating;
        public decimal Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;
                OnPropertyChanged("Rating");
            }
        }

        private int _servings;

        public int Servings
        {
            get
            {
                return _servings;
            }
            set
            {
                _servings = value;
            }
        }
        public TimeSpan PreparationTime { get; set; }
        public TimeSpan CookingTime { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<IngredientInRecipe> Ingredients { get; set; }
        public string Directions { get; set; }
    }
}

