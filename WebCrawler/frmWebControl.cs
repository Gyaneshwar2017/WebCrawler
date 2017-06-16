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
    public partial class frmWebControl : Form
    {
        public frmWebControl()
        {
            InitializeComponent();
        }

        string navigationUrl = "https://portfolio.rediff.com/portfolio-login";
        string userName = "raju44u@gmail.com";
        string password = "raju44u";
        private void frmWebControl_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadWebSite_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(navigationUrl);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var element = webBrowser1.Document.GetElementById("useremail");
                element.SetAttribute("value", userName);

                element = webBrowser1.Document.GetElementById("emailsubmit");
                element.InvokeMember("click");

                System.Threading.Thread.Sleep(1000);
                webBrowser1.Document.GetElementById("rememberflag").InvokeMember("click");

                element = webBrowser1.Document.GetElementById("userpass");
                element.SetAttribute("value", password);

                element = webBrowser1.Document.GetElementById("loginsubmit");
                element.InvokeMember("click");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                var dtStock = GetStockDataTable();
                var table = webBrowser1.Document.GetElementById("stock");
                var rows = table.GetElementsByTagName("tr");

                foreach (HtmlElement row in rows)
                {
                    var isRowFound = false;
                    var dRow = dtStock.NewRow();
                    var i = 0;
                    foreach (HtmlElement cell in row.GetElementsByTagName("td"))
                    {
                        if (i == 0)
                        {
                            i++;
                            continue;
                        }
                        var spanElements = cell.GetElementsByTagName("span");
                        if (spanElements.Count == 0)
                        {
                            i++;
                            continue;
                        }

                        var spanValue = spanElements[spanElements.Count - 1].InnerText;
                        dRow[i - 1] = spanValue;
                        isRowFound = true;
                        i++;
                    }
                    if (isRowFound)
                        dtStock.Rows.Add(dRow);
                }

                using (var _frmWebData = new WebCrawler.frmWebData())
                {
                    _frmWebData.dtData = dtStock;
                    _frmWebData.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }


        private DataTable GetStockDataTable()
        {
            var dtStock = new DataTable();
            dtStock.Columns.Add("Company");
            dtStock.Columns.Add("Exchange");
            dtStock.Columns.Add("Qty");
            dtStock.Columns.Add("AvgBuyPrice");
            dtStock.Columns.Add("ValueAtAvgBuyPrice");
            dtStock.Columns.Add("LTP");
            dtStock.Columns.Add("ValueAtLTP");
            dtStock.Columns.Add("GainInRs");
            dtStock.Columns.Add("GainInPer");
            return dtStock;
        }
    }
}
