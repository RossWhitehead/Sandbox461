using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Sandbox461.ViewModels.Default
{
    public class TestIndexViewModel
    {
        private List<Category> categories;

        public TestIndexViewModel()
        {
            this.categories = new List<Category>();
            this.categories.Add(new Category { CategoryId = 1, Name = "Category 1" });
            this.categories.Add(new Category { CategoryId = 2, Name = "Category 2" });
            this.categories.Add(new Category { CategoryId = 3, Name = "Category 3" });
            this.categories.Add(new Category { CategoryId = 4, Name = "Category 4" });
            this.categories.Add(new Category { CategoryId = 5, Name = "Category 5" });
        }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int SelectedCategoryId { get; set; }

        public IEnumerable<SelectListItem> CategorySelectListItems
        {
            get { return new SelectList(this.categories, "CategoryId", "Name"); }
        }
    }
}