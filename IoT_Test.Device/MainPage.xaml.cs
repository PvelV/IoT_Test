using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Gpio;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IoT_Test.Device
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

      

        private static readonly HttpClient client = new HttpClient();

        public MainPage()
        {
            this.InitializeComponent();

            var myContent = JsonConvert.SerializeObject(new { DateTime = DateTime.Now, Value = 17 });

            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            client.PostAsync(@"https://ipis2.azurewebsites.net/api/values", byteContent);

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
