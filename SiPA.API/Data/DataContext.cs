﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiPA.API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Church> Churches { get; set; }
        public DbSet<Parishioner> Parishioners { get; set; }
        public DbSet<Christening> Christenings { get; set; }
        public DbSet<FirstCommunion> FirstCommunions { get; set; }
        public DbSet<Confirmation> Confirmations { get; set; }
        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<Request> Requests { get; set; }

    }
}
