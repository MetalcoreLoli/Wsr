namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Code")]
    public partial class Code
    {
        public int Id { get; set; }

        public int RegionId { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public virtual Region Region { get; set; }
    }
}
