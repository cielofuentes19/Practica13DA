using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Configuration;
using System.Data;

namespace Try3
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private string connectionString; public WebService1()
        {
            //Eliminar la marca de comentario de la línea siguiente si utiliza los 
            // componentes diseñados          //InitializeComponent();  
            connectionString = "Data Source=DESKTOP-73KSAG3\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        }





        [WebMethod]
        public DataSet GetCategorias()
        {
            string selectSQL = "SELECT CategoryID,CategoryName, Description,Picture FROM Categories";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            //SqlDataReader reader; 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dsCategorias = new DataSet();
            // Fill the same table.         
            adapter.Fill(dsCategorias, "Categories");
            return dsCategorias;
        }

        [WebMethod]
        public DataSet GetProductos()
        {
            string selectSQL = "SELECT ProductID,ProductName, SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM Products";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            //SqlDataReader reader; 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dsProductos = new DataSet();
            // Fill the same table.         
            adapter.Fill(dsProductos, "Products");
            return dsProductos;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
    }
}
