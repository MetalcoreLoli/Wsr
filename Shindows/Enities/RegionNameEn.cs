namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegionNameEn")]
    public partial class RegionNameEn
    {
        public int Id { get; set; }

        public int? RegionId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual Region Region { get; set; }
    }
}
