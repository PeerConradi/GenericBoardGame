using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameBackend
{
    public abstract class AbstractRules
    {
        public int MaximumPiecesPerField { get; set; } = 1;
    }
}
