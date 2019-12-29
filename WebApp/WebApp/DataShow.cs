using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApp
{
    public static class DataShow
    {
        public static void DynamicTableCustomer(GridView grid)
        {
            System.Data.DataTable dat = new System.Data.DataTable();

            dat.Columns.Add("NAME", typeof(string));
            dat.Columns.Add("ADDRESS", typeof(string));
            dat.Columns.Add("TK", typeof(int));

            using (var db = new Model1Container())
            {
                var query = from c in db.CustomerSet
                            select new { c.Name, c.Address, c.TK };

                foreach (var details in query)
                    dat.Rows.Add(details.Name, details.Address, details.TK);

                grid.DataSource = dat;
                grid.DataBind();

            }
        }

        public static void DynamicTableOrder(GridView grid)
        {
            System.Data.DataTable dat = new System.Data.DataTable();

            dat.Columns.Add("ORDER", typeof(string));

            using (var context = new Model1Container())
            {
                bool nullTabl=true;

                var query = from c in context.CustomerSet
                            select new { c.Id, c.Name, c.OrdItm };

                System.Text.StringBuilder builder = new System.Text.StringBuilder();

                foreach (var res in query)
                {
                    // if there are ordered items for a customer all will be displayed in a string
                    if (res.OrdItm.Count() > 0)
                    {
                        builder.Clear();
                        int i = res.Id;
                        builder.Append("\r\n" + res.Name + ": ");
                        var queryy = from ord in context.OrdItmSet
                                     where ord.Cus_ID == i
                                     select new { ord.Name, ord.Quanti };
                        foreach (var itm in queryy)
                        {
                            builder.Append(itm.Name + "->" + itm.Quanti.ToString());
                            builder.Append(" | ");
                        }
                        dat.Rows.Add(builder.ToString());
                        nullTabl = false;
                    }
                    /*
                    else
                        dat.Rows.Add(res.Name + " has no orders");
                    */
                }
                // if no customer has pending orders
                if (nullTabl)
                    dat.Rows.Add("No Orders");
            }
            grid.DataSource = dat;
            grid.DataBind();
        }
    }
}