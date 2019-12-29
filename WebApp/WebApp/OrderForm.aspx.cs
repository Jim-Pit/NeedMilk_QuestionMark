using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string nam, addr;
        int tk;

        int id;

        Customer cus;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new Model1Container())
            {
                int x = FindCustomerID();
                if (x > -1)
                {
                    OrdItm i;

                    var queryy = from ordi in db.OrdItmSet
                                 where ordi.Cus_ID == x
                                 select new { ordi.Id };

                    foreach (var elle in queryy)
                    {
                        i = db.OrdItmSet.Find(elle.Id);
                        db.OrdItmSet.Remove(i);
                    }
                    db.SaveChanges();
                }
            }
        }

        protected void Orderbutt_Click(object sender, EventArgs e)
        {
            try
            {
                nam = Namebo.Text;
                addr = Addbo.Text;
                tk = Int32.Parse(Tkbo.Text);
                Exc.Text = "";
            }
            catch (Exception exc)
            {
                Exc.Text = exc.Message.ToString();
            }

            using (var context = new Model1Container())
            {
                var queri = from c in context.CustomerSet
                            select new { c.Id, c.Name, c.Address, c.TK };

                bool alread_exis = false;

                foreach (var details in queri)
                {
                    if (details.Name == nam && details.Address == addr && details.TK == tk)
                    {
                        alread_exis = true;
                        id = details.Id;
                        cus = context.CustomerSet.Find(id);
                    }
                    else
                        InfoID.Text = "This customer doesn't exist";
                }
                if (alread_exis)
                {
                    InfoID.Text = cus.Name + " has id: " + cus.Id.ToString();

                    if (Cheesebo.Checked)
                    {
                        OrdItm itm1 = new OrdItm()
                        {
                            Name = "Cheese",
                            Quanti = Int32.Parse(CheeCou.Text),
                            Cus_ID = id
                        };

                        cus.OrdItm.Add(itm1);
                        context.OrdItmSet.Add(itm1);

                    }
                    if (Milkbo.Checked)
                    {
                        OrdItm itm2 = new OrdItm()
                        {
                            Name = "Milk",
                            Quanti = Int32.Parse(MilCou.Text),
                            Cus_ID = id
                        };

                        cus.OrdItm.Add(itm2);
                        context.OrdItmSet.Add(itm2);

                    }
                    context.SaveChanges();
                }
                
            }
        }

        private int FindCustomerID()
        {
            using (var context = new Model1Container())
            {
                try
                {
                    nam = Namebo.Text;
                    addr = Addbo.Text;
                    tk = Int32.Parse(Tkbo.Text);
                    Exc.Text = "";
                }
                catch (Exception exc)
                {
                    Exc.Text = exc.Message.ToString();
                }

                var queri = from c in context.CustomerSet
                            select new { c.Id, c.Name, c.Address, c.TK };

                foreach (var details in queri)
                {
                    if (details.Name == nam && details.Address == addr && details.TK == tk)
                    {
                        id = details.Id;
                        InfoID.Text = "This customer has id: " + id.ToString();
                        return id;
                    }
                    else
                    {
                        InfoID.Text = "This customer doesn't exist";
                    }
                }
                return -1;
            }
        }
    }
}