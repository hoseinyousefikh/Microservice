﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Domain.Core.Home.DTO
{
    public class ApplicationRole : IdentityRole<int>
    {
        public string Description { get; set; } = string.Empty;
    }
}
