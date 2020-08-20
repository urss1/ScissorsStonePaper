using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMALI.TUT.ScissorsStonePaper.Enums
{
    /// <summary>
    /// Auswahlliste für die Möglichkeiten zum Auswählen.
    /// Schere, Stein oder Papier
    /// </summary>
    public enum SelectedImage
    {
        /// <summary>
        /// Schere
        /// </summary>
        Scissors,
        /// <summary>
        /// Stein
        /// </summary>
        Stone,
        /// <summary>
        /// Papier
        /// </summary>
        Paper,
        /// <summary>
        /// Echse
        /// </summary>
        Lizard,
        /// <summary>
        /// Spock
        /// </summary>
        Spock,
        /// <summary>
        /// Keines - es wird kein Bild angezeigt.
        /// Wird beim Start und für den Computer für ein neues Spiel verwendet.
        /// </summary>
        none
    }
}
