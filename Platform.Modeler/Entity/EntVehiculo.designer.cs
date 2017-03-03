﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Platform.Modeler.Entity
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Servicio")]
	public partial class EntVehiculoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertVEHICULO(VEHICULO instance);
    partial void UpdateVEHICULO(VEHICULO instance);
    partial void DeleteVEHICULO(VEHICULO instance);
    #endregion
		
		public EntVehiculoDataContext() : 
				base(global::Platform.Modeler.Properties.Settings.Default.ServicioConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EntVehiculoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntVehiculoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntVehiculoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntVehiculoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<VEHICULO> VEHICULO
		{
			get
			{
				return this.GetTable<VEHICULO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VEHICULO")]
	public partial class VEHICULO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _PLACA;
		
		private string _numero_puestos;
		
		private string _COLOR;
		
		private string _VALOR_DIA;
		
		private int _MARCA_ID;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPLACAChanging(string value);
    partial void OnPLACAChanged();
    partial void Onnumero_puestosChanging(string value);
    partial void Onnumero_puestosChanged();
    partial void OnCOLORChanging(string value);
    partial void OnCOLORChanged();
    partial void OnVALOR_DIAChanging(string value);
    partial void OnVALOR_DIAChanged();
    partial void OnMARCA_IDChanging(int value);
    partial void OnMARCA_IDChanged();
    #endregion
		
		public VEHICULO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PLACA", DbType="NVarChar(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PLACA
		{
			get
			{
				return this._PLACA;
			}
			set
			{
				if ((this._PLACA != value))
				{
					this.OnPLACAChanging(value);
					this.SendPropertyChanging();
					this._PLACA = value;
					this.SendPropertyChanged("PLACA");
					this.OnPLACAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero_puestos", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string numero_puestos
		{
			get
			{
				return this._numero_puestos;
			}
			set
			{
				if ((this._numero_puestos != value))
				{
					this.Onnumero_puestosChanging(value);
					this.SendPropertyChanging();
					this._numero_puestos = value;
					this.SendPropertyChanged("numero_puestos");
					this.Onnumero_puestosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COLOR", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string COLOR
		{
			get
			{
				return this._COLOR;
			}
			set
			{
				if ((this._COLOR != value))
				{
					this.OnCOLORChanging(value);
					this.SendPropertyChanging();
					this._COLOR = value;
					this.SendPropertyChanged("COLOR");
					this.OnCOLORChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VALOR_DIA", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string VALOR_DIA
		{
			get
			{
				return this._VALOR_DIA;
			}
			set
			{
				if ((this._VALOR_DIA != value))
				{
					this.OnVALOR_DIAChanging(value);
					this.SendPropertyChanging();
					this._VALOR_DIA = value;
					this.SendPropertyChanged("VALOR_DIA");
					this.OnVALOR_DIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MARCA_ID", DbType="Int NOT NULL")]
		public int MARCA_ID
		{
			get
			{
				return this._MARCA_ID;
			}
			set
			{
				if ((this._MARCA_ID != value))
				{
					this.OnMARCA_IDChanging(value);
					this.SendPropertyChanging();
					this._MARCA_ID = value;
					this.SendPropertyChanged("MARCA_ID");
					this.OnMARCA_IDChanged();
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
