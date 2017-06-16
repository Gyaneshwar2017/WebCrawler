using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCrawler
{
    public partial class frmWebData : Form
    {
        public DataTable dtData { get; set; }        
        public frmWebData()
        {
            InitializeComponent();
        }

        private void frmWebData_Load(object sender, EventArgs e)
        {
            dtgData.DataSource = dtData;            
        }

    }
}
