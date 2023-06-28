﻿using Greenroom.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Core.Interfaces
{
    public interface IGreenroomDbContext
    {
        DbSet<User> Users { get; }
    }
}
