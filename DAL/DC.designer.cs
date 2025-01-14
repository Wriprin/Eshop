﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mydb")]
	public partial class DCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertGoods(Goods instance);
    partial void UpdateGoods(Goods instance);
    partial void DeleteGoods(Goods instance);
    partial void InsertUsers(Users instance);
    partial void UpdateUsers(Users instance);
    partial void DeleteUsers(Users instance);
    #endregion
		
		public DCDataContext() : 
				base(global::DAL.Properties.Settings.Default.mydbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admin
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Goods> Goods
		{
			get
			{
				return this.GetTable<Goods>();
			}
		}
		
		public System.Data.Linq.Table<UserGoods> UserGoods
		{
			get
			{
				return this.GetTable<UserGoods>();
			}
		}
		
		public System.Data.Linq.Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _name;
		
		private string _pwd;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpwdChanging(string value);
    partial void OnpwdChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pwd", DbType="NVarChar(50)")]
		public string pwd
		{
			get
			{
				return this._pwd;
			}
			set
			{
				if ((this._pwd != value))
				{
					this.OnpwdChanging(value);
					this.SendPropertyChanging();
					this._pwd = value;
					this.SendPropertyChanged("pwd");
					this.OnpwdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Goods")]
	public partial class Goods : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _gid;
		
		private string _gtype;
		
		private string _gname;
		
		private System.Nullable<double> _gprice;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OngidChanging(int value);
    partial void OngidChanged();
    partial void OngtypeChanging(string value);
    partial void OngtypeChanged();
    partial void OngnameChanging(string value);
    partial void OngnameChanged();
    partial void OngpriceChanging(System.Nullable<double> value);
    partial void OngpriceChanged();
    #endregion
		
		public Goods()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int gid
		{
			get
			{
				return this._gid;
			}
			set
			{
				if ((this._gid != value))
				{
					this.OngidChanging(value);
					this.SendPropertyChanging();
					this._gid = value;
					this.SendPropertyChanged("gid");
					this.OngidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gtype", DbType="NVarChar(50)")]
		public string gtype
		{
			get
			{
				return this._gtype;
			}
			set
			{
				if ((this._gtype != value))
				{
					this.OngtypeChanging(value);
					this.SendPropertyChanging();
					this._gtype = value;
					this.SendPropertyChanged("gtype");
					this.OngtypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gname", DbType="NVarChar(50)")]
		public string gname
		{
			get
			{
				return this._gname;
			}
			set
			{
				if ((this._gname != value))
				{
					this.OngnameChanging(value);
					this.SendPropertyChanging();
					this._gname = value;
					this.SendPropertyChanged("gname");
					this.OngnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gprice", DbType="Float")]
		public System.Nullable<double> gprice
		{
			get
			{
				return this._gprice;
			}
			set
			{
				if ((this._gprice != value))
				{
					this.OngpriceChanging(value);
					this.SendPropertyChanging();
					this._gprice = value;
					this.SendPropertyChanged("gprice");
					this.OngpriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserGoods")]
	public partial class UserGoods
	{
		
		private System.Nullable<int> _uid;
		
		private System.Nullable<int> _gid;
		
		private string _gtype;
		
		private string _gname;
		
		private System.Nullable<double> _gprice;
		
		private string _gstatus;
		
		public UserGoods()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", DbType="Int")]
		public System.Nullable<int> uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this._uid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gid", DbType="Int")]
		public System.Nullable<int> gid
		{
			get
			{
				return this._gid;
			}
			set
			{
				if ((this._gid != value))
				{
					this._gid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gtype", DbType="NVarChar(50)")]
		public string gtype
		{
			get
			{
				return this._gtype;
			}
			set
			{
				if ((this._gtype != value))
				{
					this._gtype = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gname", DbType="NVarChar(50)")]
		public string gname
		{
			get
			{
				return this._gname;
			}
			set
			{
				if ((this._gname != value))
				{
					this._gname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gprice", DbType="Float")]
		public System.Nullable<double> gprice
		{
			get
			{
				return this._gprice;
			}
			set
			{
				if ((this._gprice != value))
				{
					this._gprice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gstatus", DbType="NVarChar(50)")]
		public string gstatus
		{
			get
			{
				return this._gstatus;
			}
			set
			{
				if ((this._gstatus != value))
				{
					this._gstatus = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _uid;
		
		private string _uname;
		
		private string _usex;
		
		private string _upwd;
		
		private string _uschool;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuidChanging(int value);
    partial void OnuidChanged();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    partial void OnusexChanging(string value);
    partial void OnusexChanged();
    partial void OnupwdChanging(string value);
    partial void OnupwdChanged();
    partial void OnuschoolChanging(string value);
    partial void OnuschoolChanged();
    #endregion
		
		public Users()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="NVarChar(50)")]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usex", DbType="NVarChar(50)")]
		public string usex
		{
			get
			{
				return this._usex;
			}
			set
			{
				if ((this._usex != value))
				{
					this.OnusexChanging(value);
					this.SendPropertyChanging();
					this._usex = value;
					this.SendPropertyChanged("usex");
					this.OnusexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_upwd", DbType="NVarChar(50)")]
		public string upwd
		{
			get
			{
				return this._upwd;
			}
			set
			{
				if ((this._upwd != value))
				{
					this.OnupwdChanging(value);
					this.SendPropertyChanging();
					this._upwd = value;
					this.SendPropertyChanged("upwd");
					this.OnupwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uschool", DbType="NVarChar(50)")]
		public string uschool
		{
			get
			{
				return this._uschool;
			}
			set
			{
				if ((this._uschool != value))
				{
					this.OnuschoolChanging(value);
					this.SendPropertyChanging();
					this._uschool = value;
					this.SendPropertyChanged("uschool");
					this.OnuschoolChanged();
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
