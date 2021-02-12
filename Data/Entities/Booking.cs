using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public class Booking
    {
        private DateTime? _timeStamp = null;
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string BookingStatus { get; set; }
        public DateTime TimeStamp
        {
            get { return this._timeStamp.HasValue ? this._timeStamp.Value : DateTime.Now; }
            set { this._timeStamp = value; }
        }

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
