using Newtonsoft.Json;
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
using TestDataClass1;
namespace WpfAppDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataList1 obj1 = new DataList1(true);
        private object serializer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, RoutedEventArgs e)
        {
            //var obj1 = new DataList1(this.chk1.IsChecked==true);
            //obj1.getemployee();
            this.DataGrid1.ItemsSource = this.obj1.employeeinfos;
            //this.DataGrid1.ItemsSource = (new DataList1(this.chk1.IsChecked == true)).employeeinfos;
           
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {

            string strserialize = JsonConvert.SerializeObject(this.obj1.employeeinfos);
            //string json = JsonSerializer.Serialize(strserialize);
            File.WriteAllText(@"D:\Oficce\Projects\XMLWRITEFILE\TestClass1\WpfAppDataGrid\bin\Debug\Test.json", strserialize);
            // XmlSerializer serialiser = new XmlSerializer(typeof(List<TestClass1.Company.employeeinfo>));
            //var json = JsonSerializer.Serialize(aList);
            // // Create the TextWriter for the serialiser to use

            // FileStream fileStream = File.Create(@"D:\path.json");
            // // JsonSerializer.SerializeAsync(createStream, _data);



            // TextWriter filestream = new StreamWriter("Saki1b.Json");

            // //write to the file
            //// serialiser.Serialize(filestream, this.obj1.employeeinfos);

            // // Close the file
            // filestream.Close();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {


            var jsonString = File.ReadAllText(@"D:\Oficce\Projects\XMLWRITEFILE\TestClass1\WpfAppDataGrid\bin\Debug\Test.json");

            this.obj1.employeeinfos= JsonConvert.DeserializeObject<List<TestClass1.Company.employeeinfo>>(jsonString);

            ////this.DataGrid1.ItemsSource = null;
            ////XmlSerializer serializer = new XmlSerializer(typeof(List<TestClass1.Company.employeeinfo>));
            ////using (FileStream stream = File.OpenRead("sakib.xml"))
            ////{
            ////    this.obj1.employeeinfos = (List<TestClass1.Company.employeeinfo>)serializer.Deserialize(stream);
            ////}
            this.DataGrid1.ItemsSource = this.obj1.employeeinfos;



            //this.DataGrid1.ItemsSource = null;
            //var xmlString = File.ReadAllText("emplist.xml");
            //var stringReader = new StringReader(xmlString);
            //var dsSet = new System.Data.DataSet();
            //dsSet.ReadXml(stringReader);
            //this.DataGrid1.ItemsSource = dsSet.Tables[0].DefaultView;

        }
    }
}
