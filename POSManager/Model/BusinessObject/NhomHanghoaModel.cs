using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "NhomHanghoa",
        spSelect = "sys_NhomHanghoaSelect",
        spInsert = "sys_NhomHanghoaInsert",
        spUpdate = "sys_NhomHanghoaUpdate",
        spDelete = "sys_NhomHanghoaDelete")]
    public partial class NhomHanghoaModel : Bus
    {
        private Guid _NhomHanghoaId;
        private String _Code;
        private String _Ten;

        public NhomHanghoaModel()
        {
			OnCreating();
            NhomHanghoaId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NhomHanghoaModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("NhomHanghoaId")]
	    [Column(Name="NhomHanghoaId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid NhomHanghoaId
        {
            get
			{
				Guid vGet = _NhomHanghoaId;
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
		
        
        partial void OnNhomHanghoaIdChanging(Guid value);
        partial void OnNhomHanghoaIdChanged();
		partial void OnNhomHanghoaIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnTenChanging(String value);
        partial void OnTenChanged();
		partial void OnTenGetting(ref String value, ref String vGet);
        
    }
}