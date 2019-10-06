using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentAccount
{
    public partial class FormRaporlar : Form
    {
        public FormRaporlar()
        {
            InitializeComponent();
        }
        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            lsvRaporlar.Items.Clear();
            Sorgula();
            ListeyeYaz(Sorgula());
            KarZarar(Sorgula());
            ParametreleriTemizle();
        }
        private List<Sale> Sorgula()
        {
            Sale sale = new Sale()
            {
                Product = (Product)cmbUrun.SelectedItem,
                Customer = (Customer)cmbMusteri.SelectedItem,
                Employee = (Employee)cmbCalisan.SelectedItem
            };

            bool urunGirilmediMi = string.IsNullOrWhiteSpace(cmbUrun.Text);
            bool musteriGirilmediMi = string.IsNullOrWhiteSpace(cmbMusteri.Text);
            bool calisanGirilmediMi = string.IsNullOrWhiteSpace(cmbCalisan.Text);


            if (urunGirilmediMi && musteriGirilmediMi && calisanGirilmediMi)
            {
                return Singleton.Context.Sales
                            .Where(s => s.SellDate >= dtpBaslangic.Value && s.SellDate <= dtpBitis.Value)
                            .ToList();
            }
            else if (urunGirilmediMi && musteriGirilmediMi)
            {
                return Singleton.Context.Sales
                            .Where(s => s.EmployeeID.Equals(sale.Employee.ID)
                            && s.SellDate >= dtpBaslangic.Value && s.SellDate <= dtpBitis.Value)
                            .ToList();
            }
            else if (musteriGirilmediMi && calisanGirilmediMi)
            {
                return Singleton.Context.Sales
                            .Where(s => s.ProductID.Equals(sale.Product.ID)
                            && s.SellDate >= dtpBaslangic.Value && s.SellDate <= dtpBitis.Value)
                            .ToList();
            }
            else if (urunGirilmediMi && calisanGirilmediMi)
            {
                return Singleton.Context.Sales
                            .Where(s => s.CustomerID.Equals(sale.Customer.ID)
                            && s.SellDate >= dtpBaslangic.Value && s.SellDate <= dtpBitis.Value)
                            .ToList();
            }
            else if (urunGirilmediMi)
            {
                return Singleton.Context.Sales
                            .Where(s => s.CustomerID.Equals(sale.Customer.ID)
                            && s.EmployeeID.Equals(sale.Employee.ID)
                            && s.SellDate >= dtpBaslangic.Value && s.SellDate <= dtpBitis.Value)
                            .ToList();
            }
            else if (musteriGirilmediMi)
            {
                return Singleton.Context.Sales
                            .Where(s => s.ProductID.Equals(sale.Product.ID)
                            && s.EmployeeID.Equals(sale.Employee.ID)
                            && s.SellDate >= dtpBaslangic.Value && s.SellDate <= dtpBitis.Value)
                            .ToList();
            }
            else
            {
                return Singleton.Context.Sales
                            .Where(s => s.CustomerID.Equals(sale.Customer.ID)
                            && s.ProductID.Equals(sale.Product.ID)
                            && s.SellDate >= dtpBaslangic.Value && s.SellDate <= dtpBitis.Value)
                            .ToList();
            }
        }
        private void ParametreleriTemizle()
        {
            cmbMusteri.SelectedIndex = -1;
            cmbUrun.SelectedIndex = -1;
            cmbCalisan.SelectedIndex = -1;
        }
        private void KarZarar(List<Sale> satis)
        {
            decimal toplam = 0;
            foreach (var item in satis)
            {
                decimal alisFiyati = Singleton.Context.Products
                    .Where(p => p.ID.Equals(item.ProductID))
                    .Select(p => p.PurchasePrice).FirstOrDefault();
                toplam += item.Quantity * (item.DiscountedPrice - alisFiyati);
            }
            lblKarZarar.Text = toplam.ToString() + "₺";
        }
        private void ListeyeYaz(List<Sale> satis)
        {
            foreach (var item in satis)
            {
                string[] degerler = new string[8]
                {
                    item.ID.ToString(),
                    item.Product.ProductName,
                    item.Quantity.ToString(),
                    item.Customer.FirstName+" "+item.Customer.LastName,
                    item.SellDate.ToString(),
                    item.Discount.ToString(),
                    item.DiscountedPrice.ToString(),
                    item.Employee.FirstName+" "+item.Employee.LastName
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvRaporlar.Items.Add(viewItem);
            }
        }
        private void CmbMusteri_TextUpdate(object sender, EventArgs e)
        {
            cmbMusteri.DroppedDown = false;
            cmbMusteri.DataSource = null;

            string girilenDegeriSaklayan = cmbMusteri.Text;

            var custormers = Singleton.Context.Customers.Where(c => (c.FirstName + " " + c.LastName).Contains(cmbMusteri.Text)).ToList();
            cmbMusteri.DisplayMember = "FullName";
            cmbMusteri.ValueMember = "ID";
            cmbMusteri.DataSource = custormers;
            cmbMusteri.SelectedIndex = -1;
            cmbMusteri.Text = girilenDegeriSaklayan;
            cmbMusteri.Select(cmbMusteri.Text.Length, 0);

            cmbMusteri.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }
        private void CmbUrun_TextUpdate(object sender, EventArgs e)
        {

            cmbUrun.DroppedDown = false;
            cmbUrun.DataSource = null;

            string girilenDegeriSaklayan = cmbUrun.Text;

            var degerler = Singleton.Context.Products.Where(p => p.ProductName.Contains(cmbUrun.Text)).ToList();
            cmbUrun.DisplayMember = "ProductName";
            cmbUrun.ValueMember = "ID";
            cmbUrun.DataSource = degerler;
            cmbUrun.SelectedIndex = -1;
            cmbUrun.Text = girilenDegeriSaklayan;
            cmbUrun.Select(cmbUrun.Text.Length, 0);

            cmbUrun.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }
        private void CmbCalisan_TextUpdate(object sender, EventArgs e)
        {
            cmbCalisan.DroppedDown = false;
            cmbCalisan.DataSource = null;

            string girilenDegeriSaklayan = cmbCalisan.Text;

            var degerler = Singleton.Context.Employees.Where(em => (em.FirstName + " " + em.LastName).Contains(cmbCalisan.Text)).ToList();
            cmbCalisan.DisplayMember = "FullName";
            cmbCalisan.ValueMember = "ID";
            cmbCalisan.DataSource = degerler;
            cmbCalisan.SelectedIndex = -1;
            cmbCalisan.Text = girilenDegeriSaklayan;
            cmbCalisan.Select(cmbCalisan.Text.Length, 0);

            cmbCalisan.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }
    }
}
