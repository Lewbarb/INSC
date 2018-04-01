namespace CDProjektRED
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CDModel : DbContext
    {
        public CDModel()
            : base("name=CDModel2")
        {
        }

        public virtual DbSet<CDtbl> CDtbls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CDtbl>()
                .Property(e => e.Artist)
                .IsUnicode(false);

            modelBuilder.Entity<CDtbl>()
                .Property(e => e.Album)
                .IsUnicode(false);
        }
    }
}
