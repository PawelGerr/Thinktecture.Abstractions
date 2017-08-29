using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Thinktecture.Net.Http.Adapters;

// ReSharper disable PossibleNullReferenceException

namespace Thinktecture.Abstractions.Wpf.Example
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			HttpButton.IsEnabled = false;

			try
			{
				using (var client = new HttpClientAdapter())
				using (var response = client.GetAsync("https://www.thinktecture.com").GetAwaiter().GetResult())
				{
					Output.Text += $"HTTP GET https://www.thinktecture.com returned {response.StatusCode}";
				}
			}
			finally
			{
				HttpButton.IsEnabled = true;
			}
		}
	}
}
