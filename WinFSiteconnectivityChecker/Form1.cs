using System;
using System.Timers;
using siteconnectivitychecker;
using siteconnectivitychecker.urlsproviders;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WinFSiteconnectivityChecker
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        Iurlprovider urlprovider;

        public Form1()
        {
            InitializeComponent();
            initialize();
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if(urlprovider.addurl(TxtbxUrl.Text))
            {
                populatelistview();
                RTxtDisplay.Text = string.Format("{0} is added to the urls list", TxtbxUrl.Text);
            }
            timer.Start();
        }

        private void btnRmUrl_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (urlprovider.removeurl(TxtbxUrl.Text))
            {
                populatelistview();
                RTxtDisplay.Text = string.Format("{0} is removed to the urls list", TxtbxUrl.Text);
            }
            timer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void BtnValidInterv_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Interval = Convert.ToDouble(TxtBxInterval.Text);
            timer.Start();
        }

        private void initialize()
        {
            string cs = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            urlprovider = new sqliteurlprovider(cs);

            createsamplesdata();

            populatelistview();

            timer = new System.Timers.Timer();
            timer.Interval = Convert.ToDouble(TxtBxInterval.Text.ToString() == "" ? "5000" : TxtBxInterval.Text.ToString());
            timer.Elapsed += Timer_Elapsed;

        }

        private void populatelistview()
        {
            string[] urls = urlprovider.geturls();


            foreach (var url in urls)
            {
                ListViewItem urlitem = new ListViewItem(url);
                LstVwUrls.Items.Add(urlitem);
            }
        }

        private void createsamplesdata()
        {
            string[] sites = new string[] { "youtube.com", "facebook.com", "stackoverflow.com", "google.com", "medium.com" };

            foreach (string url in sites)
            {
                urlprovider.addurl(url);
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] urls = urlprovider.geturls();
            foreach (var url in urls)
            {
                if (ConnectionChecker.ConnectionCheck(url))
                {
                    RTxtDisplay.Text += string.Format("site {0} is up \n ", url);
                }
                else
                {
                    RTxtDisplay.Text += string.Format("site {0} is down \n ", url);
                }
            }
            RTxtDisplay.Text += "******************* \n";
        }
    }


}
