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
            FileModel model = new FileModel();
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] Path = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                foreach (var path in Path)
                {
                    FileInfo fi = new FileInfo(path);
                    DirectoryInfo di = new DirectoryInfo(path);
                    //Wenn keine extension also == ordner
                    if (fi.Extension == "")
                    {
                       FileInfo[] info = di.GetFiles("*.*", SearchOption.AllDirectories);
                        foreach (var i in info)
                        {
                            model.Name = i.Name;
                            model.Extension = i.Extension;
                            model.Fullpath = i.FullName;
                            model.ParentDirectory = i.DirectoryName;
                        }
                    }
                    //Wenn dateien ohne übergeordneter ordner
                    else
                    {
                        model.Fullpath = fi.FullName;
                        model.Extension = fi.Extension;
                        model.Name = fi.Name;
                        model.ParentDirectory = fi.DirectoryName;
                    }
                }
                
                
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                    dialog.SelectedPath = g.App_Path;

                    g.FileSource = Path[0];
                    InputPath.Text = Path[0];

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
            process.StartInfo.Arguments = @"C:\Users\zalldani\Desktop\test.txt";
            process.EnableRaisingEvents = true;
            process.Start();
            do
            {
                if (process.HasExited)
                {
                    label.Content = "Process wurde beendet";
                }
            } while (!process.HasExited);



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
