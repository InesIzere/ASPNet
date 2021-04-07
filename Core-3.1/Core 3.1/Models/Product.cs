﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public class Product
    {
        public long Id { get; set; }
      
        public long CustomerId { get; set; }
        public long BuildingId { get; set; }
        public long? BatteryId { get; set; }
        public long? ColumnId { get; set; }
        public long? ElevatorId { get; set; }
        public long? EmployeeId { get; set; }
        

        public virtual Battery Battery { get; set; }
        public virtual Building Building { get; set; }
        public virtual Column Column { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Elevator  Elevator { get; set; }
        
    }

}
