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

namespace WcfService1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="studydb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertstud(stud instance);
    partial void Updatestud(stud instance);
    partial void Deletestud(stud instance);
    partial void Insertexam(exam instance);
    partial void Updateexam(exam instance);
    partial void Deleteexam(exam instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["studydbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<stud> studs
		{
			get
			{
				return this.GetTable<stud>();
			}
		}
		
		public System.Data.Linq.Table<exam> exams
		{
			get
			{
				return this.GetTable<exam>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.stud")]
	public partial class stud : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _rno;
		
		private string _sname;
		
		private string _course;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnrnoChanging(decimal value);
    partial void OnrnoChanged();
    partial void OnsnameChanging(string value);
    partial void OnsnameChanged();
    partial void OncourseChanging(string value);
    partial void OncourseChanged();
    #endregion
		
		public stud()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rno", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal rno
		{
			get
			{
				return this._rno;
			}
			set
			{
				if ((this._rno != value))
				{
					this.OnrnoChanging(value);
					this.SendPropertyChanging();
					this._rno = value;
					this.SendPropertyChanged("rno");
					this.OnrnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sname", DbType="VarChar(50)")]
		public string sname
		{
			get
			{
				return this._sname;
			}
			set
			{
				if ((this._sname != value))
				{
					this.OnsnameChanging(value);
					this.SendPropertyChanging();
					this._sname = value;
					this.SendPropertyChanged("sname");
					this.OnsnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_course", DbType="VarChar(50)")]
		public string course
		{
			get
			{
				return this._course;
			}
			set
			{
				if ((this._course != value))
				{
					this.OncourseChanging(value);
					this.SendPropertyChanging();
					this._course = value;
					this.SendPropertyChanged("course");
					this.OncourseChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.exam")]
	public partial class exam : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _examid;
		
		private decimal _rno;
		
		private System.Nullable<decimal> _sem;
		
		private System.Nullable<decimal> _per;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnexamidChanging(decimal value);
    partial void OnexamidChanged();
    partial void OnrnoChanging(decimal value);
    partial void OnrnoChanged();
    partial void OnsemChanging(System.Nullable<decimal> value);
    partial void OnsemChanged();
    partial void OnperChanging(System.Nullable<decimal> value);
    partial void OnperChanged();
    #endregion
		
		public exam()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_examid", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal examid
		{
			get
			{
				return this._examid;
			}
			set
			{
				if ((this._examid != value))
				{
					this.OnexamidChanging(value);
					this.SendPropertyChanging();
					this._examid = value;
					this.SendPropertyChanged("examid");
					this.OnexamidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rno", DbType="Decimal(18,0) NOT NULL")]
		public decimal rno
		{
			get
			{
				return this._rno;
			}
			set
			{
				if ((this._rno != value))
				{
					this.OnrnoChanging(value);
					this.SendPropertyChanging();
					this._rno = value;
					this.SendPropertyChanged("rno");
					this.OnrnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sem", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> sem
		{
			get
			{
				return this._sem;
			}
			set
			{
				if ((this._sem != value))
				{
					this.OnsemChanging(value);
					this.SendPropertyChanging();
					this._sem = value;
					this.SendPropertyChanged("sem");
					this.OnsemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> per
		{
			get
			{
				return this._per;
			}
			set
			{
				if ((this._per != value))
				{
					this.OnperChanging(value);
					this.SendPropertyChanging();
					this._per = value;
					this.SendPropertyChanged("per");
					this.OnperChanged();
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
