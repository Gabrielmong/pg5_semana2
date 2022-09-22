using pg5_semana2.Clases;
using pg5_semana2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pg5_semana2 { 
    public partial class WebForm1 : System.Web.UI.Page {
        cAlumno cn = new cAlumno();
        protected void Page_Load(object sender, EventArgs e) {
            load();
        }
        protected void handleSave(object sender, EventArgs e) {
            if (TxtCarne.Text == "" | TxtEdad.Text == "" | TxtNombre.Text == "") {
                Response.Write("<script>alert('Fill all the inputs')</script>");
            } else {
                int carne = Convert.ToInt32(TxtCarne.Text);
                string nombre = TxtNombre.Text;
                int edad = Convert.ToInt32(TxtEdad.Text);
                string genero = TxtGenero.Text.ToUpper();
                cn.guardarAlumno(carne, nombre, edad, genero);
                load();
            }
        }
        protected void handleDelete(object sender, EventArgs e) {
            cn.borrarAlumno(Convert.ToInt32(hf_Control.Value));
            load();
        }
        protected void handleClose(object sender, EventArgs e) {
            Panel1.Visible = false;
        }
        private void load() {
            GridView1.DataSource = cn.mostrarAlumno();
            GridView1.DataBind();
        }
        protected void handleShow(object sender, EventArgs e) {
            load();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {
            hf_Control.Value = Convert.ToString(GridView1.DataKeys[GridView1.SelectedRow.RowIndex].Value);
            Panel1.Visible = true;
            ALUMNO obj = cn.extraerAlumno(Convert.ToInt32(hf_Control.Value));
            txtCarne1.Text = Convert.ToString(obj.CARNE);
            txtNombre1.Text = obj.NOMBRE;
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e) {
            if (e.Row.RowType == DataControlRowType.DataRow) {
                e.Row.Attributes.Add("onMouseOver", "this.style.cursor = 'pointer'");
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(GridView1, "select$" + e.Row.RowIndex.ToString()));
            }
        }
    }
}