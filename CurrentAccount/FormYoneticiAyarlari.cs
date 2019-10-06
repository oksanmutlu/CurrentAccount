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
    public partial class FormYoneticiAyarlari : Form
    {        
        public FormYoneticiAyarlari()
        {
            InitializeComponent();           
        }

        private void FormKullaniciAyarlari_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }
       
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lsvCalisanlar.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemi öncesinde bir çalışan seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvCalisanlar.SelectedItems[0];
            Employee employee = (Employee)item.Tag;

            FormCalisanGuncelle frm = new FormCalisanGuncelle(employee, Singleton.Context);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FormCalisanEkle frm = new FormCalisanEkle();
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lsvCalisanlar.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir çalışan seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvCalisanlar.SelectedItems[0];
            Employee employee = (Employee)item.Tag;
            Singleton.Context.Employees.Remove(employee);
            WinFormHelpers.KontrolluKaydet(Singleton.Context,"Çalışan silindi");
            ListeGuncelle();
        }
        private void ListeGuncelle()
        {
            lsvCalisanlar.Items.Clear();
            var employee = Singleton.Context.Employees.ToList();
            foreach (var item in employee)
            {
                string[] degerler = new string[9]
                {
                    item.ID.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Phone,
                    item.Email,
                    item.Adress,
                    item.BirthDate.ToString(),
                    item.Password,
                    item.Statu==true?"Yönetici":"Çalışan"
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvCalisanlar.Items.Add(viewItem);
            }
        }
        public void ListeGuncelle(object sender, EventArgs e)
        {
            ListeGuncelle();
        }

      
    }
}
