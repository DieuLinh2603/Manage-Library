﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LVN")]
	public partial class LVNDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDocGia(DocGia instance);
    partial void UpdateDocGia(DocGia instance);
    partial void DeleteDocGia(DocGia instance);
    partial void InsertLichSuMuonTraSach(LichSuMuonTraSach instance);
    partial void UpdateLichSuMuonTraSach(LichSuMuonTraSach instance);
    partial void DeleteLichSuMuonTraSach(LichSuMuonTraSach instance);
    partial void InsertSach(Sach instance);
    partial void UpdateSach(Sach instance);
    partial void DeleteSach(Sach instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    #endregion
		
		public LVNDataContext() : 
				base(global::Login.Properties.Settings.Default.LVNConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public LVNDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LVNDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LVNDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LVNDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DocGia> DocGias
		{
			get
			{
				return this.GetTable<DocGia>();
			}
		}
		
		public System.Data.Linq.Table<LichSuMuonTraSach> LichSuMuonTraSaches
		{
			get
			{
				return this.GetTable<LichSuMuonTraSach>();
			}
		}
		
		public System.Data.Linq.Table<Sach> Saches
		{
			get
			{
				return this.GetTable<Sach>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DocGia")]
	public partial class DocGia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SoThe;
		
		private string _HoTen;
		
		private string _Khoa;
		
		private string _Email;
		
		private string _SDT;
		
		private EntitySet<LichSuMuonTraSach> _LichSuMuonTraSaches;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSoTheChanging(int value);
    partial void OnSoTheChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnKhoaChanging(string value);
    partial void OnKhoaChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public DocGia()
		{
			this._LichSuMuonTraSaches = new EntitySet<LichSuMuonTraSach>(new Action<LichSuMuonTraSach>(this.attach_LichSuMuonTraSaches), new Action<LichSuMuonTraSach>(this.detach_LichSuMuonTraSaches));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoThe", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SoThe
		{
			get
			{
				return this._SoThe;
			}
			set
			{
				if ((this._SoThe != value))
				{
					this.OnSoTheChanging(value);
					this.SendPropertyChanging();
					this._SoThe = value;
					this.SendPropertyChanged("SoThe");
					this.OnSoTheChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Khoa", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Khoa
		{
			get
			{
				return this._Khoa;
			}
			set
			{
				if ((this._Khoa != value))
				{
					this.OnKhoaChanging(value);
					this.SendPropertyChanging();
					this._Khoa = value;
					this.SendPropertyChanged("Khoa");
					this.OnKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DocGia_LichSuMuonTraSach", Storage="_LichSuMuonTraSaches", ThisKey="SoThe", OtherKey="SoThe")]
		public EntitySet<LichSuMuonTraSach> LichSuMuonTraSaches
		{
			get
			{
				return this._LichSuMuonTraSaches;
			}
			set
			{
				this._LichSuMuonTraSaches.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_LichSuMuonTraSaches(LichSuMuonTraSach entity)
		{
			this.SendPropertyChanging();
			entity.DocGia = this;
		}
		
		private void detach_LichSuMuonTraSaches(LichSuMuonTraSach entity)
		{
			this.SendPropertyChanging();
			entity.DocGia = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LichSuMuonTraSach")]
	public partial class LichSuMuonTraSach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _SoThe;
		
		private int _MaSach;
		
		private System.Nullable<System.DateTime> _NgayMuon;
		
		private System.Nullable<System.DateTime> _NgayTra;
		
		private EntityRef<DocGia> _DocGia;
		
		private EntityRef<Sach> _Sach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnSoTheChanging(int value);
    partial void OnSoTheChanged();
    partial void OnMaSachChanging(int value);
    partial void OnMaSachChanged();
    partial void OnNgayMuonChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayMuonChanged();
    partial void OnNgayTraChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayTraChanged();
    #endregion
		
		public LichSuMuonTraSach()
		{
			this._DocGia = default(EntityRef<DocGia>);
			this._Sach = default(EntityRef<Sach>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoThe", DbType="Int NOT NULL")]
		public int SoThe
		{
			get
			{
				return this._SoThe;
			}
			set
			{
				if ((this._SoThe != value))
				{
					if (this._DocGia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSoTheChanging(value);
					this.SendPropertyChanging();
					this._SoThe = value;
					this.SendPropertyChanged("SoThe");
					this.OnSoTheChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="Int NOT NULL")]
		public int MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					if (this._Sach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayMuon", DbType="Date")]
		public System.Nullable<System.DateTime> NgayMuon
		{
			get
			{
				return this._NgayMuon;
			}
			set
			{
				if ((this._NgayMuon != value))
				{
					this.OnNgayMuonChanging(value);
					this.SendPropertyChanging();
					this._NgayMuon = value;
					this.SendPropertyChanged("NgayMuon");
					this.OnNgayMuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTra", DbType="Date")]
		public System.Nullable<System.DateTime> NgayTra
		{
			get
			{
				return this._NgayTra;
			}
			set
			{
				if ((this._NgayTra != value))
				{
					this.OnNgayTraChanging(value);
					this.SendPropertyChanging();
					this._NgayTra = value;
					this.SendPropertyChanged("NgayTra");
					this.OnNgayTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DocGia_LichSuMuonTraSach", Storage="_DocGia", ThisKey="SoThe", OtherKey="SoThe", IsForeignKey=true)]
		public DocGia DocGia
		{
			get
			{
				return this._DocGia.Entity;
			}
			set
			{
				DocGia previousValue = this._DocGia.Entity;
				if (((previousValue != value) 
							|| (this._DocGia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DocGia.Entity = null;
						previousValue.LichSuMuonTraSaches.Remove(this);
					}
					this._DocGia.Entity = value;
					if ((value != null))
					{
						value.LichSuMuonTraSaches.Add(this);
						this._SoThe = value.SoThe;
					}
					else
					{
						this._SoThe = default(int);
					}
					this.SendPropertyChanged("DocGia");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_LichSuMuonTraSach", Storage="_Sach", ThisKey="MaSach", OtherKey="MaSach", IsForeignKey=true)]
		public Sach Sach
		{
			get
			{
				return this._Sach.Entity;
			}
			set
			{
				Sach previousValue = this._Sach.Entity;
				if (((previousValue != value) 
							|| (this._Sach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sach.Entity = null;
						previousValue.LichSuMuonTraSaches.Remove(this);
					}
					this._Sach.Entity = value;
					if ((value != null))
					{
						value.LichSuMuonTraSaches.Add(this);
						this._MaSach = value.MaSach;
					}
					else
					{
						this._MaSach = default(int);
					}
					this.SendPropertyChanged("Sach");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sach")]
	public partial class Sach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSach;
		
		private string _TenSach;
		
		private string _TacGia;
		
		private string _TheLoai;
		
		private int _NamXuatBan;
		
		private double _GiaSach;
		
		private int _SoLuong;
		
		private EntitySet<LichSuMuonTraSach> _LichSuMuonTraSaches;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSachChanging(int value);
    partial void OnMaSachChanged();
    partial void OnTenSachChanging(string value);
    partial void OnTenSachChanged();
    partial void OnTacGiaChanging(string value);
    partial void OnTacGiaChanged();
    partial void OnTheLoaiChanging(string value);
    partial void OnTheLoaiChanged();
    partial void OnNamXuatBanChanging(int value);
    partial void OnNamXuatBanChanged();
    partial void OnGiaSachChanging(double value);
    partial void OnGiaSachChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    #endregion
		
		public Sach()
		{
			this._LichSuMuonTraSaches = new EntitySet<LichSuMuonTraSach>(new Action<LichSuMuonTraSach>(this.attach_LichSuMuonTraSaches), new Action<LichSuMuonTraSach>(this.detach_LichSuMuonTraSaches));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSach", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string TenSach
		{
			get
			{
				return this._TenSach;
			}
			set
			{
				if ((this._TenSach != value))
				{
					this.OnTenSachChanging(value);
					this.SendPropertyChanging();
					this._TenSach = value;
					this.SendPropertyChanged("TenSach");
					this.OnTenSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TacGia", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string TacGia
		{
			get
			{
				return this._TacGia;
			}
			set
			{
				if ((this._TacGia != value))
				{
					this.OnTacGiaChanging(value);
					this.SendPropertyChanging();
					this._TacGia = value;
					this.SendPropertyChanged("TacGia");
					this.OnTacGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TheLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TheLoai
		{
			get
			{
				return this._TheLoai;
			}
			set
			{
				if ((this._TheLoai != value))
				{
					this.OnTheLoaiChanging(value);
					this.SendPropertyChanging();
					this._TheLoai = value;
					this.SendPropertyChanged("TheLoai");
					this.OnTheLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamXuatBan", DbType="Int NOT NULL")]
		public int NamXuatBan
		{
			get
			{
				return this._NamXuatBan;
			}
			set
			{
				if ((this._NamXuatBan != value))
				{
					this.OnNamXuatBanChanging(value);
					this.SendPropertyChanging();
					this._NamXuatBan = value;
					this.SendPropertyChanged("NamXuatBan");
					this.OnNamXuatBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaSach", DbType="Float NOT NULL")]
		public double GiaSach
		{
			get
			{
				return this._GiaSach;
			}
			set
			{
				if ((this._GiaSach != value))
				{
					this.OnGiaSachChanging(value);
					this.SendPropertyChanging();
					this._GiaSach = value;
					this.SendPropertyChanged("GiaSach");
					this.OnGiaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_LichSuMuonTraSach", Storage="_LichSuMuonTraSaches", ThisKey="MaSach", OtherKey="MaSach")]
		public EntitySet<LichSuMuonTraSach> LichSuMuonTraSaches
		{
			get
			{
				return this._LichSuMuonTraSaches;
			}
			set
			{
				this._LichSuMuonTraSaches.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_LichSuMuonTraSaches(LichSuMuonTraSach entity)
		{
			this.SendPropertyChanging();
			entity.Sach = this;
		}
		
		private void detach_LichSuMuonTraSaches(LichSuMuonTraSach entity)
		{
			this.SendPropertyChanging();
			entity.Sach = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TaiKhoan1;
		
		private string _MatKhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTaiKhoan1Changing(string value);
    partial void OnTaiKhoan1Changed();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public TaiKhoan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TaiKhoan", Storage="_TaiKhoan1", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TaiKhoan1
		{
			get
			{
				return this._TaiKhoan1;
			}
			set
			{
				if ((this._TaiKhoan1 != value))
				{
					this.OnTaiKhoan1Changing(value);
					this.SendPropertyChanging();
					this._TaiKhoan1 = value;
					this.SendPropertyChanged("TaiKhoan1");
					this.OnTaiKhoan1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
