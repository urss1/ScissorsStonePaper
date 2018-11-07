using SUMALI.TUT.ScissorsStonePaper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMALI.TUT.ScissorsStonePaper.Controller
{
    /// <summary>
    /// Klasse zum ermitteln wer gewinnt.
    /// Festgelegt, wer schlägt wen.
    /// Überprüfen wer gewinnt und dies zurückgeben.
    /// </summary>
    internal class EvaluateWinnerController
    {
        // Liste für die Auswertung wer schlägt wen
        private Dictionary<SelectedImage, List<SelectedImage>> whoWinsAgainstWho = new Dictionary<SelectedImage, List<SelectedImage>>();

        internal EvaluateWinnerController()
        {
            // ToDo : Hier die Liste mit wer schlägt wen eingragen...
        }

        internal EvaluatedWinner EvaluateHumanWins(SelectedImage humanChoose, SelectedImage computerChoose)
        {
            // ToDo : Wer gewinnt gegen wen auswerten
            // HINWEIS: Vergiss nicht das Unentschieden, wenn beide dasselbe wählen.

            // Dies sollte nie angewendet werden müssen...
            return EvaluatedWinner.none;
        }
    }
}
