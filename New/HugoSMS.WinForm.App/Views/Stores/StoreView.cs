using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using HugoSMS.WinForm.App.Models;

namespace HugoSMS.WinForm.App.Views.Stores
{
    public partial class StoreView : UserControl
    {
        List<Store> stores = new List<Store>();
        List<Item> items = new List<Item>();

        public StoreView()
        {
            InitializeComponent();
        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddStore_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateStore_Click(object sender, EventArgs e)
        {

        }

        private void StoreView_Load(object sender, EventArgs e)
        {
            try
            {
                stores = Business.DataAccess.GetStores();
                items = Business.DataAccess.GetItems();

                DgvData.DataSource = stores;
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error($"예외발생 : {ex.Message}");
            }
        }
    }
}
