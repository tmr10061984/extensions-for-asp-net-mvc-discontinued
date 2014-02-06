﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace GridExcelExport.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NorthwindEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
        /// </summary>
        public NorthwindEntities() : base("name=NorthwindEntities", "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(string connectionString) : base(connectionString, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(EntityConnection connection) : base(connection, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NORTHWNDModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderID">Initial value of the OrderID property.</param>
        public static Order CreateOrder(global::System.Int32 orderID)
        {
            Order order = new Order();
            order.OrderID = orderID;
            return order;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                if (_OrderID != value)
                {
                    OnOrderIDChanging(value);
                    ReportPropertyChanging("OrderID");
                    _OrderID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderID");
                    OnOrderIDChanged();
                }
            }
        }
        private global::System.Int32 _OrderID;
        partial void OnOrderIDChanging(global::System.Int32 value);
        partial void OnOrderIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                OnCustomerIDChanging(value);
                ReportPropertyChanging("CustomerID");
                _CustomerID = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CustomerID");
                OnCustomerIDChanged();
            }
        }
        private global::System.String _CustomerID;
        partial void OnCustomerIDChanging(global::System.String value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                OnEmployeeIDChanging(value);
                ReportPropertyChanging("EmployeeID");
                _EmployeeID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EmployeeID");
                OnEmployeeIDChanged();
            }
        }
        private Nullable<global::System.Int32> _EmployeeID;
        partial void OnEmployeeIDChanging(Nullable<global::System.Int32> value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                OnOrderDateChanging(value);
                ReportPropertyChanging("OrderDate");
                _OrderDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderDate");
                OnOrderDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _OrderDate;
        partial void OnOrderDateChanging(Nullable<global::System.DateTime> value);
        partial void OnOrderDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> RequiredDate
        {
            get
            {
                return _RequiredDate;
            }
            set
            {
                OnRequiredDateChanging(value);
                ReportPropertyChanging("RequiredDate");
                _RequiredDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RequiredDate");
                OnRequiredDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _RequiredDate;
        partial void OnRequiredDateChanging(Nullable<global::System.DateTime> value);
        partial void OnRequiredDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ShippedDate
        {
            get
            {
                return _ShippedDate;
            }
            set
            {
                OnShippedDateChanging(value);
                ReportPropertyChanging("ShippedDate");
                _ShippedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ShippedDate");
                OnShippedDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _ShippedDate;
        partial void OnShippedDateChanging(Nullable<global::System.DateTime> value);
        partial void OnShippedDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ShipVia
        {
            get
            {
                return _ShipVia;
            }
            set
            {
                OnShipViaChanging(value);
                ReportPropertyChanging("ShipVia");
                _ShipVia = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ShipVia");
                OnShipViaChanged();
            }
        }
        private Nullable<global::System.Int32> _ShipVia;
        partial void OnShipViaChanging(Nullable<global::System.Int32> value);
        partial void OnShipViaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Freight
        {
            get
            {
                return _Freight;
            }
            set
            {
                OnFreightChanging(value);
                ReportPropertyChanging("Freight");
                _Freight = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Freight");
                OnFreightChanged();
            }
        }
        private Nullable<global::System.Decimal> _Freight;
        partial void OnFreightChanging(Nullable<global::System.Decimal> value);
        partial void OnFreightChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ShipName
        {
            get
            {
                return _ShipName;
            }
            set
            {
                OnShipNameChanging(value);
                ReportPropertyChanging("ShipName");
                _ShipName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ShipName");
                OnShipNameChanged();
            }
        }
        private global::System.String _ShipName;
        partial void OnShipNameChanging(global::System.String value);
        partial void OnShipNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ShipAddress
        {
            get
            {
                return _ShipAddress;
            }
            set
            {
                OnShipAddressChanging(value);
                ReportPropertyChanging("ShipAddress");
                _ShipAddress = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ShipAddress");
                OnShipAddressChanged();
            }
        }
        private global::System.String _ShipAddress;
        partial void OnShipAddressChanging(global::System.String value);
        partial void OnShipAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ShipCity
        {
            get
            {
                return _ShipCity;
            }
            set
            {
                OnShipCityChanging(value);
                ReportPropertyChanging("ShipCity");
                _ShipCity = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ShipCity");
                OnShipCityChanged();
            }
        }
        private global::System.String _ShipCity;
        partial void OnShipCityChanging(global::System.String value);
        partial void OnShipCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ShipRegion
        {
            get
            {
                return _ShipRegion;
            }
            set
            {
                OnShipRegionChanging(value);
                ReportPropertyChanging("ShipRegion");
                _ShipRegion = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ShipRegion");
                OnShipRegionChanged();
            }
        }
        private global::System.String _ShipRegion;
        partial void OnShipRegionChanging(global::System.String value);
        partial void OnShipRegionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ShipPostalCode
        {
            get
            {
                return _ShipPostalCode;
            }
            set
            {
                OnShipPostalCodeChanging(value);
                ReportPropertyChanging("ShipPostalCode");
                _ShipPostalCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ShipPostalCode");
                OnShipPostalCodeChanged();
            }
        }
        private global::System.String _ShipPostalCode;
        partial void OnShipPostalCodeChanging(global::System.String value);
        partial void OnShipPostalCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ShipCountry
        {
            get
            {
                return _ShipCountry;
            }
            set
            {
                OnShipCountryChanging(value);
                ReportPropertyChanging("ShipCountry");
                _ShipCountry = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ShipCountry");
                OnShipCountryChanged();
            }
        }
        private global::System.String _ShipCountry;
        partial void OnShipCountryChanging(global::System.String value);
        partial void OnShipCountryChanged();

        #endregion
    
    }

    #endregion
    
}