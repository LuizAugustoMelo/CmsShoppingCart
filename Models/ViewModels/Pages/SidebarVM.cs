﻿using CmsShoppingCart.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CmsShoppingCart.Models.ViewModels.Pages
{
    public class SidebarVM
    {
        public int Id { get; set; }

        [AllowHtml]
        [StringLength(int.MaxValue, MinimumLength = 3)]
        public string Body { get; set; }

        public SidebarVM()
        {

        }

        public SidebarVM(SidebarDTO row)
        {
            Id = row.Id;
            Body = row.Body;
        }
    }
}