using System;
using System.Windows.Forms;

namespace projeto_csharp
{
    public partial class FormPessoa : Form
    {
        public FormPessoa()
        {
            InitializeComponent();
        }

        private void radioButtonFisica_CheckedChanged(object sender, EventArgs e)
        {
            setarMascaraCpfCnpj(true);
        }

        private void radioButtonJuridica_CheckedChanged(object sender, EventArgs e)
        {
            setarMascaraCpfCnpj(false);
        }

        private void FormPessoa_Load(object sender, EventArgs e)
        {
            setarMascaraCpfCnpj(true);
            validarCpfCnpjParaPermitirSalvar();
        }

        private void setarMascaraCpfCnpj(bool tipo)
        {
            if (tipo)
            {//verdadeiro é fisica
                maskedTextBoxCnpjCpf.Text = "";
                maskedTextBoxCnpjCpf.Mask = "000,000,000-00";
            }
            else
            {//falso juridica
                maskedTextBoxCnpjCpf.Text = "";
                maskedTextBoxCnpjCpf.Mask = "00,000,000/0000-00";
            }
        }

        private void maskedTextBoxCnpjCpf_TextChanged(object sender, EventArgs e)
        {
            validarCpfCnpjParaPermitirSalvar();
        }


        private void validarCpfCnpjParaPermitirSalvar()
        {
            if (radioButtonFisica.Checked)
            {
                if (Validacao.IsCpf(maskedTextBoxCnpjCpf.Text))
                {
                    btnSalvar.Enabled = true;
                }
                else
                {
                    btnSalvar.Enabled = false;
                }
            }

            if (radioButtonJuridica.Checked)
            {
                if (Validacao.IsCnpj(maskedTextBoxCnpjCpf.Text))
                {
                    btnSalvar.Enabled = true;
                }
                else
                {
                    btnSalvar.Enabled = false;
                }
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCnpjCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
