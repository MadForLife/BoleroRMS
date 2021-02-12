using System;

namespace Data.Entities
{
    public class HouseKeeper
    {
        private DateTime? _timeStamp = null;
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeStamp
        {
            get { return this._timeStamp.HasValue ? this._timeStamp.Value : DateTime.Now; }
            set { this._timeStamp = value; }
        }
    }
}
