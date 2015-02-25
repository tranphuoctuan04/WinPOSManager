using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Ban",
        spSelect = "sys_BanSelect",
        spInsert = "sys_BanInsert",
        spUpdate = "sys_BanUpdate",
        spDelete = "sys_BanDelete")]
    public partial class BanModel : Bus
    {
        private Guid _BanId;
        private Nullable<Guid> _KhuvucId;
        private Nullable<Guid> _HoadonId;
        private Nullable<Int32> _STT;
        private Nullable<Boolean> _Candon;
        private Nullable<Boolean> _Hoatdong;
        private String _Ten;

        public BanModel()
        {
			OnCreating();
            BanId = ModelCore.GetGuidId();
			OnCreated();
        }

        public BanModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("BanId")]
	    [Column(Name="BanId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid BanId
        {
            get
			{
				Guid vGet = _BanId;
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
        
        
        [DisplayName("KhuvucId")]
	    [Column(Name="KhuvucId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> KhuvucId
        {
            get
			{
				Nullable<Guid> vGet = _KhuvucId;
				OnKhuvucIdGetting(ref _KhuvucId, ref vGet);
				return vGet;
			}
            set
            {
                OnKhuvucIdChanging(value);
                SetProperty(ref _KhuvucId, value);
                OnKhuvucIdChanged();
            }
        }
        
        
        [DisplayName("HoadonId")]
	    [Column(Name="HoadonId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> HoadonId
        {
            get
			{
				Nullable<Guid> vGet = _HoadonId;
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
        
        
        [DisplayName("STT")]
	    [Column(Name="STT",SqlType=SqlDbType.Int)]
        public Nullable<Int32> STT
        {
            get
			{
				Nullable<Int32> vGet = _STT;
				OnSTTGetting(ref _STT, ref vGet);
				return vGet;
			}
            set
            {
                OnSTTChanging(value);
                SetProperty(ref _STT, value);
                OnSTTChanged();
            }
        }
        
        
        [DisplayName("Candon")]
	    [Column(Name="Candon",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Candon
        {
            get
			{
				Nullable<Boolean> vGet = _Candon;
				OnCandonGetting(ref _Candon, ref vGet);
				return vGet;
			}
            set
            {
                OnCandonChanging(value);
                SetProperty(ref _Candon, value);
                OnCandonChanged();
            }
        }
        
        
        [DisplayName("Hoatdong")]
	    [Column(Name="Hoatdong",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Hoatdong
        {
            get
			{
				Nullable<Boolean> vGet = _Hoatdong;
				OnHoatdongGetting(ref _Hoatdong, ref vGet);
				return vGet;
			}
            set
            {
                OnHoatdongChanging(value);
                SetProperty(ref _Hoatdong, value);
                OnHoatdongChanged();
            }
        }
        
        
        [DisplayName("Ten")]
	    [Column(Name="Ten",SqlType=SqlDbType.NVarChar)]
        public String Ten
        {
            get
			{
				String vGet = _Ten;
				OnTenGetting(ref _Ten, ref vGet);
				return vGet;
			}
            set
            {
                OnTenChanging(value);
                SetProperty(ref _Ten, value);
                OnTenChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnBanIdChanging(Guid value);
        partial void OnBanIdChanged();
		partial void OnBanIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnKhuvucIdChanging(Nullable<Guid> value);
        partial void OnKhuvucIdChanged();
		partial void OnKhuvucIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHoadonIdChanging(Nullable<Guid> value);
        partial void OnHoadonIdChanged();
		partial void OnHoadonIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnSTTChanging(Nullable<Int32> value);
        partial void OnSTTChanged();
		partial void OnSTTGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnCandonChanging(Nullable<Boolean> value);
        partial void OnCandonChanged();
		partial void OnCandonGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnHoatdongChanging(Nullable<Boolean> value);
        partial void OnHoatdongChanged();
		partial void OnHoatdongGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnTenChanging(String value);
        partial void OnTenChanged();
		partial void OnTenGetting(ref String value, ref String vGet);
        
    }
}