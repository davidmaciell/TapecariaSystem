﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapecariaSystem
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrocliente_Click(object sender, EventArgs e)
        {
            cadastro.FormCadastroClient frm = new cadastro.FormCadastroClient();
            frm.ShowDialog();
        }

        
    }
}
