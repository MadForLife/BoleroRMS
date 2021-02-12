using System;

namespace Data.Entities
{
    public class Guest
    {
        private DateTime? _timeStmap = null;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime TimeStamp
        {
            get { return this._timeStmap.HasValue ? this._timeStmap.Value : DateTime.Now; }
            set { this._timeStmap = value; }
        }

        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual CreditCard CardDetails { get; set; }

    }
}
