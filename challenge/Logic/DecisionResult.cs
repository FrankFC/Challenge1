using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.Players;
using Challenge.Shapes;

namespace Challenge.Logic
{
    public class DecisionResult
    {
        public bool IsDraw { get; set; }
        public IShape WinnerShape { get; set; }
        public Player WinnerPlayer { get; set; }
    }
}
