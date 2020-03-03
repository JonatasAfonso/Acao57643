using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExercicioResolvido.Models;

namespace ExercicioResolvido
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private List<Empregado> _empregados;
        protected void Page_Load(object sender, EventArgs e)
        {
            _empregados = new List<Empregado>();
            if (!IsPostBack)
            {
                txtDataNascimento.Text = DateTime.Today.ToString(CultureInfo.InvariantCulture);
            }
        }

        protected void btnGravar_OnClick_Click(object sender, EventArgs e)
        {
            if (!IsPostBack) return;

            var empregado = new Empregado
            {
                Nome = txtNomeEmpregado.Text,
                Sobrenome = txtSobrenome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                DataNascimento = DateTime.Parse(txtDataNascimento.Text)
            };

            _empregados.Add(empregado);
            LimparTela();
        }


        protected void LimparTela()
        {
            txtNomeEmpregado.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtConfirmacaoEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtDataNascimento.Text = DateTime.Today.ToString(CultureInfo.InvariantCulture);
            Response.Redirect("Default.aspx");
        }
    }
}