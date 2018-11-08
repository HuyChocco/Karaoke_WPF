using System;
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
		public ICommand SanPhamCommand { get; set; }
		public MainViewModel()
		{
			//Xử lý sư kiện loaded window
			LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
			{
				Isloaded = true;
				if (p == null)
					return;
				p.Hide();
				//Hiển thị form đăng nhập
				LoginWindow loginWindow = new LoginWindow();
				loginWindow.ShowDialog();

				if (loginWindow.DataContext == null)
					return;
				var loginVM = loginWindow.DataContext as LoginViewModel;

				if (loginVM.IsLogin)
				{
					//Đăng nhập thành công thì hiển thị màn hình chính
					p.Show();
					//LoadTonKhoData();
				}
				else
				{
					p.Close();
				}
			}
			);

			SanPhamCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
			{
				//Hiển thị màn hình nhập liệu sản phẩm
				SanPhamWindow sanPhamWindow = new SanPhamWindow();
				sanPhamWindow.ShowDialog();

				if (sanPhamWindow.DataContext == null)
					return;
				
			}
			);
		}
    }
}
