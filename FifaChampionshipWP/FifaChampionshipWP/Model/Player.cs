using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaChampionshipWP.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public bool Active { get; set; }
    }
}
