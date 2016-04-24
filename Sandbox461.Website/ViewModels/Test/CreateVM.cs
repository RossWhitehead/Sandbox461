using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Sandbox461.ViewModels.Test
{
    public class CreateVM : IValidatableObject
    {
        #region Properties
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public int SelectedCategoryId { get; set; }
        #endregion

        #region List Items
        private List<Category> categories;

        public CreateVM()
        {
            this.categories = new List<Category>();
            this.categories.Add(new Category { CategoryId = 1, Name = "Category 1" });
            this.categories.Add(new Category { CategoryId = 2, Name = "Category 2" });
            this.categories.Add(new Category { CategoryId = 3, Name = "Category 3" });
            this.categories.Add(new Category { CategoryId = 4, Name = "Category 4" });
            this.categories.Add(new Category { CategoryId = 5, Name = "Category 5" });
        }

        public IEnumerable<SelectListItem> CategorySelectListItems
        {
            get { return new SelectList(this.categories, "CategoryId", "Name"); }
        }
        #endregion

        #region Custom Validation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield return new ValidationResult("Start Date must be before End Date.", new List<string>() { "StartDate", "EndDate" });
        }
        #endregion
    }
}