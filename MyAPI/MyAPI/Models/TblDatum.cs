using System;
using System.Collections.Generic;

#nullable disable

namespace MyAPI.Models
{
    public partial class TblDatum
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public string EmpImage { get; set; }
    }
}
