using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Timers;

namespace MinePoS
{
	public partial class SplashPage : ContentPage
	{
		public SplashPage()
		{
			InitializeComponent();
            // this.countLabel.Text = "0";
            DelayActionAsync(5000, RunEverySecond);
        }

       
        private void RunEverySecond() {
           

        }

        public async Task DelayActionAsync(int delay, Action action)
        {

            await Task.Delay(delay);
            action();
        }
    }
}
