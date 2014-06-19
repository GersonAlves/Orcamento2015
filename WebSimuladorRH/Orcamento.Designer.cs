﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WebSimuladorRH
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DbOrcamento : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DbOrcamento object using the connection string found in the 'DbOrcamento' section of the application configuration file.
        /// </summary>
        public DbOrcamento() : base("name=DbOrcamento", "DbOrcamento")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DbOrcamento object.
        /// </summary>
        public DbOrcamento(string connectionString) : base(connectionString, "DbOrcamento")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DbOrcamento object.
        /// </summary>
        public DbOrcamento(EntityConnection connection) : base(connection, "DbOrcamento")
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
        public ObjectSet<Cargos> Cargos
        {
            get
            {
                if ((_Cargos == null))
                {
                    _Cargos = base.CreateObjectSet<Cargos>("Cargos");
                }
                return _Cargos;
            }
        }
        private ObjectSet<Cargos> _Cargos;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CentroCusto> CentroCusto
        {
            get
            {
                if ((_CentroCusto == null))
                {
                    _CentroCusto = base.CreateObjectSet<CentroCusto>("CentroCusto");
                }
                return _CentroCusto;
            }
        }
        private ObjectSet<CentroCusto> _CentroCusto;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Empresa> Empresa
        {
            get
            {
                if ((_Empresa == null))
                {
                    _Empresa = base.CreateObjectSet<Empresa>("Empresa");
                }
                return _Empresa;
            }
        }
        private ObjectSet<Empresa> _Empresa;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Funcionarios> Funcionarios
        {
            get
            {
                if ((_Funcionarios == null))
                {
                    _Funcionarios = base.CreateObjectSet<Funcionarios>("Funcionarios");
                }
                return _Funcionarios;
            }
        }
        private ObjectSet<Funcionarios> _Funcionarios;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Cargos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCargos(Cargos cargos)
        {
            base.AddObject("Cargos", cargos);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CentroCusto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCentroCusto(CentroCusto centroCusto)
        {
            base.AddObject("CentroCusto", centroCusto);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Empresa EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmpresa(Empresa empresa)
        {
            base.AddObject("Empresa", empresa);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Funcionarios EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFuncionarios(Funcionarios funcionarios)
        {
            base.AddObject("Funcionarios", funcionarios);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBOrcamentoModel", Name="Cargos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cargos : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cargos object.
        /// </summary>
        /// <param name="id_Cargo">Initial value of the id_Cargo property.</param>
        public static Cargos CreateCargos(global::System.Int64 id_Cargo)
        {
            Cargos cargos = new Cargos();
            cargos.id_Cargo = id_Cargo;
            return cargos;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id_Cargo
        {
            get
            {
                return _id_Cargo;
            }
            set
            {
                if (_id_Cargo != value)
                {
                    Onid_CargoChanging(value);
                    ReportPropertyChanging("id_Cargo");
                    _id_Cargo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_Cargo");
                    Onid_CargoChanged();
                }
            }
        }
        private global::System.Int64 _id_Cargo;
        partial void Onid_CargoChanging(global::System.Int64 value);
        partial void Onid_CargoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RJ_FUNCAO
        {
            get
            {
                return _RJ_FUNCAO;
            }
            set
            {
                OnRJ_FUNCAOChanging(value);
                ReportPropertyChanging("RJ_FUNCAO");
                _RJ_FUNCAO = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RJ_FUNCAO");
                OnRJ_FUNCAOChanged();
            }
        }
        private global::System.String _RJ_FUNCAO;
        partial void OnRJ_FUNCAOChanging(global::System.String value);
        partial void OnRJ_FUNCAOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RJ_DESC
        {
            get
            {
                return _RJ_DESC;
            }
            set
            {
                OnRJ_DESCChanging(value);
                ReportPropertyChanging("RJ_DESC");
                _RJ_DESC = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RJ_DESC");
                OnRJ_DESCChanged();
            }
        }
        private global::System.String _RJ_DESC;
        partial void OnRJ_DESCChanging(global::System.String value);
        partial void OnRJ_DESCChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBOrcamentoModel", Name="CentroCusto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CentroCusto : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CentroCusto object.
        /// </summary>
        /// <param name="id_CentroCusto">Initial value of the id_CentroCusto property.</param>
        public static CentroCusto CreateCentroCusto(global::System.Int64 id_CentroCusto)
        {
            CentroCusto centroCusto = new CentroCusto();
            centroCusto.id_CentroCusto = id_CentroCusto;
            return centroCusto;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id_CentroCusto
        {
            get
            {
                return _id_CentroCusto;
            }
            set
            {
                if (_id_CentroCusto != value)
                {
                    Onid_CentroCustoChanging(value);
                    ReportPropertyChanging("id_CentroCusto");
                    _id_CentroCusto = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_CentroCusto");
                    Onid_CentroCustoChanged();
                }
            }
        }
        private global::System.Int64 _id_CentroCusto;
        partial void Onid_CentroCustoChanging(global::System.Int64 value);
        partial void Onid_CentroCustoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RA_CC
        {
            get
            {
                return _RA_CC;
            }
            set
            {
                OnRA_CCChanging(value);
                ReportPropertyChanging("RA_CC");
                _RA_CC = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RA_CC");
                OnRA_CCChanged();
            }
        }
        private global::System.String _RA_CC;
        partial void OnRA_CCChanging(global::System.String value);
        partial void OnRA_CCChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String I3_DESC
        {
            get
            {
                return _I3_DESC;
            }
            set
            {
                OnI3_DESCChanging(value);
                ReportPropertyChanging("I3_DESC");
                _I3_DESC = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("I3_DESC");
                OnI3_DESCChanged();
            }
        }
        private global::System.String _I3_DESC;
        partial void OnI3_DESCChanging(global::System.String value);
        partial void OnI3_DESCChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBOrcamentoModel", Name="Empresa")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Empresa : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Empresa object.
        /// </summary>
        /// <param name="id_Funcionarios">Initial value of the id_Funcionarios property.</param>
        public static Empresa CreateEmpresa(global::System.Int64 id_Funcionarios)
        {
            Empresa empresa = new Empresa();
            empresa.id_Funcionarios = id_Funcionarios;
            return empresa;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id_Funcionarios
        {
            get
            {
                return _id_Funcionarios;
            }
            set
            {
                if (_id_Funcionarios != value)
                {
                    Onid_FuncionariosChanging(value);
                    ReportPropertyChanging("id_Funcionarios");
                    _id_Funcionarios = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_Funcionarios");
                    Onid_FuncionariosChanged();
                }
            }
        }
        private global::System.Int64 _id_Funcionarios;
        partial void Onid_FuncionariosChanging(global::System.Int64 value);
        partial void Onid_FuncionariosChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cod_Empresa
        {
            get
            {
                return _cod_Empresa;
            }
            set
            {
                Oncod_EmpresaChanging(value);
                ReportPropertyChanging("cod_Empresa");
                _cod_Empresa = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cod_Empresa");
                Oncod_EmpresaChanged();
            }
        }
        private global::System.String _cod_Empresa;
        partial void Oncod_EmpresaChanging(global::System.String value);
        partial void Oncod_EmpresaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nome_Empresa
        {
            get
            {
                return _nome_Empresa;
            }
            set
            {
                Onnome_EmpresaChanging(value);
                ReportPropertyChanging("nome_Empresa");
                _nome_Empresa = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("nome_Empresa");
                Onnome_EmpresaChanged();
            }
        }
        private global::System.String _nome_Empresa;
        partial void Onnome_EmpresaChanging(global::System.String value);
        partial void Onnome_EmpresaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CNPJ
        {
            get
            {
                return _CNPJ;
            }
            set
            {
                OnCNPJChanging(value);
                ReportPropertyChanging("CNPJ");
                _CNPJ = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CNPJ");
                OnCNPJChanged();
            }
        }
        private global::System.String _CNPJ;
        partial void OnCNPJChanging(global::System.String value);
        partial void OnCNPJChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBOrcamentoModel", Name="Funcionarios")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Funcionarios : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Funcionarios object.
        /// </summary>
        /// <param name="iD_FUNCIONARIO">Initial value of the ID_FUNCIONARIO property.</param>
        /// <param name="eMPRESA">Initial value of the EMPRESA property.</param>
        /// <param name="rA_FILIAL">Initial value of the RA_FILIAL property.</param>
        /// <param name="rA_MAT">Initial value of the RA_MAT property.</param>
        public static Funcionarios CreateFuncionarios(global::System.Int64 iD_FUNCIONARIO, global::System.String eMPRESA, global::System.String rA_FILIAL, global::System.String rA_MAT)
        {
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.ID_FUNCIONARIO = iD_FUNCIONARIO;
            funcionarios.EMPRESA = eMPRESA;
            funcionarios.RA_FILIAL = rA_FILIAL;
            funcionarios.RA_MAT = rA_MAT;
            return funcionarios;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID_FUNCIONARIO
        {
            get
            {
                return _ID_FUNCIONARIO;
            }
            set
            {
                if (_ID_FUNCIONARIO != value)
                {
                    OnID_FUNCIONARIOChanging(value);
                    ReportPropertyChanging("ID_FUNCIONARIO");
                    _ID_FUNCIONARIO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID_FUNCIONARIO");
                    OnID_FUNCIONARIOChanged();
                }
            }
        }
        private global::System.Int64 _ID_FUNCIONARIO;
        partial void OnID_FUNCIONARIOChanging(global::System.Int64 value);
        partial void OnID_FUNCIONARIOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EMPRESA
        {
            get
            {
                return _EMPRESA;
            }
            set
            {
                if (_EMPRESA != value)
                {
                    OnEMPRESAChanging(value);
                    ReportPropertyChanging("EMPRESA");
                    _EMPRESA = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("EMPRESA");
                    OnEMPRESAChanged();
                }
            }
        }
        private global::System.String _EMPRESA;
        partial void OnEMPRESAChanging(global::System.String value);
        partial void OnEMPRESAChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RA_FILIAL
        {
            get
            {
                return _RA_FILIAL;
            }
            set
            {
                if (_RA_FILIAL != value)
                {
                    OnRA_FILIALChanging(value);
                    ReportPropertyChanging("RA_FILIAL");
                    _RA_FILIAL = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("RA_FILIAL");
                    OnRA_FILIALChanged();
                }
            }
        }
        private global::System.String _RA_FILIAL;
        partial void OnRA_FILIALChanging(global::System.String value);
        partial void OnRA_FILIALChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RA_MAT
        {
            get
            {
                return _RA_MAT;
            }
            set
            {
                if (_RA_MAT != value)
                {
                    OnRA_MATChanging(value);
                    ReportPropertyChanging("RA_MAT");
                    _RA_MAT = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("RA_MAT");
                    OnRA_MATChanged();
                }
            }
        }
        private global::System.String _RA_MAT;
        partial void OnRA_MATChanging(global::System.String value);
        partial void OnRA_MATChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RA_NOME
        {
            get
            {
                return _RA_NOME;
            }
            set
            {
                OnRA_NOMEChanging(value);
                ReportPropertyChanging("RA_NOME");
                _RA_NOME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RA_NOME");
                OnRA_NOMEChanged();
            }
        }
        private global::System.String _RA_NOME;
        partial void OnRA_NOMEChanging(global::System.String value);
        partial void OnRA_NOMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> RA_SALARIO
        {
            get
            {
                return _RA_SALARIO;
            }
            set
            {
                OnRA_SALARIOChanging(value);
                ReportPropertyChanging("RA_SALARIO");
                _RA_SALARIO = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RA_SALARIO");
                OnRA_SALARIOChanged();
            }
        }
        private Nullable<global::System.Decimal> _RA_SALARIO;
        partial void OnRA_SALARIOChanging(Nullable<global::System.Decimal> value);
        partial void OnRA_SALARIOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> RA_ADMISSA
        {
            get
            {
                return _RA_ADMISSA;
            }
            set
            {
                OnRA_ADMISSAChanging(value);
                ReportPropertyChanging("RA_ADMISSA");
                _RA_ADMISSA = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RA_ADMISSA");
                OnRA_ADMISSAChanged();
            }
        }
        private Nullable<global::System.DateTime> _RA_ADMISSA;
        partial void OnRA_ADMISSAChanging(Nullable<global::System.DateTime> value);
        partial void OnRA_ADMISSAChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RA_CC
        {
            get
            {
                return _RA_CC;
            }
            set
            {
                OnRA_CCChanging(value);
                ReportPropertyChanging("RA_CC");
                _RA_CC = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RA_CC");
                OnRA_CCChanged();
            }
        }
        private global::System.String _RA_CC;
        partial void OnRA_CCChanging(global::System.String value);
        partial void OnRA_CCChanged();

        #endregion

    
    }

    #endregion

    
}
