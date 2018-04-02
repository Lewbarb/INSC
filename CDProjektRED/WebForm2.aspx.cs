using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDProjektRED
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ListBox1.Items.Clear();
            popList();
        }

        public static List<CDtbl> cdList()
        {
            using (CDModel CDs = new CDModel())
            {
                var CDList = CDs.CDtbls;
                var DB = CDList.ToList();
                return CDList.ToList();
            }
        }



        void popList()
        {
            ListBox1.Items.Clear();
            var myCdList = cdList().OrderBy(o => o.Artist);

            foreach (CDtbl c in myCdList)
            {
                ListBox1.Items.Add(c.id + "\t" + c.Artist + "\t" + c.Album + "\t" + c.Year);

            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(ListBox1.SelectedItem.ToString().Split('\t')[0]);//splits the listbox string back up to get the ID
                Session["ID"] = id;
                Response.Redirect("~/WebForm3.aspx");
            }
            catch (System.NullReferenceException)
            {
                //create error popup
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Artist = TextBox1.Text;
            string Album = TextBox2.Text;
            int Year = Int32.Parse(TextBox3.Text);

            dbchange.addRecord(Artist, Album, Year);
        }


        
    }
}