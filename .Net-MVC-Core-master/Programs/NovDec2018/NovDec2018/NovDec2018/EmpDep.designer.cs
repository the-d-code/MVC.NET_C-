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

namespace NovDec2018
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmployeeDB")]
	public partial class EmpDepDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployeeTB(EmployeeTB instance);
    partial void UpdateEmployeeTB(EmployeeTB instance);
    partial void DeleteEmployeeTB(EmployeeTB instance);
    partial void InsertDepartmentTB(DepartmentTB instance);
    partial void UpdateDepartmentTB(DepartmentTB instance);
    partial void DeleteDepartmentTB(DepartmentTB instance);
    #endregion
		
		public EmpDepDataContext() : 
				base(global::NovDec2018.Properties.Settings.Default.EmployeeDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EmpDepDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmpDepDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmpDepDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmpDepDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EmployeeTB> EmployeeTBs
		{
			get
			{
				return this.GetTable<EmployeeTB>();
			}
		}
		
		public System.Data.Linq.Table<DepartmentTB> DepartmentTBs
		{
			get
			{
				return this.GetTable<DepartmentTB>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeeTB")]
	public partial class EmployeeTB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeId;
		
		private string _EmployeeName;
		
		private string _Gender;
		
		private System.Nullable<decimal> _Salary;
		
		private string _City;
		
		private System.Nullable<int> _DepartmentId;
		
		private EntityRef<DepartmentTB> _DepartmentTB;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIdChanging(int value);
    partial void OnEmployeeIdChanged();
    partial void OnEmployeeNameChanging(string value);
    partial void OnEmployeeNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnSalaryChanging(System.Nullable<decimal> value);
    partial void OnSalaryChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnDepartmentIdChanging(System.Nullable<int> value);
    partial void OnDepartmentIdChanged();
    #endregion
		
		public EmployeeTB()
		{
			this._DepartmentTB = default(EntityRef<DepartmentTB>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeName", DbType="VarChar(50)")]
		public string EmployeeName
		{
			get
			{
				return this._EmployeeName;
			}
			set
			{
				if ((this._EmployeeName != value))
				{
					this.OnEmployeeNameChanging(value);
					this.SendPropertyChanging();
					this._EmployeeName = value;
					this.SendPropertyChanged("EmployeeName");
					this.OnEmployeeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", DbType="Int")]
		public System.Nullable<int> DepartmentId
		{
			get
			{
				return this._DepartmentId;
			}
			set
			{
				if ((this._DepartmentId != value))
				{
					if (this._DepartmentTB.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepartmentIdChanging(value);
					this.SendPropertyChanging();
					this._DepartmentId = value;
					this.SendPropertyChanged("DepartmentId");
					this.OnDepartmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DepartmentTB_EmployeeTB", Storage="_DepartmentTB", ThisKey="DepartmentId", OtherKey="DepartmentId", IsForeignKey=true)]
		public DepartmentTB DepartmentTB
		{
			get
			{
				return this._DepartmentTB.Entity;
			}
			set
			{
				DepartmentTB previousValue = this._DepartmentTB.Entity;
				if (((previousValue != value) 
							|| (this._DepartmentTB.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DepartmentTB.Entity = null;
						previousValue.EmployeeTBs.Remove(this);
					}
					this._DepartmentTB.Entity = value;
					if ((value != null))
					{
						value.EmployeeTBs.Add(this);
						this._DepartmentId = value.DepartmentId;
					}
					else
					{
						this._DepartmentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("DepartmentTB");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DepartmentTB")]
	public partial class DepartmentTB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DepartmentId;
		
		private string _DepartmentName;
		
		private EntitySet<EmployeeTB> _EmployeeTBs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepartmentIdChanging(int value);
    partial void OnDepartmentIdChanged();
    partial void OnDepartmentNameChanging(string value);
    partial void OnDepartmentNameChanged();
    #endregion
		
		public DepartmentTB()
		{
			this._EmployeeTBs = new EntitySet<EmployeeTB>(new Action<EmployeeTB>(this.attach_EmployeeTBs), new Action<EmployeeTB>(this.detach_EmployeeTBs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DepartmentId
		{
			get
			{
				return this._DepartmentId;
			}
			set
			{
				if ((this._DepartmentId != value))
				{
					this.OnDepartmentIdChanging(value);
					this.SendPropertyChanging();
					this._DepartmentId = value;
					this.SendPropertyChanged("DepartmentId");
					this.OnDepartmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DepartmentName
		{
			get
			{
				return this._DepartmentName;
			}
			set
			{
				if ((this._DepartmentName != value))
				{
					this.OnDepartmentNameChanging(value);
					this.SendPropertyChanging();
					this._DepartmentName = value;
					this.SendPropertyChanged("DepartmentName");
					this.OnDepartmentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DepartmentTB_EmployeeTB", Storage="_EmployeeTBs", ThisKey="DepartmentId", OtherKey="DepartmentId")]
		public EntitySet<EmployeeTB> EmployeeTBs
		{
			get
			{
				return this._EmployeeTBs;
			}
			set
			{
				this._EmployeeTBs.Assign(value);
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
		
		private void attach_EmployeeTBs(EmployeeTB entity)
		{
			this.SendPropertyChanging();
			entity.DepartmentTB = this;
		}
		
		private void detach_EmployeeTBs(EmployeeTB entity)
		{
			this.SendPropertyChanging();
			entity.DepartmentTB = null;
		}
	}
}
#pragma warning restore 1591
