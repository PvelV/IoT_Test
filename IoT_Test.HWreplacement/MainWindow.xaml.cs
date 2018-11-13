using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace IoT_Test.HWreplacement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HttpClient client;


        public MainWindow()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var myContent = JsonConvert.SerializeObject(new { DateTime = DateTime.Now, Value = (int)TemperatureSlider.Value });

            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            client.PostAsync(@"https://ipis2.azurewebsites.net/api/values", byteContent);
        }





    }
}
