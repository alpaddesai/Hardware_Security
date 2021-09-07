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

namespace Hardware_Security
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Nanoscale_tech_Click(object sender, RoutedEventArgs e)
        {
            NanoscaleTechnologies NanoscaleTechnologiesObject = new NanoscaleTechnologies();
            NanoscaleTechnologiesObject.Show();
        }

        private void HW_Trojan_Click(object sender, RoutedEventArgs e)
        {
            HardwareTrojan HardwareTrojanObject = new HardwareTrojan();
            HardwareTrojanObject.Show();
        }

        private void HW_Primitives_Click(object sender, RoutedEventArgs e)
        {
            HardwarePrimitives HardwarePrimitivesObject = new HardwarePrimitives();
            HardwarePrimitivesObject.Show();
        }

        private void PCB_Authentication_Click(object sender, RoutedEventArgs e)
        {
            PCBAuthentication PCBAuthenticationObject = new PCBAuthentication();
            PCBAuthenticationObject.Show();

        }

        private void RFID_Click(object sender, RoutedEventArgs e)
        {
            RFID RFIDObject = new RFID();
            RFIDObject.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HardwareSecurity HardwareSecurityObject = new HardwareSecurity();
            HardwareSecurityObject.Show();
        }
    }
}
