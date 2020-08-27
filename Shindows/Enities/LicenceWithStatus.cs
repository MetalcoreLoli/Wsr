namespace Shindows.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LicenceWithStatus
    {
        public int Id { get; set; }

        public int LicenceId { get; set; }

        public int StatusId { get; set; }

        public virtual Licence Licence { get; set; }

        public virtual LicenceStatus LicenceStatus { get; set; }
    }
}
