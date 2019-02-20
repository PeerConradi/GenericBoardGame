using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoardGameBackend
{
    public class BoardGame
    {
        /// <summary>
        /// Every Game has to have a field it is played on.
        /// </summary>
        public AbstractMatchfield MatchField { get; set; }

        public AbstractRules Rules { get; set; }

        public BoardGame(AbstractMatchfield field)
        {
            MatchField = field;
            MatchField.Game = this;
        }

        public void SetRules(AbstractRules rules)
        {
            Rules = rules;
        }
    }
}
