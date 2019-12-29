using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string nam, addr;
        int tk;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var context = new Model1Container())
            {

                try
                {
                    nam = Nameboo.Text;
                    addr = Addboo.Text;
                    tk = Int32.Parse(Tkboo.Text);
                    Exc.Text = "";

                    Customer cus = new Customer()
                    {
                        Name = nam,
                        Address = addr,
                        TK = tk
                    };

                    context.CustomerSet.Add(cus);
                    context.SaveChanges();

                }
                catch (Exception exc)
                {
                    Exc.Text = exc.Message.ToString();
                }
            }
            
        }
    }
}