namespace CreateCodeModelFromExistingDB_ItemSupport
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AWModel : DbContext
    {
        public AWModel()
            : base("name=Model_dbItemDataSupport")
        {
        }

        public virtual DbSet<tblDepartament> tblDepartaments { get; set; }
        public virtual DbSet<tblInforArtCode> tblInforArtCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblDepartament>()
                .Property(e => e.DEN_GRUPA)
                .IsFixedLength();

            modelBuilder.Entity<tblInforArtCode>()
                .Property(e => e.art_code)
                .HasPrecision(7, 0);
        }
    }
}
