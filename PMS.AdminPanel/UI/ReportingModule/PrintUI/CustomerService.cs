﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.AdminPanel.UI.ReportingModule.PrintUI
{
    public partial class CustomerService : Form
    {
        public CustomerService()
        {
            InitializeComponent();
        }

        private void CustomerService_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = customerServiceRep1;
            crystalReportViewer1.Refresh();
        }
    }
}
