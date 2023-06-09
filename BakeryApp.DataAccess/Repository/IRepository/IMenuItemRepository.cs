﻿using BakeryApp.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.Repository.IRepository
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void update(MenuItem menuItem);
    }
}
