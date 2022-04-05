using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace ftcaculator
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string precaculate;
        bool _ifinsertedsymbol=false ;
        string precaculate2;
        string insertedsymbol;
        decimal result;

        public MainPage()
        {
            this.InitializeComponent();

        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            if (_ifinsertedsymbol = true)
            {
                precaculate2 = precaculate2 + "1";
                resultBlk.Text = precaculate2;
            }
            else 
            {
                if (resultBlk.Text == "0")
                {
                    precaculate = "1";
                    resultBlk.Text = precaculate;
                }
                else
                {
                    precaculate = precaculate + "1";
                    resultBlk.Text = precaculate;
                }
            }
           
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "2";
                resultBlk.Text =precaculate;
            }
            else
            {
                precaculate =precaculate + "2";
                resultBlk .Text = precaculate;
            }
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "3";
                resultBlk .Text =precaculate;
            }
            else
            {
                precaculate = precaculate + "3";
                resultBlk .Text =precaculate;
            }
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "4";
                resultBlk.Text = precaculate;

            }
            else
            {
                precaculate = precaculate + "4";
                resultBlk .Text =precaculate;

            }
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "5";
                resultBlk.Text = precaculate;

            }
            else
            {
                precaculate = precaculate + "5";
                resultBlk.Text = precaculate;

            }
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "6";
                resultBlk.Text = precaculate;
            }
            else
            { 
                precaculate = precaculate + "6";
                resultBlk .Text =precaculate;
            }
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "7";
                resultBlk.Text = precaculate;
            }
            else
            {
                precaculate = precaculate + "7";
                resultBlk.Text = precaculate;
            }
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "8";
                resultBlk.Text = precaculate;
            }
            else
            {
                precaculate = precaculate + "8";
                resultBlk .Text =precaculate;

            }
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "9";
                resultBlk.Text = precaculate;
            }
            else
            {
                precaculate = precaculate + "9";
                resultBlk.Text = precaculate;
            }
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            if (resultBlk.Text == "0")
            {
                precaculate = "0";
                resultBlk.Text = precaculate;
            }
            else
            {
                precaculate =precaculate + "0";
                resultBlk .Text =precaculate;
            }
        }

        private void and_Click(object sender, RoutedEventArgs e)
        {
            insertedsymbol = "and";
            _ifinsertedsymbol = true;

        }

        private void caculateBt_Click(object sender, RoutedEventArgs e)
        {
            if (_ifinsertedsymbol = false)
            {

            }
            else
            {
                if (insertedsymbol == "and")
                {
                    result = Convert .ToDecimal(precaculate)+Convert .ToDecimal(precaculate2);
                    resultBlk.Text = result.ToString ();
                }
            }
        }
    }
}
