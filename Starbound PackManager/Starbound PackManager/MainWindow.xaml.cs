using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Starbound_PackManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle.Background = new SolidColorBrush(Color.FromRgb(226, 226, 226));

        }

        private void Rectangle_Drop(object sender, DragEventArgs e)
        {
            Global g = new Global();
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                foreach (var path in files)
                {
                    FileInfo fi = new FileInfo(path);

                }
                
                string source = files[0];
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                    dialog.SelectedPath = g.App_Path;

                    InputPath.Text = files[0];

                    g.FileDestinaton = dialog.SelectedPath;
                    OutputPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void Unpack_Click(object sender, RoutedEventArgs e)
        {
            Global g = new Global();
           
            Process process = new Process();
            process.StartInfo.FileName = "notepad.exe";
            process.StartInfo.WorkingDirectory = @"c:\temp";
            process.StartInfo.Arguments = @"C:\Users\Zassi\Desktop\Neuer Ordner (2)";
            process.EnableRaisingEvents = true;
            process.Start();
            if (process.HasExited)
            {
                //do something
            }


        }

        private void Rectangle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
                var listbox = sender as ListBox;
                listbox.Background = new SolidColorBrush(Color.FromRgb(155, 155, 155));
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void Rectangle_DragLeave(object sender, DragEventArgs e)
        {
            var listbox = sender as ListBox;
            listbox.Background = new SolidColorBrush(Color.FromRgb(226, 226, 226));
        }
    }
}
