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
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture.Abstractions.Wpf.Example
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			httpButton.IsEnabled = false;

			try
			{
				using (var client = new HttpClientAdapter())
				using (var response = client.GetAsync("https://www.thinktecture.com").GetAwaiter().GetResult())
				{
					output.Text += $"HTTP GET https://www.thinktecture.com returned {response.StatusCode}";
				}
			}
			finally
			{
				httpButton.IsEnabled = true;
			}
		}
	}
}