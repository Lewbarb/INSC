using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDProjektRED
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = (int)(Session["ID"]);

            var cd = dbchange.searchDB(id);


            Label1.Text = "Artist: " + cd.Artist;
            Label2.Text = "Album: " + cd.Album;
            Label3.Text = "Year: " + cd.Year.ToString();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public static CDtbl searchDB(int id)//searched table for object with name equal to passed string
        {
            using (CDModel context = new CDModel())
            {
                CDtbl CD = context.CDtbls.FirstOrDefault(r => r.id == id);
                return CD;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = (int)(Session["ID"]);

            string Album = TextBox2.Text;
            string Artist = TextBox1.Text;
            int Year = Int32.Parse(TextBox3.Text);

            dbchange.editRecord(id, Artist, Album, Year);

            Response.Redirect("~/WebForm2.aspx");
        }

   

        protected void Button2_Click(object sender, EventArgs e)
        {

            int idSend = (int)(Session["ID"]);
            dbchange.deleteRecord(idSend);
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}