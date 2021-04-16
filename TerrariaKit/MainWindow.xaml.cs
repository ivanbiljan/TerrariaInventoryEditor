using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using TerrariaKit.Services;

namespace TerrariaKit {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void LoadFileButton_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments,
                    Environment.SpecialFolderOption.None),
                Filter = "Terraria Player Files (*.plr)|*.plr"
            };

            if (openFileDialog.ShowDialog() != true)
            {
                return;
            }

            // TODO: set up DI
            var playerFileService = new PlayerFileService(new LocalizationService());
            var playerFile = playerFileService.Read(openFileDialog.FileName);
            
        }
    }
}