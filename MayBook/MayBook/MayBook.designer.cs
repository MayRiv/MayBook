﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MayBook
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MayBook")]
	public partial class MayBookDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertUsers(User instance);
    partial void UpdateUsers(User instance);
    partial void DeleteUsers(User instance);
    partial void InsertPosts(Posts instance);
    partial void UpdatePosts(Posts instance);
    partial void DeletePosts(Posts instance);
    #endregion
		
		public MayBookDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MayBookConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MayBookDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MayBookDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MayBookDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MayBookDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Posts> Posts
		{
			get
			{
				return this.GetTable<Posts>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _Login;
		
		private string _Password;
		
		private string _Name;
		
		private System.DateTime _RegisterDate;
		
		private System.Data.Linq.Binary _Avatar;
		
		private System.Nullable<int> _AvatarSize;
		
		private int _PostsNumber;
		
		private EntitySet<Posts> _Posts;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnLoginChanging(string value);
    partial void OnLoginChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnRegisterDateChanging(System.DateTime value);
    partial void OnRegisterDateChanged();
    partial void OnAvatarChanging(System.Data.Linq.Binary value);
    partial void OnAvatarChanged();
    partial void OnAvatarSizeChanging(System.Nullable<int> value);
    partial void OnAvatarSizeChanged();
    partial void OnPostsNumberChanging(int value);
    partial void OnPostsNumberChanged();
    #endregion
		
		public User()
		{
			this._Posts = new EntitySet<Posts>(new Action<Posts>(this.attach_Posts), new Action<Posts>(this.detach_Posts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				if ((this._Login != value))
				{
					this.OnLoginChanging(value);
					this.SendPropertyChanging();
					this._Login = value;
					this.SendPropertyChanged("Login");
					this.OnLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(32) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegisterDate", DbType="Date NOT NULL")]
		public System.DateTime RegisterDate
		{
			get
			{
				return this._RegisterDate;
			}
			set
			{
				if ((this._RegisterDate != value))
				{
					this.OnRegisterDateChanging(value);
					this.SendPropertyChanging();
					this._RegisterDate = value;
					this.SendPropertyChanged("RegisterDate");
					this.OnRegisterDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Avatar", DbType="Binary(800)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Avatar
		{
			get
			{
				return this._Avatar;
			}
			set
			{
				if ((this._Avatar != value))
				{
					this.OnAvatarChanging(value);
					this.SendPropertyChanging();
					this._Avatar = value;
					this.SendPropertyChanged("Avatar");
					this.OnAvatarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AvatarSize", DbType="Int")]
		public System.Nullable<int> AvatarSize
		{
			get
			{
				return this._AvatarSize;
			}
			set
			{
				if ((this._AvatarSize != value))
				{
					this.OnAvatarSizeChanging(value);
					this.SendPropertyChanging();
					this._AvatarSize = value;
					this.SendPropertyChanged("AvatarSize");
					this.OnAvatarSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostsNumber", DbType="Int NOT NULL")]
		public int PostsNumber
		{
			get
			{
				return this._PostsNumber;
			}
			set
			{
				if ((this._PostsNumber != value))
				{
					this.OnPostsNumberChanging(value);
					this.SendPropertyChanging();
					this._PostsNumber = value;
					this.SendPropertyChanged("PostsNumber");
					this.OnPostsNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Posts", Storage="_Posts", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Posts> Posts
		{
			get
			{
				return this._Posts;
			}
			set
			{
				this._Posts.Assign(value);
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
		
		private void attach_Posts(Posts entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void detach_Posts(Posts entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Posts")]
	public partial class Posts : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PostId;
		
		private int _UserId;
		
		private string _Body;
		
		private System.DateTime _CreationDate;
		
		private System.DateTime _EditDate;
		
		private EntityRef<User> _Users;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostIdChanging(int value);
    partial void OnPostIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnCreationDateChanging(System.DateTime value);
    partial void OnCreationDateChanged();
    partial void OnEditDateChanging(System.DateTime value);
    partial void OnEditDateChanged();
    #endregion
		
		public Posts()
		{
			this._Users = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PostId
		{
			get
			{
				return this._PostId;
			}
			set
			{
				if ((this._PostId != value))
				{
					this.OnPostIdChanging(value);
					this.SendPropertyChanging();
					this._PostId = value;
					this.SendPropertyChanged("PostId");
					this.OnPostIdChanged();
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
					if (this._Users.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NChar(142) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreationDate", DbType="Date NOT NULL")]
		public System.DateTime CreationDate
		{
			get
			{
				return this._CreationDate;
			}
			set
			{
				if ((this._CreationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._CreationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditDate", DbType="Date NOT NULL")]
		public System.DateTime EditDate
		{
			get
			{
				return this._EditDate;
			}
			set
			{
				if ((this._EditDate != value))
				{
					this.OnEditDateChanging(value);
					this.SendPropertyChanging();
					this._EditDate = value;
					this.SendPropertyChanged("EditDate");
					this.OnEditDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Posts", Storage="_Users", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public User Users
		{
			get
			{
				return this._Users.Entity;
			}
			set
			{
				User previousValue = this._Users.Entity;
				if (((previousValue != value) 
							|| (this._Users.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Users.Entity = null;
						previousValue.Posts.Remove(this);
					}
					this._Users.Entity = value;
					if ((value != null))
					{
						value.Posts.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("Users");
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
