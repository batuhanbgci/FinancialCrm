﻿using FinancialCrm;
using MyFinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

       
FinancialCrmDbEntities db= new FinancialCrmDbEntities();

        
        private void FrmBanks_Load(object sender, EventArgs e)
        {
           
            // Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x=>x.BankTitle== "Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();


            lblisBankasiBalance.Text = isBankasiBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";

            // Banka hareketleri

            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount + " " + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " " + bankProcess5.ProcessDate;

        }

       

        private void btnCategories_Click_1(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            FrmTransactions frm = new FrmTransactions();
            frm.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBillings_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}