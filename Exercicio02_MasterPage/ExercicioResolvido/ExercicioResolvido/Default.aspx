<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExercicioResolvido.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <h2>Cadastro de Empregados</h2>
    <div>
        <table>
            <tr>
                <td>Nome do Empregado</td>
                <td>
                    <asp:TextBox ID="txtNomeEmpregado" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="nomeValidator" runat="server" ErrorMessage="Nome Empregado é Obrigatório" ControlToValidate="txtNomeEmpregado"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Sobrenome do Empregado</td>
                <td>
                    <asp:TextBox ID="txtSobrenome" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="SobrenomeValidator" runat="server" ErrorMessage="Sobrenome é obrigatório" ControlToValidate="txtSobrenome"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Contato Telefônico</td>
                <td>
                    <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="TelefoneValidator" runat="server" ErrorMessage="Telefone Inválido" ControlToValidate="txtTelefone" ValidationExpression="(9[1236]\d) ?(\d{3}) ?(\d{3})"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Data de Nascimento</td>
                <td>
                    <asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="NascimentoValidator" runat="server" ErrorMessage="Data de Nascimento fora do formato dd/mm/aaaa" ValidationExpression="^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$" ControlToValidate="txtDataNascimento"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="EmailValidator1" runat="server" ErrorMessage="O Email é obrigatório" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="EmailValidator2" runat="server" ErrorMessage="Email em formato incorreto" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Confirmação Email</td>
                <td>
                    <asp:TextBox ID="txtConfirmacaoEmail" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="ConfirmacaoValidator1" runat="server" ErrorMessage="Confirmação de email obrigatória" ControlToValidate="txtConfirmacaoEmail"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ConfirmacaoValidator2" runat="server" ErrorMessage="Email em formato inválido" ControlToValidate="txtConfirmacaoEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:CompareValidator ID="ConfirmacaoValidator3" runat="server" ErrorMessage="Email e confirmação são diferentes" ControlToCompare="txtEmail" ControlToValidate="txtConfirmacaoEmail"></asp:CompareValidator>
                </td>
            </tr>
        </table>

    </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
    <p>
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_OnClick_Click" Text="Gravar" Style="width: 93px" />
    </p>

</asp:Content>
