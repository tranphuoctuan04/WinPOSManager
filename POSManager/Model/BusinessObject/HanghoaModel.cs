using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Hanghoa",
        spSelect = "sys_HanghoaSelect",
        spInsert = "sys_HanghoaInsert",
        spUpdate = "sys_HanghoaUpdate",
        spDelete = "sys_HanghoaDelete")]
    public partial class HanghoaModel : Bus
    {
        private Byte[] _Image;
        private Guid _HanghoaId;
        private Nullable<Guid> _NhomHanghoaId;
        private Nullable<Boolean> _Hoatdong;
        private String _Code;
        private Byte[] _Version;
        private String _Ten;

        public HanghoaModel()
        {
			OnCreating();
            HanghoaId = ModelCore.GetGuidId();
			OnCreated();
        }

        public HanghoaModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("Image")]
	    [Column(Name="Image",SqlType=SqlDbType.Image)]
        public Byte[] Image
        {
            get
			{
				Byte[] vGet = _Image;
				OnImageGetting(ref _Image, ref vGet);
				return vGet;
			}
            set
            {
                OnImageChanging(value);
                SetProperty(ref _Image, value);
                OnImageChanged();
            }
        }
        
        
        [DisplayName("HanghoaId")]
	    [Column(Name="HanghoaId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid HanghoaId
        {
            get
			{
				Guid vGet = _HanghoaId;
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
        
        
        [DisplayName("NhomHanghoaId")]
	    [Column(Name="NhomHanghoaId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NhomHanghoaId
        {
            get
			{
				Nullable<Guid> vGet = _NhomHanghoaId;
				OnNhomHanghoaIdGetting(ref _NhomHanghoaId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhomHanghoaIdChanging(value);
                SetProperty(ref _NhomHanghoaId, value);
                OnNhomHanghoaIdChanged();
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
        
        
        [DisplayName("Code")]
	    [Column(Name="Code",SqlType=SqlDbType.VarChar)]
        public String Code
        {
            get
			{
				String vGet = _Code;
				OnCodeGetting(ref _Code, ref vGet);
				return vGet;
			}
            set
            {
                OnCodeChanging(value);
                SetProperty(ref _Code, value);
                OnCodeChanged();
            }
        }
        
        
        [DisplayName("Version")]
	    [Column(Name="Version",SqlType=SqlDbType.Timestamp)]
        public Byte[] Version
        {
            get
			{
				Byte[] vGet = _Version;
				OnVersionGetting(ref _Version, ref vGet);
				return vGet;
			}
            set
            {
                OnVersionChanging(value);
                SetProperty(ref _Version, value);
                OnVersionChanged();
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
		
        
        partial void OnImageChanging(Byte[] value);
        partial void OnImageChanged();
		partial void OnImageGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnHanghoaIdChanging(Guid value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhomHanghoaIdChanging(Nullable<Guid> value);
        partial void OnNhomHanghoaIdChanged();
		partial void OnNhomHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHoatdongChanging(Nullable<Boolean> value);
        partial void OnHoatdongChanged();
		partial void OnHoatdongGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTenChanging(String value);
        partial void OnTenChanged();
		partial void OnTenGetting(ref String value, ref String vGet);
        
    }
}