using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using QuanLyKaraoke.Model;

namespace QuanLyKaraoke.ViewModel
{
    public class PhongViewModel:BaseViewModel
    {
		//Datasource của Listview
		private ObservableCollection<Phong> _List;
		public ObservableCollection<Phong> List { get { return _List; } set { _List = value; OnPropertyChanged(); } }
		//Datasource của Combobox
		private ObservableCollection<LoaiPhong> _ListCombo;
		public ObservableCollection<LoaiPhong> ListCombo { get { return _ListCombo; } set { _ListCombo = value; OnPropertyChanged(); } }
		private string _SoPhong;
		public string SoPhong { get { return _SoPhong; } set { _SoPhong = value; OnPropertyChanged(); } }
		private int? _MaLoai;
		public int? MaLoai { get { return _MaLoai; } set { _MaLoai = value; OnPropertyChanged(); } }
		private int? _MaLoaiPhong;
		public int? MaLoaiPhong { get { return _MaLoaiPhong; } set { _MaLoaiPhong = value; OnPropertyChanged(); } }
		private string _TenLoaiPhong;
		public string TenLoaiPhong { get { return _TenLoaiPhong; } set { _TenLoaiPhong = value; OnPropertyChanged(); } }
		private string _TinhTrang;
		public string TinhTrang { get { return _TinhTrang; } set { _TinhTrang = value; OnPropertyChanged(); } }
		private Double _GiaPhongSang;
		public Double GiaPhongSang { get { return _GiaPhongSang; } set { _GiaPhongSang = value; OnPropertyChanged(); } }
		private Double _GiaPhongToi;
		public Double GiaPhongToi { get { return _GiaPhongToi; } set { _GiaPhongToi = value; OnPropertyChanged(); } }

		private Phong _SelectedItem;
		private LoaiPhong _SelectedItemLoaiPhong;

		public Phong SelectedItem
		{
			get { return _SelectedItem; }
			set
			{
				_SelectedItem = value;
				OnPropertyChanged();
				if (SelectedItem != null)
				{
					SoPhong = SelectedItem.soPhong;
					MaLoai = SelectedItem.maLoai;
					TinhTrang = SelectedItem.tinhTrang;
					LayLoaiPhongTheoPhong();
				}
			}
		}
		public void LayLoaiPhongTheoPhong()
		{
			LoaiPhong lp= (LoaiPhong)DataProvider.Ins.DB.LoaiPhongs.Where(x => x.maLoaiPhong == MaLoai).SingleOrDefault();
			SelectedItemLoaiPhong = lp;
		}
		public LoaiPhong SelectedItemLoaiPhong
		{
			get { return _SelectedItemLoaiPhong; }
			set
			{
				_SelectedItemLoaiPhong = value;
				OnPropertyChanged();
				if (SelectedItemLoaiPhong != null)
				{

					MaLoaiPhong = SelectedItemLoaiPhong.maLoaiPhong;
					TenLoaiPhong = SelectedItemLoaiPhong.tenLoaiPhong;
					GiaPhongSang =(Double) SelectedItemLoaiPhong.giaPhongSang;
					GiaPhongToi = (Double)SelectedItemLoaiPhong.giaPhongToi;
				}
			}
		}


		//Các binded command
		public ICommand AddCommand { get; set; }
		public ICommand EditCommand { get; set; }

		//Constructor
		public PhongViewModel()
		{
			//Nạp dữ liệu vào ListView và Combobox loại phòng
			List = new ObservableCollection<Phong>(DataProvider.Ins.DB.Phongs);
			ListCombo = new ObservableCollection<LoaiPhong>(DataProvider.Ins.DB.LoaiPhongs);
			//Mặc định 
			SelectedItem = List[0];
			//Cài đặt AddCommand
			AddCommand = new RelayCommand<object>((p) =>
			{
			if (string.IsNullOrEmpty(SoPhong) || string.IsNullOrEmpty(MaLoai.ToString()))
					return false;

				var displayList = DataProvider.Ins.DB.Phongs.Where(x => x.soPhong == SoPhong);
				if (displayList == null || displayList.Count() != 0)
					return false;

				return true;

			}, (p) =>
			{
				var phong = new Phong() { soPhong = SoPhong,maLoai=MaLoai,tinhTrang="trống" };

				DataProvider.Ins.DB.Phongs.Add(phong);
				DataProvider.Ins.DB.SaveChanges();

				List.Add(phong);
				
			});

			//Cài đặt EditCommand
			EditCommand = new RelayCommand<object>((p) =>
			{
				if (string.IsNullOrEmpty(SoPhong) || SelectedItem == null)
					return false;
				if (string.IsNullOrEmpty(TenLoaiPhong) || SelectedItem == null)
					return false;
				
				return true;

			}, (p) =>
			{
				var phong = DataProvider.Ins.DB.Phongs.Where(x => x.maPhong == SelectedItem.maPhong).SingleOrDefault();
				phong.soPhong = SoPhong;
				phong.maLoai = SelectedItemLoaiPhong.maLoaiPhong;
				DataProvider.Ins.DB.SaveChanges();
				SelectedItem.soPhong = SoPhong;
				
			});
		}
	}
}
