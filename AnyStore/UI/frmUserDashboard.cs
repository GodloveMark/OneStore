﻿using AnyStore.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore
{
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        //Set a public static method to specify whether the form is purchase or sales
        public static string transactionType;
        private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedIn;
        }
        /**
                private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    frmDeaCust DeaCust = new frmDeaCust();
                    DeaCust.Show();
                }

                private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    //set value on transactionType static method
                    transactionType = "Purchase";
                    frmPurchaseAndSales purchase = new frmPurchaseAndSales();
                    purchase.Show();
                    
                }

                private void salesFormsToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    //Set the value to transacionType method to sales
                    transactionType = "Sales";
                    frmPurchaseAndSales sales = new frmPurchaseAndSales();
                    sales.Show();
                    
                }

                private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    frmInventory inventory = new frmInventory();
                    inventory.Show();
                }
                **/
        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDrawer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //set value on transactionType static method
            transactionType = "Purchase";
            frmPurchaseAndSales purchase = new frmPurchaseAndSales();
            purchase.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            frmDeaCust DeaCust = new frmDeaCust();
            DeaCust.Show();

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //Set the value to transacionType method to sales
            transactionType = "Sales";
            frmPurchaseAndSales sales = new frmPurchaseAndSales();
            sales.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();

        }
    }
}
