using DevBase.Entities.ORM.Abstract;
using DevBase.Entities.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Entities.ORM.Concerte
{
    public class BaseEntity : ICore
    {
        public int ID { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status status { get; set; } = Status.Active;
    }
}
