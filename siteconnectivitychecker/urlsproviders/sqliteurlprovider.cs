using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace siteconnectivitychecker.urlsproviders
{
    public class sqliteurlprovider : Iurlprovider
    {
        private string _constr;

        public sqliteurlprovider(string constr)
        {
            _constr = constr;
        }

        bool Iurlprovider.addurl(string url)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(_constr))
                {
                    string query = "select * from urls";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "urls");

                    DataRow dr = ds.Tables["urls"].NewRow();
                    dr["url"] = url;
                    ds.Tables["urls"].Rows.Add(dr);

                    da.Update(ds, "urls");

                    return true;

                }
            }
            catch (Exception)
            {

                return false ;
            }
        }

        string[] Iurlprovider.geturls()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(_constr))
                {
                    List<string> urls = new List<string>();
                    string commandText = "select url from urls";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(commandText, con);

                    DataSet ds = new DataSet();
                    da.Fill(ds,"urls");
                    for(int index=0;index< ds.Tables["urls"].Rows.Count;index++)
                    {
                        urls.Add(ds.Tables["urls"].Rows[index]["url"].ToString());
                    }
                    return urls.ToArray();
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        bool Iurlprovider.removeurl(string url)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(_constr))
                {
                    string query = string.Format("select * from urls where url='{0}'",url);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "urls");

                    foreach(DataRow row in ds.Tables["urls"].Rows)
                    {
                        row.Delete();
                    }

                    da.Update(ds, "urls");
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
