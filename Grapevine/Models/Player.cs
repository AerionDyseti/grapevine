using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapevine.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public DateTime LastModified { get; set; }
    }
}
