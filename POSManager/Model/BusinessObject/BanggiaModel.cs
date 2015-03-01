using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Banggia",
        spSelect = "sys_BanggiaSelect",
        spInsert = "sys_BanggiaInsert",
        spUpdate = "sys_BanggiaUpdate",
        spDelete = "sys_BanggiaDelete")]
    public partial class BanggiaModel : Bus
    {
        private Guid _BanggiaId;
        private Nullable<Guid> _HanghoaId;
        private Nullable<DateTime> _NgayApdung;
        private Nullable<Double> _Gia;

        public BanggiaModel()
        {
			OnCreating();
            BanggiaId = ModelCore.GetGuidId();
			OnCreated();
        }

        public BanggiaModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("BanggiaId")]
	    [Column(Name="BanggiaId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid BanggiaId
        {
            get
			{
				Guid vGet = _BanggiaId;
				OnBanggiaIdGetting(ref _BanggiaId, ref vGet);
				return vGet;
			}
            set
            {
                OnBanggiaIdChanging(value);
                SetProperty(ref _BanggiaId, value);
                OnBanggiaIdChanged();
            }
        }
        
        
        [DisplayName("HanghoaId")]
	    [Column(Name="HanghoaId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> HanghoaId
        {
            get
			{
				Nullable<Guid> vGet = _HanghoaId;
				OnHanghoaIdGetting(ref _HanghoaId, ref vGet);
				return vGet;
			}
            set
            {
                OnHanghoaIdChanging(value);
                SetProperty(ref _HanghoaId, value);
                OnHanghoaIdChanged();
            }
        }
        
        
        [DisplayName("NgayApdung")]
	    [Column(Name="NgayApdung",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> NgayApdung
        {
            get
			{
				Nullable<DateTime> vGet = _NgayApdung;
				OnNgayApdungGetting(ref _NgayApdung, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayApdungChanging(value);
                SetProperty(ref _NgayApdung, value);
                OnNgayApdungChanged();
            }
        }
        
        
        [DisplayName("Gia")]
	    [Column(Name="Gia",SqlType=SqlDbType.Float)]
        public Nullable<Double> Gia
        {
            get
			{
				Nullable<Double> vGet = _Gia;
				OnGiaGetting(ref _Gia, ref vGet);
				return vGet;
			}
            set
            {
                OnGiaChanging(value);
                SetProperty(ref _Gia, value);
                OnGiaChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnBanggiaIdChanging(Guid value);
        partial void OnBanggiaIdChanged();
		partial void OnBanggiaIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNgayApdungChanging(Nullable<DateTime> value);
        partial void OnNgayApdungChanged();
		partial void OnNgayApdungGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGiaChanging(Nullable<Double> value);
        partial void OnGiaChanged();
		partial void OnGiaGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
    }
}