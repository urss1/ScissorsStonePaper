using SUMALI.TUT.ScissorsStonePaper;
using SUMALI.TUT.ScissorsStonePaper.Controller;
using SUMALI.TUT.ScissorsStonePaper.Model;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using AppResources = SUMALI.TUT.ScissorsStonePaper.Properties.Resources;

namespace SUMALI.TUT.ScissorsStonePaper
{
    /// <summary>
    /// Klasse für das Fenster (Window).
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowModel mainWindowModel;
        
        #region Constructor

        public MainWindow()
        {
            InitializeComponent();

            // Create and Show Infos on Windows
            WindowTitleLabel.Content = AppResources.genModulName;
            InfoVersionLabel.Content = GetAssemblyVersionString();

            // Inti Data-Contex
            mainWindowModel = new MainWindowModel();
            DataContext = mainWindowModel;
        }

        #endregion Constructor

        #region Window Events (Close, Minimized, Drag)

        // Close Window
        private void MainWindow_Close(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
            base.OnClosed(e);
        }

        // Minimize Window
        private void MainWindow_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        // Drag Window (relocate)
        private void MainWindow_Drag(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        #endregion Window Events (Close, Minimized, Drag)

        #region Get Assembly-Version

        // Return the actual version from EXE to Display in Form
        internal string GetAssemblyVersionString()
        {
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            return String.Format("Version: {0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

        #endregion Get Assembly-Version

        #region Events for Images and Buttons
        private void CutImage_Click(object sender, MouseButtonEventArgs e)
        {
            mainWindowModel.Play(Enums.SelectedImage.Scissors);
        }

        private void StoneImage_Click(object sender, MouseButtonEventArgs e)
        {
            mainWindowModel.Play(Enums.SelectedImage.Stone);
        }

        private void PaperImage_Click(object sender, MouseButtonEventArgs e)
        {
            mainWindowModel.Play(Enums.SelectedImage.Paper);
        }

        private void LizardImage_Click(object sender, MouseButtonEventArgs e)
        {
            mainWindowModel.Play(Enums.SelectedImage.Lizard);
        }

        private void SpockImage_Click(object sender, MouseButtonEventArgs e)
        {
            mainWindowModel.Play(Enums.SelectedImage.Spock);
        }

        private void StartNewGame_Click(object sender, RoutedEventArgs e)
        {
            mainWindowModel.NewGame();
        }
        #endregion

        #region ScrollViewer Event - Scroll to end when Content Changed
        private void ContentScrollViewer_Changed(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            LogMessagesScrollViewer.ScrollToEnd();
        }

        #endregion

    }
}