namespace CreateCodeModelFromExistingDB_ItemSupport
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDepartament")]
    public partial class tblDepartament
    {
        [Key]
        [StringLength(10)]
        public string pkCOD_GRUPA { get; set; }

        [Required]
        [StringLength(30)]
        public string DEN_GRUPA { get; set; }
    }
}
