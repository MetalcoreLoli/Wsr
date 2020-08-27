namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int Id { get; set; }

        public int DriverId { get; set; }

        public int ModelId { get; set; }

        public int ColorId { get; set; }

        public int TypeOfDriveId { get; set; }

        [Required]
        [StringLength(255)]
        public string VIN { get; set; }

        public int Year { get; set; }

        public int Weight { get; set; }

        public virtual Color Color { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual Model Model { get; set; }

        public virtual TypeOfDrive TypeOfDrive { get; set; }
    }
}
