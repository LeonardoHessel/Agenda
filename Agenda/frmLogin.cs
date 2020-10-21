﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            LoadUsers();
            cbUser.SelectedIndex = 0;
        }

        private User user;
        public Module Module;

        public User User
        {
            get { return this.user; }
            set 
            {
                if (value != null)
                {
                    this.user = value;
                    if ((cbUser.SelectedItem as User).ID != this.User.ID)
                        cbUser.SelectedItem = this.User;
                }
            }
        }

        private void LoadUsers()
        {
            List<User> users = User.GetUsers(Util.ActiveStatus.Active, null, true);
            foreach (User user in users)
            {
                cbUser.Items.Add(user.Login);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnClose.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.User = cbUser.SelectedItem as User;



            if (this.User.CheckPassword(txtPassword.Text))
            {
                if (Access.CheckAccess(this.User.ID, this.Module.ID).HasAccess)
                {
                    this.DialogResult = DialogResult.Yes;
                }
            }

            //this.Permissao = false;
            //string login = cbLogin.Text;
            //string senha = txtSenha.Text;
            //foreach (Usuario user in TodosUsuarios)
            //{
            //    if (user.Login == login && user.Senha == senha)
            //    {
            //        this.Usuario = user;
            //        user.LoadPermissoesUsuario();
            //        bool perm = user.VerifPermissao(ID_Modulo);
            //        if (perm)
            //        {
            //            this.Permissao = true;
            //            this.DialogResult = DialogResult.Yes;
            //            this.Close();
            //        }
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<User> users = User.GetUsers(Util.ActiveStatus.Active, null, true);
            this.user = users.Find(x => x.Login == cbUser.Text);
        }
    }
}
