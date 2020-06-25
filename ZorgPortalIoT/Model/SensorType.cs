using System;
using System.Collections.Generic;

namespace ZorgPortalIoT.Model
{
    public partial class SensorType
    {
        public SensorType()
        {
            Sensor = new HashSet<Sensor>();
        }

        public int TypeId { get; set; }
        public string Naam { get; set; }

        public virtual ICollection<Sensor> Sensor { get; set; }
    }
}
