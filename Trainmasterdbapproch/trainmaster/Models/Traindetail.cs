using System;
using System.Collections.Generic;

namespace trainmaster.Models
{
    public partial class Traindetail
    {
        public int TrainNo { get; set; }
        public string? TrainName { get; set; }
        public string? FromStation { get; set; }
        public string? ToStation { get; set; }
        public TimeSpan? JourneyStartTime { get; set; }
        public TimeSpan? JourneyEndTime { get; set; }
       
    }
}
