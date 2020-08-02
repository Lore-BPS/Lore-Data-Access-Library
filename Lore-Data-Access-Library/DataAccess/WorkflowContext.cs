using LoreDataAccessLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lore_Data_Access_Library.DataAccess
{
    public class WorkflowContext :DbContext
    {
        public WorkflowContext(DbContextOptions options): base(options) { }

        public DbSet<LoreDataAccessLibrary.Model.Action> Action { get; set; }
        public DbSet<LoreDataAccessLibrary.Model.ActionTypes> ActionTypes { get; set; }
        public DbSet<LoreDataAccessLibrary.Model.BackendServers> BackendServers { get; set; }
        public DbSet<LoreDataAccessLibrary.Model.Elements> Elements { get; set; }
        public DbSet<LoreDataAccessLibrary.Model.Frontons> Frontons { get; set; }
        public DbSet<LoreDataAccessLibrary.Model.HistoryElements> HistoryElements { get; set; }
        public DbSet<LoreDataAccessLibrary.Model.Process> Process { get; set; }
        public DbSet<LoreDataAccessLibrary.Model.Step> Steps { get; set; }



    }
}
