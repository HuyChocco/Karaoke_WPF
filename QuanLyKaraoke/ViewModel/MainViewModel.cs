﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKaraoke.ViewModel
{
    public class MainViewModel
    {
		public bool Isloaded = false;
		public ICommand LoadedWindowCommand { get; set; }
		public MainViewModel()
		{
			LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
			{
				Isloaded = true;
				if (p == null)
					return;
				p.Hide();
				LoginWindow loginWindow = new LoginWindow();
				loginWindow.ShowDialog();

				if (loginWindow.DataContext == null)
					return;
				var loginVM = loginWindow.DataContext as LoginViewModel;

				if (loginVM.IsLogin)
				{
					p.Show();
					//LoadTonKhoData();
				}
				else
				{
					p.Close();
				}
			}
			);
		}
    }
}
