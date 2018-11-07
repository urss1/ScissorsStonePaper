using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SUMALI.TUT.ScissorsStonePaper.Controller
{
    /// <summary>
    /// Klasse zum Speichern der Runden.
    /// </summary>
    internal class RoundResult
    {
        /// <summary>
        /// Nummer der Runde
        /// </summary>
        internal int RoundNumber { get; private set; }
        /// <summary>
        /// Name des Gewinner der Runde
        /// </summary>
        internal string WinnerName { get; private set; }

        internal RoundResult(int number, string winner)
        {
            RoundNumber = number;
            WinnerName = winner;
        }
    }
}