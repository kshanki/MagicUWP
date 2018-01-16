using InputBox;
using MagicUWP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238
/*
 * MVP
 * MainPage.xaml.cs:
 * Code contains methods to initiate the process by calling the async task(not on the UI thread)
 * By Beloved Egbedion
 * For Dr. Russell Thackston
 * MAGIC Project
 * 10/21/2017
*/


namespace InputBox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContentDialog1 : ContentDialog
    {
      
        public ContentDialog1()
        {
            this.InitializeComponent();

            
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
           
        }

        private async void ContentDialog_SecondaryButtonClick(object sender, ContentDialogButtonClickEventArgs args)
        {
            MessageDialog message = new MessageDialog(AccessKey.Text + "###" + SecretKey.Text);
            message.ShowAsync();
            
        }
    }
}
        
    

