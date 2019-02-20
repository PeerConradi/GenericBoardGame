using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameBackend
{
    public abstract class AbstractField
    {
        public bool IsDoubleUseable { get; set; } = false;

        private List<AbstractPiece> Pieces { get; set; }

        //The Matchfield this field is on
        public AbstractMatchfield Matchfield;

        public AbstractField()
        {
            Pieces = new List<AbstractPiece>();
        }

        public bool HasFigureOn
        {
            get
            {
                if (Pieces == null)
                    return false;

                return (Pieces.Count > 0);
            }
        }


        /// <summary>
        /// Removes every piece from the field and sets only one in place
        /// </summary>
        /// <param name="figure"></param>
        public void SetPiece(AbstractPiece figure)
        {
            if (Pieces != null)
            {
                this.Pieces.Clear();
                this.Pieces.Add(figure);
            }
        }

        public void AddPiece(AbstractPiece figure)
        {
            if (IsDoubleUseable)
            {
                this.Pieces.Add(figure);
            }
        }

        /// <summary>
        /// Gets the first piece on the field.
        /// If the field is empty it will return null.
        /// </summary>
        /// <returns></returns>
        public AbstractPiece GetPiece()
        {
            if (Pieces.Count == 0)
                return null;

            return (Pieces[0]);
        }

        public void MovePieceToField(AbstractField field)
        {

        }
    
    }
}
