using System;

using System.Collections.Generic;

using SQLite;

using SQLiteNetExtensions.Attributes;

namespace loom.webapi.models
{
    
    public class Department
    {

        public System.Nullable<int> CostCenter { get; set; }

        public int DepartmentID { get; set; }

        public string Description { get; set; }



    }
}