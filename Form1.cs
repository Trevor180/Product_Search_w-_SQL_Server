﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WootenT_ProductSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            //Getting all columns
            //Press ESC to use this button also
            this.productTableAdapter.Fill(this.productDataSet.Product);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Finds what the user put in
            //Also you can press the enter key
            this.productTableAdapter.SearchDesc(this.productDataSet.Product, searchTextBox.Text);
        }
    }
}
