﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarRental_App.Models
{
    public class Categorie
    {
        public int CategorieID { get; set; }
        public string Beschrijving { get; set; }
        public int AantalDeuren { get; set; }
        public int AantalZitplaatsen { get; set; }
        public float PrijsPerDag { get; set; }
    }
}
