using System;
using System.ComponentModel;

namespace SUMALI.TUT.ScissorsStonePaper.Model
{
    public sealed class MainWindowModel : INotifyPropertyChanged
    {

        #region Attributes and Propertys
        private string humanPlayerName;
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

        #endregion

        #region Constructor
        internal MainWindowModel()
        {
            InitModelView();
        }
        #endregion

        private void InitModelView()
        {
            //ComputerPlayerName = 
        }


        private void ShowMessage(string message)
        {
            //ShowMessageText += message;
            //ShowMessageText += Environment.NewLine;
        }

        #region Property Changed Handler
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}