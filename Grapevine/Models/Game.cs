using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Grapevine.Models
{
    public class Game
    {
        [YAXAttributeForClass]
        public string Title { get; set; } = "Untitled Game";

        [YAXAttributeForClass]
        public GameType Type { get; set; } = GameType.BNS;

        public string Website { get; set; } = "";
        public string Email { get; set; } = "";
        public string Description { get; set; } = "A game created by Grapevine 4.0";
        public List<DateTime> GameDates { get; set; } = new List<DateTime>();
    }
}
