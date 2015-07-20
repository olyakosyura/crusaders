﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.225
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crusaders
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Crusaders")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void Insertplayers(players instance);
    partial void Updateplayers(players instance);
    partial void Deleteplayers(players instance);
    partial void Insertmatches(matches instance);
    partial void Updatematches(matches instance);
    partial void Deletematches(matches instance);
    partial void Inserttickets(tickets instance);
    partial void Updatetickets(tickets instance);
    partial void Deletetickets(tickets instance);
    partial void Insertusers(users instance);
    partial void Updateusers(users instance);
    partial void Deleteusers(users instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CrusadersConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<players> players
		{
			get
			{
				return this.GetTable<players>();
			}
		}
		
		public System.Data.Linq.Table<matches> matches
		{
			get
			{
				return this.GetTable<matches>();
			}
		}
		
		public System.Data.Linq.Table<tickets> tickets
		{
			get
			{
				return this.GetTable<tickets>();
			}
		}
		
		public System.Data.Linq.Table<users> users
		{
			get
			{
				return this.GetTable<users>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.players")]
	public partial class players : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _PlayerId;
		
		private string _Name;
		
		private string _Position;
		
		private string _SponsorType;
		
		private string _Sponsor;
		
		private string _Team;
		
		private string _Image;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPlayerIdChanging(System.Nullable<int> value);
    partial void OnPlayerIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    partial void OnSponsorTypeChanging(string value);
    partial void OnSponsorTypeChanged();
    partial void OnSponsorChanging(string value);
    partial void OnSponsorChanged();
    partial void OnTeamChanging(string value);
    partial void OnTeamChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    #endregion
		
		public players()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="Int")]
		public System.Nullable<int> PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(50)")]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SponsorType", DbType="VarChar(10)")]
		public string SponsorType
		{
			get
			{
				return this._SponsorType;
			}
			set
			{
				if ((this._SponsorType != value))
				{
					this.OnSponsorTypeChanging(value);
					this.SendPropertyChanging();
					this._SponsorType = value;
					this.SendPropertyChanged("SponsorType");
					this.OnSponsorTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sponsor", DbType="NVarChar(512)")]
		public string Sponsor
		{
			get
			{
				return this._Sponsor;
			}
			set
			{
				if ((this._Sponsor != value))
				{
					this.OnSponsorChanging(value);
					this.SendPropertyChanging();
					this._Sponsor = value;
					this.SendPropertyChanged("Sponsor");
					this.OnSponsorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Team", DbType="VarChar(32)")]
		public string Team
		{
			get
			{
				return this._Team;
			}
			set
			{
				if ((this._Team != value))
				{
					this.OnTeamChanging(value);
					this.SendPropertyChanging();
					this._Team = value;
					this.SendPropertyChanged("Team");
					this.OnTeamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(512)")]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.matches")]
	public partial class matches : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Competitor;
		
		private System.Nullable<System.DateTime> _DateTime;
		
		private System.Nullable<double> _ChildPrice;
		
		private System.Nullable<double> _AdultPrice;
		
		private System.Nullable<double> _ConsessionPrice;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCompetitorChanging(string value);
    partial void OnCompetitorChanged();
    partial void OnDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnDateTimeChanged();
    partial void OnChildPriceChanging(System.Nullable<double> value);
    partial void OnChildPriceChanged();
    partial void OnAdultPriceChanging(System.Nullable<double> value);
    partial void OnAdultPriceChanged();
    partial void OnConsessionPriceChanging(System.Nullable<double> value);
    partial void OnConsessionPriceChanged();
    #endregion
		
		public matches()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Competitor", DbType="NVarChar(512) NOT NULL", CanBeNull=false)]
		public string Competitor
		{
			get
			{
				return this._Competitor;
			}
			set
			{
				if ((this._Competitor != value))
				{
					this.OnCompetitorChanging(value);
					this.SendPropertyChanging();
					this._Competitor = value;
					this.SendPropertyChanged("Competitor");
					this.OnCompetitorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChildPrice", DbType="Float")]
		public System.Nullable<double> ChildPrice
		{
			get
			{
				return this._ChildPrice;
			}
			set
			{
				if ((this._ChildPrice != value))
				{
					this.OnChildPriceChanging(value);
					this.SendPropertyChanging();
					this._ChildPrice = value;
					this.SendPropertyChanged("ChildPrice");
					this.OnChildPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdultPrice", DbType="Float")]
		public System.Nullable<double> AdultPrice
		{
			get
			{
				return this._AdultPrice;
			}
			set
			{
				if ((this._AdultPrice != value))
				{
					this.OnAdultPriceChanging(value);
					this.SendPropertyChanging();
					this._AdultPrice = value;
					this.SendPropertyChanged("AdultPrice");
					this.OnAdultPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConsessionPrice", DbType="Float")]
		public System.Nullable<double> ConsessionPrice
		{
			get
			{
				return this._ConsessionPrice;
			}
			set
			{
				if ((this._ConsessionPrice != value))
				{
					this.OnConsessionPriceChanging(value);
					this.SendPropertyChanging();
					this._ConsessionPrice = value;
					this.SendPropertyChanged("ConsessionPrice");
					this.OnConsessionPriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tickets")]
	public partial class tickets : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _BookingReference;
		
		private System.DateTime _BookingDate;
		
		private string _TicketType;
		
		private int _Quantity;
		
		private int _MatchId;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookingReferenceChanging(string value);
    partial void OnBookingReferenceChanged();
    partial void OnBookingDateChanging(System.DateTime value);
    partial void OnBookingDateChanged();
    partial void OnTicketTypeChanging(string value);
    partial void OnTicketTypeChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnMatchIdChanging(int value);
    partial void OnMatchIdChanged();
    #endregion
		
		public tickets()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingReference", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string BookingReference
		{
			get
			{
				return this._BookingReference;
			}
			set
			{
				if ((this._BookingReference != value))
				{
					this.OnBookingReferenceChanging(value);
					this.SendPropertyChanging();
					this._BookingReference = value;
					this.SendPropertyChanged("BookingReference");
					this.OnBookingReferenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingDate", DbType="Date NOT NULL")]
		public System.DateTime BookingDate
		{
			get
			{
				return this._BookingDate;
			}
			set
			{
				if ((this._BookingDate != value))
				{
					this.OnBookingDateChanging(value);
					this.SendPropertyChanging();
					this._BookingDate = value;
					this.SendPropertyChanged("BookingDate");
					this.OnBookingDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketType", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string TicketType
		{
			get
			{
				return this._TicketType;
			}
			set
			{
				if ((this._TicketType != value))
				{
					this.OnTicketTypeChanging(value);
					this.SendPropertyChanging();
					this._TicketType = value;
					this.SendPropertyChanged("TicketType");
					this.OnTicketTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatchId", DbType="Int NOT NULL")]
		public int MatchId
		{
			get
			{
				return this._MatchId;
			}
			set
			{
				if ((this._MatchId != value))
				{
					this.OnMatchIdChanging(value);
					this.SendPropertyChanging();
					this._MatchId = value;
					this.SendPropertyChanged("MatchId");
					this.OnMatchIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _name;
		
		private string _pass;
		
		private string _role;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    #endregion
		
		public users()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(64) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
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
