using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TaskManager.Entities
{
    internal class TaskManagerConfuguration : EntityTypeConfiguration<Task>
    {
        public TaskManagerConfuguration():this("dbo")
        {
        }
        public TaskManagerConfuguration(string schema)
        {
            ToTable(schema+".Task");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("Id").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.createdDate).HasColumnName("CreatedDate").HasColumnType("datetime2");
            Property(x => x.DueDate).HasColumnName("DueDate").HasColumnType("datetime2");
            Property(x => x.taskSubject).HasColumnName("TaskSubject").HasColumnType("varchar");
            Property(x => x.taskCompletionStatus).HasColumnName("TaskCompletionStatus").HasColumnType("int");
        }
    }
}