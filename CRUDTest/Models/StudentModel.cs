using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDTest.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public int SeatNumber { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
    }
}