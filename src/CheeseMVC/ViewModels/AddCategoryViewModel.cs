﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required(ErrorMessage = "Category name is required")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
    }
}
