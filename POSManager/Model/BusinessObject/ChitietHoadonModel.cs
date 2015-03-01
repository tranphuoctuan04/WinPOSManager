using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "ChitietHoadon",
        spSelect = "sys_ChitietHoadonSelect",
        spInsert = "sys_ChitietHoadonInsert",
        spUpdate = "sys_ChitietHoadonUpdate",
        spDelete = "sys_ChitietHoadonDelete")]
    public partial class ChitietHoadonModel : Bus
    {
        private Guid _ChitietHoadonId;
        private Nullable<Guid> _HoadonId;
        private Nullable<Guid> _HanghoaId;
        private Nullable<Int32> _Soluong;
        private Nullable<Double> _Dongia;
        private Nullable<Double> _Thanhtien;

        public ChitietHoadonModel()
        {
			OnCreating();
            ChitietHoadonId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ChitietHoadonModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("ChitietHoadonId")]
	    [Column(Name="ChitietHoadonId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ChitietHoadonId
        {
            get
			{
				Guid vGet = _ChitietHoadonId;
				OnChitietHoadonIdGetting(ref _ChitietHoadonId, ref vGet);
				return vGet;
			}
            set
            {
                OnChitietHoadonIdChanging(value);
                SetProperty(ref _ChitietHoadonId, value);
                OnChitietHoadonIdChanged();
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
        
        
        [DisplayName("Soluong")]
	    [Column(Name="Soluong",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Soluong
        {
            get
			{
				Nullable<Int32> vGet = _Soluong;
				OnSoluongGetting(ref _Soluong, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongChanging(value);
                SetProperty(ref _Soluong, value);
                OnSoluongChanged();
            }
        }
        
        
        [DisplayName("Dongia")]
	    [Column(Name="Dongia",SqlType=SqlDbType.Float)]
        public Nullable<Double> Dongia
        {
            get
			{
				Nullable<Double> vGet = _Dongia;
				OnDongiaGetting(ref _Dongia, ref vGet);
				return vGet;
			}
            set
            {
                OnDongiaChanging(value);
                SetProperty(ref _Dongia, value);
                OnDongiaChanged();
            }
        }
        
        
        [DisplayName("Thanhtien")]
	    [Column(Name="Thanhtien",SqlType=SqlDbType.Float)]
        public Nullable<Double> Thanhtien
        {
            get
			{
				Nullable<Double> vGet = _Thanhtien;
				OnThanhtienGetting(ref _Thanhtien, ref vGet);
				return vGet;
			}
            set
            {
                OnThanhtienChanging(value);
                SetProperty(ref _Thanhtien, value);
                OnThanhtienChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnChitietHoadonIdChanging(Guid value);
        partial void OnChitietHoadonIdChanged();
		partial void OnChitietHoadonIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnHoadonIdChanging(Nullable<Guid> value);
        partial void OnHoadonIdChanged();
		partial void OnHoadonIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnSoluongChanging(Nullable<Int32> value);
        partial void OnSoluongChanged();
		partial void OnSoluongGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnDongiaChanging(Nullable<Double> value);
        partial void OnDongiaChanged();
		partial void OnDongiaGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnThanhtienChanging(Nullable<Double> value);
        partial void OnThanhtienChanged();
		partial void OnThanhtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
    }
}