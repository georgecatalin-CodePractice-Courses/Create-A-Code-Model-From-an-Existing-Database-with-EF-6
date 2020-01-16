namespace CreateCodeModelFromExistingDB_ItemSupport
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInforArtCode")]
    public partial class tblInforArtCode
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal art_code { get; set; }

        [StringLength(50)]
        public string art_comment { get; set; }

        [StringLength(50)]
        public string art_user { get; set; }

        [StringLength(50)]
        public string art_datetime { get; set; }
    }
}
