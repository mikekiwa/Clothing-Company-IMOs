﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace ManufacturingTest2
{
    /// <summary>
    /// Is the window used for adding new Materials
    /// </summary>
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            Material mm = new Material();
            mm.Name = MaterialName.Text;
            mm.Description = MaterialDesc.Text;
            //mm.VendorId
            mm.Cost = Decimal.Parse(MaterialCost.Text);

            MaterialMapper.inserMaterial(mm);

            this.Close();

        }

        private void AddMaterial_Load(object sender, EventArgs e)
        {
            this.MdiParent.Size = new Size(this.Width + 5, this.Height + 35);
        }

        private void AddMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main temp = new Main();
            this.MdiParent.Size = new Size(temp.Width + 5, temp.Height + 35);
        }





    }
}
