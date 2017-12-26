﻿using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please provide a cheese category name good sir!")]
        public string Name { get; set; }

        public Cheese Cheeses { get; set; }

    }
}

