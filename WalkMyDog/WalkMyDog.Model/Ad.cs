using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model

{
    public enum AdStatus { ACTIVE, ACCEPTED }
    public abstract class Ad : EntityBase<int>
    {
        public virtual double Price { get; set; }
        public virtual string Title { get; set; }
        public virtual AdStatus AdStatus { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int DogsNumber { get; set; }
        public virtual int Hours { get; set; }
        public Ad(double Price, string Title, AdStatus AdStatus, string Description,
            DateTime Date, int DogsNumber, int Hours)
        {
            this.Price = Price;
            this.Title = Title;
            this.AdStatus = AdStatus;
            this.Description = Description;
            this.Date = Date;
            this.DogsNumber = DogsNumber;
            this.Hours =Hours;
        }

        public Ad()
            : base()
        {
        }

    }
}
