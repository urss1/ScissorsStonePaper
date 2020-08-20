using SUMALI.TUT.ScissorsStonePaper.Controller;
using SUMALI.TUT.ScissorsStonePaper.Enums;
using SUMALI.TUT.ScissorsStonePaper.Properties;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace SUMALI.TUT.ScissorsStonePaper.Model
{
    public sealed class MainWindowModel : INotifyPropertyChanged
    {

        #region Attributes and Propertys
        /// <summary>
        /// Kontroller für die Auswertung und Berechnung des Gewinners
        /// </summary>
        private EvaluateWinnerController evaluateWinnerController;

        private string humanPlayerName;
        /// <summary>
        /// Name des Spielers (also Du)
        /// </summary>
        public string HumanPlayerName
        {
            get
            {
                return humanPlayerName;
            }
            set
            {
                if (humanPlayerName != value)
                {
                    humanPlayerName = value;
                    OnPropertyChanged();
                }
            }
        }

        private string computerPlayerName;
        /// <summary>
        /// Name des Computer-Spielers (also Dein Gegner)
        /// </summary>
        public string ComputerPlayerName
        {
            get
            {
                return computerPlayerName;
            }
            set
            {
                if (computerPlayerName != value)
                {
                    computerPlayerName = value;
                    OnPropertyChanged();
                }
            }
        }

        private SelectedImage humanPlayerChoose;
        /// <summary>
        /// Gewähltes Symbol (Schere, Stein ...) des Spielers
        /// </summary>
        public SelectedImage HumanPlayerChoose
        {
            get
            {
                return humanPlayerChoose;
            }
            set
            {
                if (humanPlayerChoose != value)
                {
                    humanPlayerChoose = value;
                    OnPropertyChanged();
                }
            }
        }

        private SelectedImage computerPlayerChoose;
        /// <summary>
        /// Gewähltes Symbol (Schere, Stein ...) des Computers
        /// </summary>
        public SelectedImage ComputerPlayerChoose
        {
            get
            {
                return computerPlayerChoose;
            }
            set
            {
                if (computerPlayerChoose != value)
                {
                    computerPlayerChoose = value;
                    OnPropertyChanged();
                }
            }
        }

        #region Result/Statistic
        private int roundCounter = 0;
        /// <summary>
        /// Anzahl gespielte Runden (Rundenanzahl)
        /// </summary>
        public int RoundCounter
        {
            get
            {
                return roundCounter;
            }
            set
            {
                if (roundCounter != value)
                {
                    roundCounter = value;
                    OnPropertyChanged();
                }
            }
        }

        private int humanPlayerWinsCounter = 0;
        /// <summary>
        /// Anzahl gewinne vom Spieler (Deine Gewinne)
        /// </summary>
        public int HumanPlayerWinsCounter
        {
            get
            {
                return humanPlayerWinsCounter;
            }
            set
            {
                if (humanPlayerWinsCounter != value)
                {
                    humanPlayerWinsCounter = value;
                    OnPropertyChanged();
                }
            }
        }

        private int computerPlayerWinsCounter = 0;
        /// <summary>
        /// Anzahl gewinne vom Computer
        /// </summary>
        public int ComputerPlayerWinsCounter
        {
            get
            {
                return computerPlayerWinsCounter;
            }
            set
            {
                if (computerPlayerWinsCounter != value)
                {
                    computerPlayerWinsCounter = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        private bool isNewGame;
        /// <summary>
        /// Ist neues Spiel:
        /// TRUE = Bilder (Schere, Stein, Papier) sind aktiv, Button "neues spiel" ist deaktiviert
        /// FALSE = Bilder sind nicht aktiv, Button "neues spiel" ist aktiviert...
        /// </summary>
        public bool IsNewGame
        {
            get
            {
                return isNewGame;
            }
            set
            {
                if (isNewGame != value)
                {
                    isNewGame = value;
                    OnPropertyChanged();
                }
            }
        }


        private string showMessageText = String.Empty;
        /// <summary>
        /// Text für die Anzeige in der BOX Systemmeldungen
        /// </summary>
        public string ShowMessageText
        {
            get
            {
                return showMessageText;
            }
            set
            {
                showMessageText = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructor
        internal MainWindowModel()
        {
            InitModelView();
        }

        private void InitModelView()
        {
            evaluateWinnerController = new EvaluateWinnerController();
            IsNewGame = true;
            ComputerPlayerName = Resources.ComputerPlayerName;

            ResetImages();
        }
        #endregion

        #region Play Round
        /// <summary>
        /// Funktion für das Auswählen und starten der Computer auswahl.
        /// Bilder müssen korrekt gesetzt werden, Coumptuter muss auswählen und die Auswahl anzeigen.
        /// Resultat muss ausgewertet werden und auf der Liste angezeigt werden (wer gewinnt)
        /// </summary>
        internal async void Play(SelectedImage selectedImageHumanPlayer)
        {
            // ToDo: Setzte neues Spiel auf den korrekten Wert für die Anzeige
            // ToDo: Setzte die Auswahl für den Spieler
            IsNewGame = false;

            // ToDo: Erstelle eine Schalufe mit 4 Anzeigen
            for (int i = 0; i < 5; i++)
            {
                ComputerPlayerChoose = (SelectedImage)new Random().Next(0, 5);
                HumanPlayerChoose = ComputerPlayerChoose;
                await Task.Run(() => Thread.Sleep(500));
            }
            // 5. Anzeige = Spielresultat
            HumanPlayerChoose = selectedImageHumanPlayer;
            // Zufallsgenerator für die Auswahl vom Computer
            ComputerPlayerChoose = (SelectedImage)new Random().Next(0, 5);

            // ToDo: Ermittle den Gewinner
            // Tipp: Verwende ein Switch-Case
            switch (evaluateWinnerController.EvaluateHumanWins(HumanPlayerChoose, ComputerPlayerChoose))
            {
                case EvaluatedWinner.HumanPlayer:
                    SetHumanPlayerAsWinner();
                    break;
                case EvaluatedWinner.ComputerPlayer:
                    SetComputerPlayerAsWinner();
                    break;
                default:
                    SetNoneAsWinner();
                    break;
            }           
        }

        #endregion

        #region Set Winner
        /// <summary>
        /// Setzt den Spieler als Gewinner (also Du gewinnst)
        /// </summary>
        private void SetHumanPlayerAsWinner()
        {
            // ToDo : Infos ausgeben (Tipp nutze die Methode ShowWinnerInfo)
            // Zähle die "Counters" hoch (Gewinner und Rundenanzahl)
            ShowWinnerInfo(HumanPlayerName);
            RoundCounter++;
            HumanPlayerWinsCounter++;
        }

        /// <summary>
        /// Setzt den Computer als Gewinner (Dein Gegner hat gewonnen)
        /// </summary>
        private void SetComputerPlayerAsWinner()
        {
            // ToDo: Infos ausgeben und Zähler hochzählen
            ShowWinnerInfo(ComputerPlayerName);
            RoundCounter++;
            ComputerPlayerWinsCounter++;
        }

        private void SetNoneAsWinner()
        {
            ShowNoneWinnerInfo();
            RoundCounter++;
        }
        #endregion

        #region Start new Game
        /// <summary>
        /// Funktion für starten eines neuen Spiels.
        /// Alle Bilder müssen zurückgesetzt werden und die entsprechenden Schaltflächen aktiviert/deaktiviert werden.
        /// </summary>
        internal void NewGame()
        {
            ShowNewGameInfo();
            ResetImages();
            IsNewGame = true;
        }
        #endregion

        #region Reset Images
        /// <summary>
        /// Setzt die Bilder zurück. Es werden keine Bilder mehr angezeigt.
        /// Dies wird für ein neues Spiel verwendet.
        /// </summary>
        private void ResetImages()
        {
            HumanPlayerChoose = SelectedImage.none;
            ComputerPlayerChoose = SelectedImage.none;
        } 
        #endregion

        #region Show Messages
        /// <summary>
        /// 
        /// </summary>
        private void ShowNewGameInfo()
        {
            ShowMessage("Neues Spiel wurde gestartet.");
            ShowMessage("Wähle Schere, Stein oder Papier aus...");
        }

        private void ShowWinnerInfo(string winnerName)
        {
            ShowMessage($"{winnerName} hat das Spiel gewonnen.");
        }

        private void ShowNoneWinnerInfo()
        {
            ShowMessage("Leider hat keiner gewonnen...");
        }

        private void ShowMessage(string message)
        {
            ShowMessageText += message;
            ShowMessageText += Environment.NewLine;
        }
        #endregion

        #region Property Changed Handler
        /// <summary>
        /// Benachrichtig die Oberfläche, wenn es neue oder geänderte Werte hat um diese wieder anzuzeigen.
        /// Dieser Teil sollte nicht geändert werden...
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}