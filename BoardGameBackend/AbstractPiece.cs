using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameBackend
{

    public abstract class AbstractPiece
    {
        /// <summary>
        /// To find a figure we want it to have an unique ID.
        /// </summary>
        public string ID { get; set; }

        public AbstractPiece(string id = null)
        {
            this.ID = id ?? Guid.NewGuid().ToString();
        }
    }
}
