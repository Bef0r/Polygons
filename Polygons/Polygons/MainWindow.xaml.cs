using Polygons.Business_Logics;
using Polygons.Helper;
using Polygons.Models.Polygons;
using Polygons.Models.Shapes;
using Polygons.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}
