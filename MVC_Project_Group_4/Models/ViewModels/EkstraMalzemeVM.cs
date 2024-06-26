﻿using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class EkstraMalzemeVM
    {
        public EkstraMalzemeEkleVM EkstraMalzemeEkleVM { get; set; }

        public List<EkstraMalzeme>? EkstraMalzemeler { get; set; } = new List<EkstraMalzeme>();

        public EkstraMalzeme EkstraMalzeme { get; set; }
    }
}
