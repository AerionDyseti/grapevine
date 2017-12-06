using System.Collections.Generic;

namespace Grapevine.Models.Menus
{
    public class Menu
    {
        public int Id { get; set; }
        public List<MenuItem> Items { get; set; }
        public List<Menu> SubMenus { get; set; }
        public List<Menu> IncludedMenu { get; set; }
        
    }
}
