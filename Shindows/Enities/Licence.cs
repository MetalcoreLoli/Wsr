namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Licence")]
    public partial class Licence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Licence()
        {
            LicenceWithStatus = new HashSet<LicenceWithStatus>();
            LiceneceHasCategories = new HashSet<LiceneceHasCategories>();
        }

        public int Id { get; set; }

        public int DriverId { get; set; }

        public int Serial { get; set; }

        public int Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpireDate { get; set; }

        public virtual Driver Driver { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LicenceWithStatus> LicenceWithStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LiceneceHasCategories> LiceneceHasCategories { get; set; }
    }
}
