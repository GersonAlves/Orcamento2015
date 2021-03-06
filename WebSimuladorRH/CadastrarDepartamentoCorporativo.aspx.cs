﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Orcamento.Controller;
using Orcamento.Domain.Gerenciamento;
using Orcamento.Domain;
using Orcamento.Domain.DB.Repositorio;



namespace WebSimuladorRH
{
    public partial class CadastrarDepartamentoCorporativo : BasePage
    {
        private DepartamentoController controller;
        private string funcaoDaPagina;

        public DepartamentoController Controller
        {
            private get { return controller; }
            set { controller = value; }
        }

        public string FuncaoDaPagina
        {
            get { return funcaoDaPagina; }
            set { funcaoDaPagina = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.funcaoDaPagina = Request.QueryString["funcao"];
            this.controller = new DepartamentoController();

            if (!Page.IsPostBack)
            {
                PopularDropDownDeHospitais();
                PopularRepeaterDeCentrosDeCusto();
            }
        }

        public void PopularDropDownDeHospitais()
        {
            if (funcaoDaPagina == "a")
            {
                ddlHospitais.DataSource = Controller.BuscarTodosOsDepartamentos();
                ddlHospitais.DataValueField = "Id";
                ddlHospitais.DataTextField = "Nome";
                ddlHospitais.DataBind();

                ddlHospitais.Items.Insert(0, new ListItem("Selecione", ""));

                divAlteracao.Visible = true;
            }

            ddlHospitalASerCopiado.DataSource = Controller.BuscarTodosOsDepartamentos();
            ddlHospitalASerCopiado.DataValueField = "Id";
            ddlHospitalASerCopiado.DataTextField = "Nome";
            ddlHospitalASerCopiado.DataBind();

            ddlHospitalASerCopiado.Items.Insert(0, new ListItem("Selecione", ""));

        }

        public void PopularRepeaterDeCentrosDeCusto()
        {

            rptCentrosDeCusto.DataSource = Controller.BuscarTodosOsCentrosDeCusto().OrderBy(x => x.Nome);
            rptCentrosDeCusto.DataBind();
        }

        protected void rptCentrosDeCusto_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            foreach (RepeaterItem item in rptCentrosDeCusto.Items)
            {
                if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                {
                    var codigoSetor = (Label)item.FindControl("lblCodigoSetor");

                    if (txtIdHospital.Value != string.Empty)
                    {
                        IList<CentroDeCusto> listaDeCentrosDeCusto = Controller.BuscarTodosOsCentrosDeCustoDeUmDepartamento(int.Parse(txtIdHospital.Value));

                        foreach (var centroDeCusto in listaDeCentrosDeCusto)
                        {
                            if (centroDeCusto.CodigoDoCentroDeCusto == codigoSetor.Text)
                            {
                                ((CheckBox)item.FindControl("chkSelecionado")).Checked = true;
                            }
                        }
                    }
                }
            }
        }

        protected void btnCopiarCentrosDeCusto_Click(object sender, EventArgs e)
        {
            txtIdHospital.Value = ddlHospitalASerCopiado.SelectedValue;

            PopularRepeaterDeCentrosDeCusto();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {


                var antigaListaDeCentrosDeCusto = Controller.BuscarTodosOsCentrosDeCustoDeUmDepartamento(int.Parse(Session["DepartamentoLogadoId"].ToString()));
                Departamento departamento;

                if (FuncaoDaPagina == "a")
                {
                    departamento = Controller.BuscarDepartamento(int.Parse(ddlHospitais.SelectedValue));
                    departamento.Nome = txtNome.Text;
                }
                else
                {
                    departamento = new Setor(txtNome.Text);
                }

                foreach (RepeaterItem item in rptCentrosDeCusto.Items)
                {
                    if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                    {
                        if (((CheckBox)item.FindControl("chkSelecionado")).Checked)
                        {

                            int centroDeCustoId = int.Parse(((HiddenField)item.FindControl("hdnIdSetor")).Value);

                            if (!departamento.CentrosDeCusto.Any(c => c.Id == centroDeCustoId))
                                departamento.Adicionar(controller.ObterCentroDeCustoPor(centroDeCustoId: centroDeCustoId));
                        }
                        else
                        {
                            int centroDeCustoId = int.Parse(((HiddenField)item.FindControl("hdnIdSetor")).Value);
                            if (departamento.CentrosDeCusto.Any(c => c.Id == centroDeCustoId))
                            {
                                if (departamento.Id > 0)
                                {
                                    var nome = ((HiddenField)item.FindControl("hdnNomeSetor")).Value;
                                    Orcamentos orcamentos = new Orcamentos();

                                    var orcamentosDeViagem = orcamentos.TodosOrcamentosDeViagemPor(departamento.CentrosDeCusto.Where(c => c.Id == centroDeCustoId).FirstOrDefault(), departamento);
                                    var orcamentosOperacionais = orcamentos.TodosOrcamentosOperacionaisPor(departamento.CentrosDeCusto.Where(c => c.Id == centroDeCustoId).FirstOrDefault(), departamento);
                                    var funcionarios = departamento.CentrosDeCusto.Where(c => c.Id == centroDeCustoId).FirstOrDefault().Funcionarios.Where(d => d.Departamento == departamento);

                                    if (orcamentosDeViagem != null && orcamentosDeViagem.Count > 0)
                                        throw new Exception("Não é possivel Retirar o Centro de Custo:" + nome + " pois ele está atrelado a pelomenos um Orcamento de viagem.");

                                    if (orcamentosOperacionais != null && orcamentosOperacionais.Count > 0)
                                        throw new Exception("Não é possivel Retirar o Centro de Custo:" + nome + " pois ele está atrelado a pelomenos um Orcamento de despesa operacional.");

                                    if (funcionarios != null && funcionarios.Count() > 0)
                                        throw new Exception("Não é possivel Retirar o Centro de Custo:" + nome + " pois ele está atrelado a pelomenos um funcionário com este Departamento.");

                                }
                                departamento.CentrosDeCusto.Remove(departamento.CentrosDeCusto.Where(c => c.Id == centroDeCustoId).FirstOrDefault());
                            }
                        }
                    }
                }


                Controller.SalvarDepartamento(departamento);
                Notificacao = "Departamento salvo com sucesso";

            }
            catch (Exception ex)
            {

                Notificacao = ex.Message;
            }


            EnviarMensagem();
            LimparCampos();
            PopularRepeaterDeCentrosDeCusto();
        }

        protected void ddlHospitais_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNome.Text = ddlHospitais.SelectedItem.Text;
            txtIdHospital.Value = ddlHospitais.SelectedValue;

            PopularRepeaterDeCentrosDeCusto();
        }

        private void LimparCampos()
        {
            txtIdHospital.Value = string.Empty;
            txtNome.Text = string.Empty;

            ddlHospitais.SelectedValue = "";
            ddlHospitalASerCopiado.SelectedValue = "";
        }
    }
}