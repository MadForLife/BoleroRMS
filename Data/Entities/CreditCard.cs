using System;

namespace Data.Entities
{
    public class CreditCard
    {
        private DateTime? _timeStamp = null;
        public string CreditCardId { get; set; }
        public DateTime ExpiresOn { get; set; }
        public uint CVV { get; set; }
        public DateTime TimeStamp
        {
            get { return this._timeStamp.HasValue ? this._timeStamp.Value : DateTime.Now; }
            set { this._timeStamp = value; }
        }

        public virtual Guest Guest { get; set; }
    }
}
