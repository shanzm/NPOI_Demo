#region
// ===============================================================================
// Project Name        :    IPON_Demo1
// Project Description : 
// ===============================================================================
// Class Name          :    DishInfo
// Class Version       :    v1.0.0.0
// Class Description   : 
// CLR                 :    4.0.30319.18408  
// Author              :    单志铭(shanzm)
// Create Time         :    2018-7-26 01:02:15
// Update Time         :    2018-7-26 01:02:15
// ===============================================================================
// Copyright © SHANZM-PC  2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPOI_Demo1
{
    public partial class DishInfo
    {
        public int DId { get; set; }
        public string DTitle { get; set; }
        public decimal  DPrice { get; set; }
        public int DTypeId { get; set; }
        public string DChar { get; set; }

    }
}
