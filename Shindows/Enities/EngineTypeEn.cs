namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EngineTypeEn")]
    public partial class EngineTypeEn
    {
        public int Id { get; set; }

        public int EngineTypeRusId { get; set; }

        [Required]
        [StringLength(255)]
        public string TranslatedType { get; set; }

        public virtual EngineType EngineType { get; set; }
    }
}
