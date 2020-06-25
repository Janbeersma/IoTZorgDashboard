using System;
using System.Collections.Generic;

namespace ZorgPortalIoT.Model
{
    public partial class SensorMeting
    {
        public int MetingId { get; set; }
        public int SensorId { get; set; }
        public double MetingWaarde { get; set; }
        public DateTime? MetingTimestamp { get; set; }
        public bool? Alarm { get; set; }

        public virtual Sensor Sensor { get; set; }
    }
}
