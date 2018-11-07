using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMALI.TUT.ScissorsStonePaper.Enums
{
    /// <summary>
    /// Auswahl Liste für die Ermittlung des Gewinners...
    /// </summary>
    internal enum EvaluatedWinner
    {
        /// <summary>
        /// Der Spieler hat gewonnen.
        /// </summary>
        HumanPlayer,
        /// <summary>
        /// Der Computer hat gewonnen.
        /// </summary>
        ComputerPlayer,
        /// <summary>
        /// Es ist unentschieden...
        /// </summary>
        none
    }
}
