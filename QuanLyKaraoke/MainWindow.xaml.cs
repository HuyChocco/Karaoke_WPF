using MaterialDesignThemes.Wpf;
using QuanLyKaraoke.ViewModel;
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
using MaterialDesignColors;
using System.Collections.ObjectModel;
using QuanLyKaraoke.Model;

namespace QuanLyKaraoke
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private ObservableCollection<Phong> _List;
		private int soLuongPhong;
		private int soLuongPhongMoiHang;
		private int soLuongHangCuoi;
		public MainWindow()
		{

			InitializeComponent();
			//Nạp dữ liệu vào List
			_List = new ObservableCollection<Phong>(DataProvider.Ins.DB.Phongs);
			soLuongPhong = _List.Count;
			soLuongPhongMoiHang = soLuongPhong / 4;
			if (soLuongPhong % 4 != 0)
				soLuongHangCuoi = soLuongPhong - 4 * soLuongPhongMoiHang;
			LoadTables();
		}
		void LoadTables()
		{
			int number=0 ;
			int row = 0;
			for (int i = 0; i < _List.Count; i++)
			{
				Card card = new Card();
				card.Width = 160;
				Thickness thicknessCard = new Thickness();
				thicknessCard.Left = 5;
				thicknessCard.Top = 5;
				thicknessCard.Right = 5;
				thicknessCard.Bottom = 5;
				card.Margin = thicknessCard;
				card.Background = (Brush)new BrushConverter().ConvertFrom("#03a9f4");
				card.Foreground = (Brush)FindResource("PrimaryHueDarkForegroundBrush");
				card.Margin = new Thickness(5);
				card.Padding = new Thickness(0);
				Grid gridCard = new Grid();
				gridCard.RowDefinitions.Add(new RowDefinition());
				gridCard.RowDefinitions.Add(new RowDefinition());
				gridCard.RowDefinitions.Add(new RowDefinition());
				Thickness thicknessText = new Thickness();
				thicknessText.Left = 16;
				thicknessText.Top = 16;
				thicknessText.Right = 16;
				thicknessText.Bottom = 4;
				TextBlock txtHead = new TextBlock();
				txtHead.Text = _List[i].soPhong;
				txtHead.Margin = thicknessText;
				txtHead.Style = (Style)FindResource("MaterialDesignHeadlineTextBlock");
				Separator separator = new Separator();
				separator.Style = (Style)FindResource("MaterialDesignLightSeparator");
				TextBlock txtStatus = new TextBlock();
				txtStatus.Text = _List[i].tinhTrang;
				txtStatus.VerticalAlignment = VerticalAlignment.Center;
				txtStatus.HorizontalAlignment = HorizontalAlignment.Left;
				txtStatus.Style = (Style)FindResource("MaterialDesignDisplay1TextBlock");
				txtStatus.Margin = new Thickness(16, 0, 16, 8);
				PopupBox popupBox = new PopupBox();
				popupBox.HorizontalAlignment = HorizontalAlignment.Right;
				popupBox.Padding = new Thickness(2, 0, 2, 0);
				StackPanel stackPanel = new StackPanel();
				Button btnPop1 = new Button();
				Button btnPop2 = new Button();
				btnPop1.Content = "ĐẶT PHÒNG";
				btnPop2.Content = "HỦY ĐẶT PHÒNG";
				btnPop1.Style = (Style)FindResource("MaterialDesignFlatButton");
				btnPop2.Style = (Style)FindResource("MaterialDesignFlatButton");
				stackPanel.Children.Add(btnPop1);
				stackPanel.Children.Add(btnPop2);
				popupBox.Content = stackPanel;
				Grid.SetRow(txtHead, 0);
				Grid.SetRow(separator, 1);
				Grid.SetRow(txtStatus, 2);
				gridCard.Children.Add(txtHead);
				gridCard.Children.Add(separator);
				gridCard.Children.Add(txtStatus);
				gridCard.Children.Add(popupBox);
				card.Content = gridCard;
				number=number+1;
				if (number <= soLuongPhongMoiHang && row == 0)
				{
					this.dockPanel1.Children.Add(card);

				}
				else if(number<= soLuongPhongMoiHang && row == 1)
				{
					this.dockPanel2.Children.Add(card);
					
				}
				else if (number <= soLuongPhongMoiHang && row == 2)
				{
					this.dockPanel3.Children.Add(card);
					
				}
				else if (number <= soLuongPhongMoiHang && row == 3)
				{
					this.dockPanel4.Children.Add(card);

				}
				if (number == soLuongPhongMoiHang)
				{
					row++;
					number = 0;
				}
			}
		}
	}
}
