﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramlineFive.DataAccess.Entities
{
    public class Stop : BaseEntity
    {
        public Stop()
        {
            Timings = new HashSet<string>();
        }

        public int GetId()
        {
            return ID;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string TimingsAsString
        {
            get
            {
                return string.Join(",", Timings);
            }
            set
            {
                Timings = value.Split(',').ToList();
            }
        }

        public ICollection<string> Timings { get; set; }
    }
}