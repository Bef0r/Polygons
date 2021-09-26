using Polygons.Business_Logics;
using Polygons.Helper;
using Polygons.Models;
using Polygons.Models.Polygons;
using Polygons.ViewModels;
using System;
using System.Windows;

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
                CanvasViewModel canvasViewmodel = commands.generateNewPolygon(new NewPolygonParameters(Convert.ToInt32(this.myCanvas.ActualWidth), Convert.ToInt32(this.myCanvas.ActualHeight), Convert.ToInt32(polygonVertexTextBox.Text))); ;
                this.myCanvas.Children.Add(canvasViewmodel.myCanvas);
            }
            else
            {
                showInputErrorTextOnUI();
            }
        }

        private void showInputErrorTextOnUI()
        {
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


    }
}
