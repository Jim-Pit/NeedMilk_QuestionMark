using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int id;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* Testing
            using (var context = new Model1Container()){
                Customer cus = new Customer()
                {
                    Name = "ELLH",
                    Address = "KF14",
                    TK=11111
                };

                var queri = from c in context.CustomerSet
                            select new { c.Id, c.Name, c.Address, c.TK };

                bool alread_exis = false;

                foreach( var details in queri )
                {
                    if (details.Name == cus.Name && details.Address == cus.Address && details.TK == cus.TK)
                    {
                        alread_exis = true;
                        id = details.Id;
                    }
                }
                if (alread_exis)
                    Label2.Text = "This customer already exists with id: "+id.ToString();
                else
                {
                    context.CustomerSet.Add(cus);
                    context.SaveChanges();

                    id = cus.Id;

                    OrdItm itm1 = new OrdItm()
                    {
                        Name = "Cheese",
                        Quanti = 2,
                        Cus_ID = id
                    };
                    OrdItm itm2 = new OrdItm()
                    {
                        Name = "Milk",
                        Quanti = 1,
                        Cus_ID = id
                    };

                    cus.OrdItm.Add(itm1);
                    cus.OrdItm.Add(itm2);

                    context.OrdItmSet.Add(itm1);
                    context.OrdItmSet.Add(itm2);

                    context.SaveChanges();
                }
            }
            */
            DataShow.DynamicTableCustomer(GridView1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            /*
            using (var context = new Model1Container())
            {
                var query = from c in context.CustomerSet
                            select new { c.Id, c.Name, c.OrdItm };

                System.Text.StringBuilder builder = new System.Text.StringBuilder();

                foreach (var res in query)
                {
                    if (res.OrdItm.Count() > 0)
                    {
                        int i = res.Id;
                        builder.Append("\r\n" + res.Name + ": ");
                        var queryy = from ord in context.OrdItmSet
                                     where ord.Cus_ID == i
                                     select new { ord.Name, ord.Quanti };
                        foreach (var itm in queryy)
                            builder.Append(itm.Name + " " + itm.Quanti.ToString());
                        Label1.Text = builder.ToString();
                    }
                    else
                        Label1.Text = res.Name+" has no orders";
                }
            }
            */
            DataShow.DynamicTableOrder(GridView2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Delete all orders
            /*
            using (var db = new Model1Container())
            {
                OrdItm i;

                var query = from c in db.CustomerSet
                               select new { c.Id };

                foreach (var ele in query)
                {
                    var queryy = from ordi in db.OrdItmSet
                                 where ordi.Cus_ID == ele.Id
                                 select new { ordi.Id };

                    foreach (var elle in queryy)
                    {
                        i = db.OrdItmSet.Find(elle.Id);
                        db.OrdItmSet.Remove(i);
                    }
                }
                db.SaveChanges();
            }
            */
        }
    }
}