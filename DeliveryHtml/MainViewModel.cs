﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeliveryHtml
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public MainViewModel()
		{
			SetText();
		}

		private async void SetText()
		{
			await Task.Delay(2000);

			string url = "https://www.google.com";
			Message = $"<center><h1>Lorem ipsum dolor sit amet consectetuer adipiscing elit</h1></center> <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa <strong>strong</strong>. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede <a href=\"{url}\">link</a> mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi.</p> <center><h1>Lorem ipsum dolor sit amet consectetuer adipiscing elit</h1></center> <h2>Aenean commodo ligula eget dolor aenean massa</h2> <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.</p> <h2>Aenean commodo ligula eget dolor aenean massa</h2> <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.</p>";
		}

		string _message;
		public string Message {
			get => _message;
			set {
				_message = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Message)));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}