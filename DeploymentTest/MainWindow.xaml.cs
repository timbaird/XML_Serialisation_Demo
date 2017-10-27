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
using System.Xml.Serialization;

namespace DeploymentTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WidgetList widgets;

        public MainWindow()
        {
            InitializeComponent();

            string testData = DataAccesshandler.getXML();

            XmlSerializer serializer = new XmlSerializer(typeof(WidgetList));

            using (TextReader reader = new StringReader(testData))
            {
                widgets = (WidgetList)serializer.Deserialize(reader);
            }
        
        }

        private void buttonShowWidgets_Click(object sender, RoutedEventArgs e)
        {
            foreach (var w in widgets.widgets)
            {
                listWidgets.Items.Add(w);
            }
        }
    }
}
