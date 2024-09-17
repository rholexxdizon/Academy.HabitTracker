using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habit_tracker.Model
{
    public class HabitLog
    { 
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public int Quantity { get; set; }
    }
}
