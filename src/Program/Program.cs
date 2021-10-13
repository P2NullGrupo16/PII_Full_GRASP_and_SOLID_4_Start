﻿//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Catalog catalog1 = new Catalog();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = catalog1.GetProduct("Café con leche");
            recipe.AddStep(new Step(catalog1.GetProduct("Café"), 100, catalog1.GetEquipment("Cafetera"), 120));
            recipe.AddStep(new Step(catalog1.GetProduct("Leche"), 200, catalog1.GetEquipment("Hervidor"), 60));

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);

           // catalog1.AddProductToCatalog("Bla Bla bla", 100);
        }

        

       
    }
}
