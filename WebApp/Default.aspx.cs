using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using WebApp.App_Code;



namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        //Método para pegar os dados off-line e armazenar na memoria
        // Estes metodos foram criado para testar os tipos de transferencias de dados da camada dal
        //que são possiveis para interagir com a com a view atraves do ADO
        //private DataSet getDataSet()
        //{
        //    if (Cache["ds"] == null)
        //    {
        //        var ctx = new Repository();
        //        Cache["ds"] = ctx.SelectDataSet();
        //    }
        //    return Cache["ds"] as DataSet;
        //}

        //private DataView getDataView()
        //{
        //    var ds = getDataSet();
        //    var dt = ds.Tables[0];
        //    var dv = new DataView(dt);
        //    dv.Sort = "CAPA";
        //    dv.RowFilter = "NUM_EDICAO >= 103";
        //    return dv;

        //}

        //private DataSet getXMLDataSet()
        //{
        //    var fn = Server.MapPath(@"~/dados.xml");
        //    var ds = new DataSet();

        //    if (File.Exists(fn))
        //    {
        //        ds.ReadXml(fn);
        //    }
        //    else
        //    {
        //        var ctx = new Repository();
        //        ds = ctx.SelectDataSet();
        //        ds.WriteXml(fn);
        //    }
        //    return ds;

        //}

        // obs: Usado para carregar os dados no carregamento da página
        ////if (!IsPostBack)
        //// {
        ////     var ctx = new Repository();

        ////     //var dr = ctx.SelectDR();
        ////     //var ds = ctx.Select();
        ////     //var ds =  getDataView();
        ////     //var ds = getXMLDataSet();
        ////     //var ds = ctx.SelectFake();
        ////     var ds = ctx.Select();
        ////     GridView1.DataSource = ds;
        ////     GridView1.DataBind();

        ////     //dr.Close();
        //// }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Botoões foram criados somente para testar a funcionalidade da DTO Repository
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    var ctx = new Repository();
        //    ctx.Update(new Revista() { NUM_EDICAO = 104, CAPA = " Multi CAMADAS", NIVEL = 5 });
        //}

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    var ctx = new Repository();
        //    ctx.Deletar(new Revista() { NUM_EDICAO = 104, CAPA = "CAMADAS", NIVEL = 5 });
        //}

        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    var ctx = new Repository();
        //    ctx.Inserir(new Revista() { NUM_EDICAO = 104, CAPA = "CAMADAS Extras", NIVEL = 3 });
        //}

        
    }
}