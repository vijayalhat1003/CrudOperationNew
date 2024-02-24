using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudOperationNew
{
    public partial class Crud2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GKIR43;Initial Catalog=vijay;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            String query = "insert into  Employee2 values('"+txtId.Text+"','"+txtName.Text+"' , '"+txtSal.Text+"')";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();  
            con.Close();
            Response.Write("<script>alert('Data Saved')</script>");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            String query = "update employee2 set EmpSalary='"+txtSal.Text+"' where EmpId='"+txtId.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Data Updated')</script>");
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            String query = "delete from employee2 where EmpId='"+txtId.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Data Deleted')</script>");
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            String query = "select * from employee2";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            con.Open();
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr["EmpName"].ToString();
                txtSal.Text = dr["EmpSalary"].ToString();
            
            }
            dr.Close();
            con.Close();
           
        }
    }
}