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
            // Papier bedeck Stein
            // Papier widerlegt Spock
            whoWinsAgainstWho.Add(SelectedImage.Paper, new List<SelectedImage>() { SelectedImage.Stone, SelectedImage.Spock });
            // Schere schneidet Papier
            // Schere köpft Echse
            whoWinsAgainstWho.Add(SelectedImage.Scissors, new List<SelectedImage>() { SelectedImage.Paper, SelectedImage.Lizard });
            // Stein schleift Schere
            // Stein zerqutscht Echse
            whoWinsAgainstWho.Add(SelectedImage.Stone, new List<SelectedImage>() { SelectedImage.Scissors, SelectedImage.Lizard });
            // Echse frisst Papier
            // Echse vergigtet Spock
            whoWinsAgainstWho.Add(SelectedImage.Lizard, new List<SelectedImage>() { SelectedImage.Paper, SelectedImage.Spock });
            // Spock zertrümmert Schere
            // Spock verdampft Stein
            whoWinsAgainstWho.Add(SelectedImage.Spock, new List<SelectedImage>() { SelectedImage.Scissors, SelectedImage.Stone });
        }

        internal EvaluatedWinner EvaluateHumanWins(SelectedImage humanChoose, SelectedImage computerChoose)
        {
            // ToDo : Wer gewinnt gegen wen auswerten
            // HINWEIS: Vergiss nicht das Unentschieden, wenn beide dasselbe wählen.
            
            if (humanChoose == computerChoose)
            {
                return EvaluatedWinner.none;
            }

            if (whoWinsAgainstWho.ContainsKey(humanChoose))
            {
               if(whoWinsAgainstWho[humanChoose].Contains(computerChoose)) {
                    // Du hast gewonnen
                    return EvaluatedWinner.HumanPlayer;
                }
               else
                {
                    // Der Computer hat gewonnen
                    return EvaluatedWinner.ComputerPlayer;
                }
            }

            // Dies sollte nie angewendet werden müssen...
            return EvaluatedWinner.none;
        }
    }
}
