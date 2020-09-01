namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EngineType")]
    public partial class EngineType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EngineType()
        {
            EngineTypeEn = new HashSet<EngineTypeEn>();
            Model = new HashSet<Model>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EngineTypeEn> EngineTypeEn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Model> Model { get; set; }
    }
}
