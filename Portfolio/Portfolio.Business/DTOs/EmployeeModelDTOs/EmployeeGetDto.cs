
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Business.DTOs.EmployeeModelDTOs
{
    public class EmployeeGetDto
    {
        public  string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { get; set; }
        public List<string> Professions { get; set; }
        public string ImageUrl { get; set; }
        public string LinkedIn { get; set; }
        public string Insta { get; set; }
        public string Facebook { get; set; }
        public string GitHub { get; set; }
    }
}
