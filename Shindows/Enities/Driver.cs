namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        public int Id { get; set; }

        public int JobId { get; set; }

        public int CompanyId { get; set; }

        public int PersonId { get; set; }

        public virtual Company Company { get; set; }

        public virtual Job Job { get; set; }

        public virtual Passport Passport { get; set; }
    }
}
