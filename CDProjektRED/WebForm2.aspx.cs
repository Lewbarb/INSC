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
            //ListBox1.Items.Clear();
            var myCdList = cdList().OrderBy(o => o.Artist);

            foreach (CDtbl c in myCdList)
            {
                ListBox1.Items.Add(c.id + "\t" + c.Artist + "\t" + c.Album + "\t" + c.Year);

            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



 

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int IDForSession = Int32.Parse(ListBox1.SelectedItem.ToString().Split('\t')[0]);//splits the listbox string back up to get the ID
                Session["ID"] = IDForSession;
                Response.Redirect("~/WebForm3.aspx");
            }
            catch (System.NullReferenceException)
            {
                //window.alert("You didn't enter a valid value");
                string message = "You didn't select anything";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('"+message+"');", true);

                //create error popup
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ArtistSend = TextBox1.Text;
            string AlbumSend = TextBox2.Text;
            int YearSend = Int32.Parse(TextBox3.Text);
            dbchange.addRecord(ArtistSend, AlbumSend, YearSend);
            popList();
        }
    }
}