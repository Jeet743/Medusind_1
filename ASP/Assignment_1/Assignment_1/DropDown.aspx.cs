using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Assignment_1
{
    public partial class DropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetItem("All");
            }
            else
            {
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(30)); 
                Response.Cache.VaryByParams["None"] = true;  
                Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate); 
            }

        }

        protected void GetItem(string ProductName)
        {
            string connectionString = "Data Source=DESKTOP-7MGDTGQ\\SQLEXPRESS; initial catalog=MedusindDB;integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("spPro", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@pname";
            param.Value = ProductName;
            sda.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Image1.ImageUrl = "~/Images/" + DropDownList1.SelectedValue + ".jpg";
            GetItem(DropDownList1.SelectedValue);
            //foreach (GridViewRow row in GridView1.Rows)
            //{
            //    string val = row.Cells[2].Text;
            //    Response.Write(val);
            //}
            Label1.Text = this.GridView1.Rows[0].Cells[2].Text;
           
        }
    }
}