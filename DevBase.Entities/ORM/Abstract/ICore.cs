﻿using DevBase.Entities.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Entities.ORM.Abstract
{
    public interface ICore
    {
        int ID { get; set; }
        DateTime AddDate { get; set; }

        DateTime? DeleteDate { get; set; }

        DateTime? UpdateDate { get; set; }

        Status status { get; set; }

    }
}
