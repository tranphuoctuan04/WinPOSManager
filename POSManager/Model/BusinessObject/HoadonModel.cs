using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Hoadon",
        spSelect = "sys_HoadonSelect",
        spInsert = "sys_HoadonInsert",
        spUpdate = "sys_HoadonUpdate",
        spDelete = "sys_HoadonDelete")]
    public partial class HoadonModel : Bus
    {
        private Guid _HoadonId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Guid> _BanId;
        private Nullable<Guid> _CuahangId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaygio;
        private Nullable<Double> _Tongtien;
        private String _TenKhachhang;

        public HoadonModel()
        {
			OnCreating();
            HoadonId = ModelCore.GetGuidId();
			OnCreated();
        }

        public HoadonModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("HoadonId")]
	    [Column(Name="HoadonId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid HoadonId
        {
            get
			{
				Guid vGet = _HoadonId;
				OnHoadonIdGetting(ref _HoadonId, ref vGet);
				return vGet;
			}
            set
            {
                OnHoadonIdChanging(value);
                SetProperty(ref _HoadonId, value);
                OnHoadonIdChanged();
            }
        }
        
        
        [DisplayName("NhanvienId")]
	    [Column(Name="NhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NhanvienId
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienId;
				OnNhanvienIdGetting(ref _NhanvienId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienIdChanging(value);
                SetProperty(ref _NhanvienId, value);
                OnNhanvienIdChanged();
            }
        }
        
        
        [DisplayName("BanId")]
	    [Column(Name="BanId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> BanId
        {
            get
			{
				Nullable<Guid> vGet = _BanId;
				OnBanIdGetting(ref _BanId, ref vGet);
				return vGet;
			}
            set
            {
                OnBanIdChanging(value);
                SetProperty(ref _BanId, value);
                OnBanIdChanged();
            }
        }
        
        
        [DisplayName("CuahangId")]
	    [Column(Name="CuahangId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> CuahangId
        {
            get
			{
				Nullable<Guid> vGet = _CuahangId;
				OnCuahangIdGetting(ref _CuahangId, ref vGet);
				return vGet;
			}
            set
            {
                OnCuahangIdChanging(value);
                SetProperty(ref _CuahangId, value);
                OnCuahangIdChanged();
            }
        }
        
        
        [DisplayName("Step")]
	    [Column(Name="Step",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Step
        {
            get
			{
				Nullable<Int32> vGet = _Step;
				OnStepGetting(ref _Step, ref vGet);
				return vGet;
			}
            set
            {
                OnStepChanging(value);
                SetProperty(ref _Step, value);
                OnStepChanged();
            }
        }
        
        
        [DisplayName("Ngaygio")]
	    [Column(Name="Ngaygio",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> Ngaygio
        {
            get
			{
				Nullable<DateTime> vGet = _Ngaygio;
				OnNgaygioGetting(ref _Ngaygio, ref vGet);
				return vGet;
			}
            set
            {
                OnNgaygioChanging(value);
                SetProperty(ref _Ngaygio, value);
                OnNgaygioChanged();
            }
        }
        
        
        [DisplayName("Tongtien")]
	    [Column(Name="Tongtien",SqlType=SqlDbType.Float)]
        public Nullable<Double> Tongtien
        {
            get
			{
				Nullable<Double> vGet = _Tongtien;
				OnTongtienGetting(ref _Tongtien, ref vGet);
				return vGet;
			}
            set
            {
                OnTongtienChanging(value);
                SetProperty(ref _Tongtien, value);
                OnTongtienChanged();
            }
        }
        
        
        [DisplayName("TenKhachhang")]
	    [Column(Name="TenKhachhang",SqlType=SqlDbType.NVarChar)]
        public String TenKhachhang
        {
            get
			{
				String vGet = _TenKhachhang;
				OnTenKhachhangGetting(ref _TenKhachhang, ref vGet);
				return vGet;
			}
            set
            {
                OnTenKhachhangChanging(value);
                SetProperty(ref _TenKhachhang, value);
                OnTenKhachhangChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnHoadonIdChanging(Guid value);
        partial void OnHoadonIdChanged();
		partial void OnHoadonIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnBanIdChanging(Nullable<Guid> value);
        partial void OnBanIdChanged();
		partial void OnBanIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnCuahangIdChanging(Nullable<Guid> value);
        partial void OnCuahangIdChanged();
		partial void OnCuahangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaygioChanging(Nullable<DateTime> value);
        partial void OnNgaygioChanged();
		partial void OnNgaygioGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnTongtienChanging(Nullable<Double> value);
        partial void OnTongtienChanged();
		partial void OnTongtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnTenKhachhangChanging(String value);
        partial void OnTenKhachhangChanged();
		partial void OnTenKhachhangGetting(ref String value, ref String vGet);
        
    }
}