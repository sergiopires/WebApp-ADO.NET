using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;



namespace WebApp.App_Code
{
    public class Repository
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EDITORA"].ConnectionString);


        public SqlDataReader SelectDR()
        {

            var constr = @"Data Source=(localdb)\Projects;Initial Catalog=EDITORA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            SqlConnection con = new SqlConnection(constr);

            con.Open();

            string SQL = "SELECT [NUM_EDICAO],[CAPA],[NIVEL] FROM [REVISTAS] ORDER BY [NUM_EDICAO]";

            var cmd = new SqlCommand(SQL, con);

            var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;

        }

        public DataSet SelectDataSet()
        {

            var constr = @"Data Source=(localdb)\Projects;Initial Catalog=EDITORA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            SqlConnection con = new SqlConnection(constr);

            con.Open();

            string SQL = "SELECT [NUM_EDICAO],[CAPA],[NIVEL] FROM [REVISTAS] ORDER BY [NUM_EDICAO]";

            var cmd = new SqlCommand(SQL, con);

            var da = new SqlDataAdapter(cmd);
            var ds = new DataSet();

            da.Fill(ds);

            return ds;

        }

        public List<Revista> SelectFake()
        {
            var lista = new List<Revista>();

            lista.Add(new Revista { CAPA = "MVC", NIVEL = 1, NUM_EDICAO = 102 });
            lista.Add(new Revista { CAPA = "C#", NIVEL = 2, NUM_EDICAO = 102 });
            return lista;
        }

        public List<Revista> Select()
        {
            string SQL = "SELECT [NUM_EDICAO],[CAPA],[NIVEL] FROM [REVISTAS] ORDER BY [NUM_EDICAO]";
            var cmd = new SqlCommand(SQL, con);

            var lista = new List<Revista>();

            con.Open();

            try
            {
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var obj = new Revista();
                    obj.NUM_EDICAO = Convert.ToInt32(dr[0]);
                    obj.CAPA = dr[1].ToString();
                    obj.NIVEL = Convert.ToDouble(dr[2]);
                    lista.Add(obj);
                }

                return lista;

            }
            finally
            {

                con.Close();
            }




        }

        //Criado o comando update e o delete  usando a camada repository
        //public void Update(int NUM_EDICAO, string CAPA, double NIVEL)
        //{
        public void Update(Revista obj)
        {
            string SQL = "UPDATE REVISTAS SET CAPA=@CAPA,NIVEL=@NIVEL WHERE NUM_EDICAO=@NUM_EDICAO";

            var cmd = new SqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@NUM_EDICAO", obj.NUM_EDICAO);
            cmd.Parameters.AddWithValue("@CAPA", obj.CAPA);
            cmd.Parameters.AddWithValue("@NIVEL", obj.NIVEL);
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Deletar(Revista obj)
        {
            string SQL = "DELETE REVISTAS WHERE NUM_EDICAO=@NUM_EDICAO";

            var cmd = new SqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@NUM_EDICAO", obj.NUM_EDICAO);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Inserir(Revista obj)
        {
            //var constr = @"Data Source=(localdb)\Projects;Initial Catalog=EDITORA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            //SqlConnection con = new SqlConnection(constr);

            string SQL = "INSERT INTO REVISTAS (NUM_EDICAO,CAPA,NIVEL) VALUES (@NUM_EDICAO,@CAPA,@NIVEL);";

            var cmd = new SqlCommand(SQL, con);

            cmd.Parameters.AddWithValue("@NUM_EDICAO", obj.NUM_EDICAO);
            cmd.Parameters.AddWithValue("@CAPA", obj.CAPA);
            cmd.Parameters.AddWithValue("@NIVEL", obj.NIVEL);
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
