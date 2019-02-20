using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameBackend
{

    /// <summary>
    /// Every Matchfield is an 1 x 1 (2 Dimensional) Fieldset.
    /// the fields are always ordered in rows and columns but you can tell a field that it
    /// should be unuseable
    /// </summary>
    public abstract class AbstractMatchfield
    {
        private AbstractField[,] Matchfield;

        public BoardGame Game;

        public AbstractMatchfield(int width, int height)
        {
            Matchfield = new AbstractField[width,height];

            //Dependency Injection on every field. We need this to get back to the Gamerules inside each field.
            foreach (AbstractField abstractField in Matchfield)
            {
                abstractField.Matchfield = this;
            }
        }
    }
}
