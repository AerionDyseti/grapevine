using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapevine.Models.Menus
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Note { get; set; }
        public bool RequiresSpecialization { get; set; }
        public List<MenuItem> Specializations { get; set; }
    }


}
