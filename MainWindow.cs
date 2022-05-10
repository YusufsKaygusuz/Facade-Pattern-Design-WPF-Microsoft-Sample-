// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows;

namespace VisibiltyChanges
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        class ContentCreat
        {
            //public object tb { get; set; }
            //public object txt { get; set; }

            public string cntCreat()
            {
                string txt = "Visibility is now set to Visible.";
                return txt;
            }

        }

        class contentHid
        {
            public string cntHid()
            {
                string txt = "Visibility is now set to Hidden. Notice that the TextBox still occupies layout space.";
                return txt;
            }

        }

        class contentCol
        {
            public string cntCol()
            {
                string txt = "Visibility is now set to Collapsed. Notice that the TextBox no longer occupies layout space.";
                return txt;
            }
        }


        class FacadeProducer
        {
            ContentCreat cntntCrt = new ContentCreat();
            contentHid cntntHd = new contentHid();
            contentCol cntntcl = new contentCol();

            public string producer_cntnCrt()
            {
                string cntCRT = cntntCrt.cntCreat();
                return cntCRT;
            }

            public string producer_cntHd()
            {
                string cntHD = cntntHd.cntHid();
                return cntHD;
            }

            public string producer_cntCol()
            {
                string cntCOL = cntntcl.cntCol();
                return cntCOL;
            }

        }


        FacadeProducer producer;
        private void CreaterMethod(object sender, RoutedEventArgs e)
        {
            producer = new FacadeProducer();
        }

        private void ContentVis(object sender, RoutedEventArgs e)
        {
            tb1.Visibility = Visibility.Visible;
            txt1.Text = producer.producer_cntCol();
        }

        private void ContentHid(object sender, RoutedEventArgs e)
        {
            tb1.Visibility = Visibility.Hidden;
            txt1.Text = producer.producer_cntHd();
        }

        private void ContentCol(object sender, RoutedEventArgs e)
        {
            tb1.Visibility = Visibility.Collapsed;
            txt1.Text = producer.producer_cntCol();
        }


        #region oldCodes
        /*
        private void ContentVis(object sender, RoutedEventArgs e)
        {
            tb1.Visibility = Visibility.Visible;
            txt1.Text = "Visibility is now set to Visible.";
        }
        
        private void ContentHid(object sender, RoutedEventArgs e)
        {
            tb1.Visibility = Visibility.Hidden;
            txt1.Text = "Visibility is now set to Hidden. Notice that the TextBox still occupies layout space.";
        }

        private void ContentCol(object sender, RoutedEventArgs e)
        {
            tb1.Visibility = Visibility.Collapsed;
            txt1.Text = "Visibility is now set to Collapsed. Notice that the TextBox no longer occupies layout space.";
        }
        */
        #endregion
    }
}