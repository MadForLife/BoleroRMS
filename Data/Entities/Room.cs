using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public class Room
    {
        private DateTime? _timeStamp = null;
        public int Id { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string HouseKeepingStatus { get; set; }
        public bool NeedsRepairs { get; set; }
        public decimal PricePerDay { get; set; }
        public string RoomPriority { get; set; }
        public DateTime HouseKeepingStart { get; set; }
        public DateTime HouseKeepipngEnd { get; set; }
        public bool Visible { get; set; }
        public DateTime TimeStamp
        {
            get { return this._timeStamp.HasValue ? this._timeStamp.Value : DateTime.Now; }
            set { this._timeStamp = value; }
        }

        public virtual ICollection<Booking> Bookings { get; set; }
        
    }
}
