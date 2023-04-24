﻿using BakeryApp.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.Repository.IRepository
{
    public interface IRecipeIngredientRepository : IRepository<RecipeIngredient>
    {
        void update(RecipeIngredient menuItem);
    }
}
