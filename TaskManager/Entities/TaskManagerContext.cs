using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TaskManager.Entities
{
    public class TaskManagerContext:DbContext
    {
        public TaskManagerContext():base("Name=TaskManagerContext")
        {
        }
        public IDbSet<Task> Tasks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new TaskManagerConfuguration());
        }
        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new TaskManagerConfuguration(schema));
            return modelBuilder;
        }
    }
}