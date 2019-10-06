using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentAccount
{
    public static class WinformExtension
    {
        public static void MdiChildAc<F>(this Form mdi)
            where F : Form, new()
        {
            F frm = new F();
            frm.MdiParent = mdi;
            frm.Show();
        }
    }
}