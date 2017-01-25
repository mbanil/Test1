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

namespace TEST_3
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Employee_Details")]
	public partial class DataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee_Table(Employee_Table instance);
    partial void UpdateEmployee_Table(Employee_Table instance);
    partial void DeleteEmployee_Table(Employee_Table instance);
    #endregion
		
		public DataClassDataContext() : 
				base(global::TEST_3.Properties.Settings.Default.Employee_DetailsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee_Table> Employee_Tables
		{
			get
			{
				return this.GetTable<Employee_Table>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee_Table")]
	public partial class Employee_Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Employee_ID;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _Email_ID;
		
		private string _Status;
		
		private string _Address;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployee_IDChanging(int value);
    partial void OnEmployee_IDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnEmail_IDChanging(string value);
    partial void OnEmail_IDChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public Employee_Table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Employee ID]", Storage="_Employee_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Employee_ID
		{
			get
			{
				return this._Employee_ID;
			}
			set
			{
				if ((this._Employee_ID != value))
				{
					this.OnEmployee_IDChanging(value);
					this.SendPropertyChanging();
					this._Employee_ID = value;
					this.SendPropertyChanged("Employee_ID");
					this.OnEmployee_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First Name]", Storage="_First_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last Name]", Storage="_Last_Name", DbType="VarChar(20)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Email ID]", Storage="_Email_ID", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Email_ID
		{
			get
			{
				return this._Email_ID;
			}
			set
			{
				if ((this._Email_ID != value))
				{
					this.OnEmail_IDChanging(value);
					this.SendPropertyChanging();
					this._Email_ID = value;
					this.SendPropertyChanged("Email_ID");
					this.OnEmail_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
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