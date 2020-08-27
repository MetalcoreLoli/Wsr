namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LiceneceHasCategories
    {
        public int Id { get; set; }

        public int LicenceId { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Licence Licence { get; set; }
    }
}
