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

namespace TourismCompany.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TourismCompany")]
	public partial class TourismCompanydbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTrip(Trip instance);
    partial void UpdateTrip(Trip instance);
    partial void DeleteTrip(Trip instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUsers_Trip(Users_Trip instance);
    partial void UpdateUsers_Trip(Users_Trip instance);
    partial void DeleteUsers_Trip(Users_Trip instance);
    #endregion
		
		public TourismCompanydbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TourismCompanyConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TourismCompanydbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TourismCompanydbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TourismCompanydbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TourismCompanydbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Trip> Trips
		{
			get
			{
				return this.GetTable<Trip>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Users_Trip> Users_Trips
		{
			get
			{
				return this.GetTable<Users_Trip>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Trips")]
	public partial class Trip : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.DateTime _DepartureDate;
		
		private decimal _Price;
		
		private int _NumberOfNights;
		
		private string _BestPlaces;
		
		private string _Details;
		
		private string _Image;
		
		private EntitySet<Users_Trip> _Users_Trips;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDepartureDateChanging(System.DateTime value);
    partial void OnDepartureDateChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnNumberOfNightsChanging(int value);
    partial void OnNumberOfNightsChanged();
    partial void OnBestPlacesChanging(string value);
    partial void OnBestPlacesChanged();
    partial void OnDetailsChanging(string value);
    partial void OnDetailsChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    #endregion
		
		public Trip()
		{
			this._Users_Trips = new EntitySet<Users_Trip>(new Action<Users_Trip>(this.attach_Users_Trips), new Action<Users_Trip>(this.detach_Users_Trips));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartureDate", DbType="Date NOT NULL")]
		public System.DateTime DepartureDate
		{
			get
			{
				return this._DepartureDate;
			}
			set
			{
				if ((this._DepartureDate != value))
				{
					this.OnDepartureDateChanging(value);
					this.SendPropertyChanging();
					this._DepartureDate = value;
					this.SendPropertyChanged("DepartureDate");
					this.OnDepartureDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfNights", DbType="Int NOT NULL")]
		public int NumberOfNights
		{
			get
			{
				return this._NumberOfNights;
			}
			set
			{
				if ((this._NumberOfNights != value))
				{
					this.OnNumberOfNightsChanging(value);
					this.SendPropertyChanging();
					this._NumberOfNights = value;
					this.SendPropertyChanged("NumberOfNights");
					this.OnNumberOfNightsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BestPlaces", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string BestPlaces
		{
			get
			{
				return this._BestPlaces;
			}
			set
			{
				if ((this._BestPlaces != value))
				{
					this.OnBestPlacesChanging(value);
					this.SendPropertyChanging();
					this._BestPlaces = value;
					this.SendPropertyChanged("BestPlaces");
					this.OnBestPlacesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Details", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string Details
		{
			get
			{
				return this._Details;
			}
			set
			{
				if ((this._Details != value))
				{
					this.OnDetailsChanging(value);
					this.SendPropertyChanging();
					this._Details = value;
					this.SendPropertyChanged("Details");
					this.OnDetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Trip_Users_Trip", Storage="_Users_Trips", ThisKey="Id", OtherKey="TripId")]
		public EntitySet<Users_Trip> Users_Trips
		{
			get
			{
				return this._Users_Trips;
			}
			set
			{
				this._Users_Trips.Assign(value);
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
		
		private void attach_Users_Trips(Users_Trip entity)
		{
			this.SendPropertyChanging();
			entity.Trip = this;
		}
		
		private void detach_Users_Trips(Users_Trip entity)
		{
			this.SendPropertyChanging();
			entity.Trip = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Password;
		
		private EntitySet<Users_Trip> _Users_Trips;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			this._Users_Trips = new EntitySet<Users_Trip>(new Action<Users_Trip>(this.attach_Users_Trips), new Action<Users_Trip>(this.detach_Users_Trips));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Users_Trip", Storage="_Users_Trips", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<Users_Trip> Users_Trips
		{
			get
			{
				return this._Users_Trips;
			}
			set
			{
				this._Users_Trips.Assign(value);
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
		
		private void attach_Users_Trips(Users_Trip entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Users_Trips(Users_Trip entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users_Trips")]
	public partial class Users_Trip : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _UserId;
		
		private int _TripId;
		
		private EntityRef<Trip> _Trip;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnTripIdChanging(int value);
    partial void OnTripIdChanged();
    #endregion
		
		public Users_Trip()
		{
			this._Trip = default(EntityRef<Trip>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TripId", DbType="Int NOT NULL")]
		public int TripId
		{
			get
			{
				return this._TripId;
			}
			set
			{
				if ((this._TripId != value))
				{
					if (this._Trip.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTripIdChanging(value);
					this.SendPropertyChanging();
					this._TripId = value;
					this.SendPropertyChanged("TripId");
					this.OnTripIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Trip_Users_Trip", Storage="_Trip", ThisKey="TripId", OtherKey="Id", IsForeignKey=true)]
		public Trip Trip
		{
			get
			{
				return this._Trip.Entity;
			}
			set
			{
				Trip previousValue = this._Trip.Entity;
				if (((previousValue != value) 
							|| (this._Trip.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Trip.Entity = null;
						previousValue.Users_Trips.Remove(this);
					}
					this._Trip.Entity = value;
					if ((value != null))
					{
						value.Users_Trips.Add(this);
						this._TripId = value.Id;
					}
					else
					{
						this._TripId = default(int);
					}
					this.SendPropertyChanged("Trip");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Users_Trip", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Users_Trips.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Users_Trips.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
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
