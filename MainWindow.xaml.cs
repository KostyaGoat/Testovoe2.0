using System;
using System.IO;
using System.Reflection.Metadata;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using Testovoe2._0.Models;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Testovoe2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DbHelper.DeletеDb();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Channel));
            var path = @"D:\testapppp\data.xml";
            StreamReader reader = new StreamReader(path);
            var Channel = (Channel)serializer.Deserialize(reader);
            reader.Close();
            DbHelper.AddToDb(Channel);
            // XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(path);
            try
            {
                Application application = new Application();

                Document docWord = application.Documents.Add(Visible: true);

                Range range = docWord.Range();

                range.Text = xmlDoc.InnerText;

                docWord.Save();

                try
                {
                    docWord.Close();
                    application.Quit(); 
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить файл.");
                }
            }
            catch
            {
                MessageBox.Show("Не удалось извлечь и сохранить файл");
            }
        }
    }
}
