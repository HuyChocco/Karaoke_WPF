using QuanLyKaraoke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKaraoke.ViewModel
{
    public class LoginViewModel:BaseViewModel
    {
		public bool IsLogin { get; set; }
		private string _UserName;
		public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
		private string _Password;
		public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

		public ICommand CloseCommand { get; set; }
		public ICommand LoginCommand { get; set; }
		public ICommand PasswordChangedCommand { get; set; }
		// mọi thứ xử lý sẽ nằm trong này
		public LoginViewModel()
		{
			IsLogin = false;
			Password = "";
			UserName = "";
			LoginCommand = new RelayCommand<Window>((p) => { return UserName == null ? false : true; }, (p) => { Login(p); });
			CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close(); });
			PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
		}

		void Login(Window p)
		{
			if (p == null)
				return;
			string passEncode = MD5Hash(Base64Encode(Password));//Mã hóa bằng MD5
			//var accCount=DataProvider.Ins.DB.Accounts.Where(x => x.UserName == UserName && x.PassWord == passEncode).Count();

			//Khởi tạo danh sách tài khoản từ cơ sở dữ liệu
			List<USP_Login_Result> listAccount =new List<USP_Login_Result> (DataProvider.Ins.DB.USP_Login(UserName, passEncode));

			if (listAccount.Count > 0)
			{
				IsLogin = true;

				p.Close();
			}
			else
			{
				IsLogin = false;
				MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
			}
		}
		//Hàm mã hóa password bằng Base64
		public static string Base64Encode(string plainText)
		{
			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
			return System.Convert.ToBase64String(plainTextBytes);
		}


		//Hàm mã hóa password bằng MD5 từ Base64
		public static string MD5Hash(string input)
		{
			StringBuilder hash = new StringBuilder();
			MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
			byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

			for (int i = 0; i < bytes.Length; i++)
			{
				hash.Append(bytes[i].ToString("x2"));
			}
			return hash.ToString();
		}


	}
}

