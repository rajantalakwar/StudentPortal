﻿using Microsoft.EntityFrameworkCore;

namespace StudentPortal.web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
