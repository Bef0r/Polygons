using Polygons.Business_Logics;
using Polygons.Helper;
using Polygons.Models;
using Polygons.Models.Polygons;
using Polygons.ViewModels;
using System;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Polygons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IUICommands commands;
        public MainWindow()
        {
            InitializeComponent();
            commands = new UICommandsImp();
            setupMainWindowSettings();
        }

        private void DrawPolygonButton_Click(object sender, RoutedEventArgs e)
        {
            if (InputChecker.NumberOfVerticesOfPolygonChecker(polygonVertexTextBox.Text))
            {
                clearInputErrorTextOnUI();
                CanvasViewModel canvasViewmodel = commands.generateNewPolygon(new NewPolygonParameters(Converter.doubleToInteger(this.myCanvas.ActualWidth), Converter.doubleToInteger(this.myCanvas.ActualHeight), Converter.stringToInteger(polygonVertexTextBox.Text))); ;
                this.myCanvas.Children.Add(canvasViewmodel.myCanvas);
            }
            else
            {
                showInputErrorTextOnUI();
            }
        }

        private void showInputErrorTextOnUI()
        {
            this.MainWindowErrorLabel.Foreground = Brushes.Red;
            this.MainWindowErrorLabel.Text = Polygons.Resources.MainWindowStrings.InvalidInputFromMainWindow;
        }

        private void clearInputErrorTextOnUI()
        {
            if (this.MainWindowErrorLabel.Text != "")
            {
                this.MainWindowErrorLabel.Text = "";
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            MainWindowSettings mainWindowSettings = new MainWindowSettings(Convert.ToInt32(this.myCanvas.ActualHeight), Convert.ToInt32(this.myCanvas.ActualWidth), isWindowFullScreen());
            commands.saveMainWindowSettings(mainWindowSettings);
        }

        protected Boolean isWindowFullScreen()
        {
            return this.WindowState == WindowState.Maximized ? true : false;
        }

        protected void setupMainWindowSettings()
        {
            MainWindowSettings mainWindowSettings = commands.loadMainWindowSettings();
            if (mainWindowSettings != null)
            {
                setupMainWindowParameters(mainWindowSettings);
            }
        }

        private void setupMainWindowParameters(MainWindowSettings mainWindowSettings)
        {
            if (mainWindowSettings.fullScreen == true)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.Width = mainWindowSettings.width;
                this.Height = mainWindowSettings.height;
            }
        }

        private void storageButton_Click(object sender, RoutedEventArgs e)
        {
            if (commands.storageData())
            {
                this.MainWindowErrorLabel.Foreground = Brushes.Green;
                this.MainWindowErrorLabel.Text = Polygons.Resources.MainWindowStrings.DatabaseSaveSuccessful;
            }
            else
            {
                this.MainWindowErrorLabel.Foreground = Brushes.Red;
                this.MainWindowErrorLabel.Text = Polygons.Resources.MainWindowStrings.DatabaseSaveFail;
            }

            StringBuilder stringBuilder = new StringBuilder(this.MainWindowErrorLabel.Text);
            stringBuilder.Append('\n');
            if (commands.saveDistrictOfPolygonsAndNumberOfVerticesOfPolygons())
            {
                this.MainWindowErrorLabel.Foreground = Brushes.Green;
                stringBuilder.Append(Polygons.Resources.MainWindowStrings.FileWriteSuccessful);
                this.MainWindowErrorLabel.Text = stringBuilder.ToString();
            }
            else
            {
                this.MainWindowErrorLabel.Foreground = Brushes.Red;
                stringBuilder.Append(Polygons.Resources.MainWindowStrings.FileWriteSuccessful);
                this.MainWindowErrorLabel.Text = stringBuilder.ToString();
            }
        }
    }
}
