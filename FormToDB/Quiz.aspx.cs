using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormToDB
{
    public partial class Quiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //kode for innsetting til db
            DBLayer dbl = new DBLayer();
            dbl.InsertValuesToDB(TextBoxUserName.Text,Label1.Text, TextBox1.Text, Label2.Text, TextBox2.Text, Label3.Text, TextBox3.Text);
        }
    }
}