using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginMD5
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection("Data Source=eryzeni5;Initial Catalog=LoginASP;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            TestsqlDataContext db = new TestsqlDataContext();
            gdvLogin.DataSource = db.Login;
            gdvLogin.DataBind();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string cadenaencriptada = Encrypt.GetMD5(txtContra.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO Login (Usuario,Pass) Values(@Usuario, @Pass)", conexion);
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                string cadenaencriptada = Encrypt.GetMD5(txtContra.Text);
                comando.Parameters.AddWithValue("@Pass", cadenaencriptada);
                comando.ExecuteNonQuery(); 
                
                    lblRegistrofinal.Text = "Registro exitoso";
                    
                

            }
            catch (Exception m)
            {
                Console.WriteLine("Error en: " + m.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}