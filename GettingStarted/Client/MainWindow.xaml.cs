using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Discovery;
using GettingStartedLib;
using System.ServiceModel;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Start();

        }

        public void Start()
        {
            WcfTestClient_SetupChannel();
            string result = WcfTestClient_Ping();
            tbSomething.Text = result;
        }

        private static IWcfPingTest channel;

        public static Uri WcfTestClient_DiscoverChannel()
        {
            var dc = new DiscoveryClient(new UdpDiscoveryEndpoint());
            FindCriteria fc = new FindCriteria(typeof(IWcfPingTest));
            fc.Duration = TimeSpan.FromSeconds(5);
            FindResponse fr = dc.Find(fc);
            foreach (EndpointDiscoveryMetadata edm in fr.Endpoints)
            {
                Console.WriteLine("uri found = " + edm.Address.Uri.ToString());
            }
            return fr.Endpoints[0].Address.Uri;
        }

        public static string WcfTestClient_SetupChannel()
        {
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            var factory = new ChannelFactory<IWcfPingTest>(binding);
            var uri = WcfTestClient_DiscoverChannel();
            Console.WriteLine("creating channel to " + uri.ToString());
            EndpointAddress ea = new EndpointAddress(uri);
            channel = factory.CreateChannel(ea);
            string result = channel.Ping();
            return result;
        }

        public static string WcfTestClient_Ping()
        {
            Console.WriteLine("pinging host");
            string result = channel.Ping();
            return result;
        }

    }
}
