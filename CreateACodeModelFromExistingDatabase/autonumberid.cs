namespace CreateACodeModelFromExistingDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("autonumberid")]
    public partial class autonumberid
    {
        public int id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8)]
        public string categoryid { get; set; }

        [StringLength(20)]
        public string productname { get; set; }
    }
}
