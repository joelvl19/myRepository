using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;

namespace Controlador
{
    public class AccesoBDSql : IAccionesBD
    {
        SqlConnection conex = new SqlConnection();
        SqlCommand mycom = new SqlCommand();
        SqlDataReader dtRd;

        string error;
        private string conexion;
        private string tabla;
        private string valores;
        public string campos;
        private string condicion;
        private string valorCondi;
        private string connectionStrng;

        bool IAccionesBD.AccessDBSql(string SQLserver)
        {
            bool res = false;
            conexion = SQLserver;


            connectionStrng = "server=" + conexion + ";";
            res = true;
            return res;
        }
        public object Abrir()
        {
            bool res = false;
            try
            {
                conex.ConnectionString = connectionStrng;
                conex.Open();
                res = true;
            }
            catch (SqlException msqlex)
            {
                error = "Error al cargar la sesion" + msqlex.Message;
            }
            catch (Exception exp)
            {
                error = "Error al cargar la sesion" + exp.Message;
            }
            return res;
        }
        public bool Cerrar()
        {
            bool res = false;
            try
            {
                if (conex.State == System.Data.ConnectionState.Open)
                {
                    conex.Close();
                    res = true;
                }
                else if (conex.State == System.Data.ConnectionState.Closed)
                {
                    res = true;
                }
                else
                {
                    error = "La conexion esta ocupada intentelo mas tarde";
                    res = false;
                }
            }
            catch (SqlException mexp)
            {
                error = "Error al cargar la sesion" + mexp.Message;
            }
            catch (Exception xp)
            {
                error = "Error al cargar la sesion" + xp.Message;
            }
            return res;
        }
        public bool Agregar(string tabla, string campos, string valores)
        {
            bool res = false;
            try
            {
                mycom.CommandText = "INSERT INTO " + tabla + " ( " + campos + " ) VALUES ( " + valores + " );";
                this.Abrir();
                mycom.Connection = conex;
                mycom.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException slexp)
            {
                error = "Error al insertar datos" + slexp.Message;
            }
            catch (Exception ti)
            {
                error = "Error general al ingresar datos" + ti.Message;
            }
            //cerramos conexion
            finally
            {
                this.Cerrar();
            }
            return res;
        }

        public SqlDataReader Consultar(string tabla)
        {
            try
            {
                mycom.CommandText = "SELECT * FROM " + tabla + ";";
                this.Abrir();
                mycom.Connection = conex;
                dtRd = mycom.ExecuteReader();
                dtRd.Read();
            }
            catch (SqlException sd)
            {
                error = "No se puede mostrar ningun campo error en la conexion " + sd;
            }
            catch (Exception on)
            {
                error = "No se puede mostrar ningun campo error general en la conexion " + on;
            }
    
            return dtRd;
        }
        public bool Modificar(string tabla, string Valores, string where)
        {
            bool res = false;
            try
            {
                string query = "UPDATE " + tabla + " SET " + Valores + " WHERE " + where + ";";
                mycom.CommandText = query;
                mycom.Connection = conex;
                this.Abrir();
                mycom.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException sqlex)
            {
                error = "Error al modificar datos " + sqlex.Message;
            }
            catch (Exception ex)
            {
                error = "Error general al modificar datos " + ex.Message;
            }
            finally
            {
                this.Cerrar();
            }

            return res;
        }
        
        public bool Eliminar(string tabla, string condicion, string opcionBorrar)
        {
            bool res = false;
            try
            {
                mycom.CommandText = "DELETE FROM  " + tabla + " WHERE " + condicion + "  " + opcionBorrar + ";";
                this.Abrir();
                mycom.Connection = conex;
                mycom.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException sqlex)
            {
                error = "Error al eliminar datos" + sqlex.Message;
            }
            catch (Exception exe)
            {
                error = "Error general al eliminar datos" + exe.Message;
            }
            finally
            {
                this.Cerrar();
            }
            return res;
        }
        public SqlDataReader ConsultarTabla(string tabla, string campo, string valor)
        {
            try
            {
                mycom.CommandText = "SELECT * FROM " + tabla + " WHERE " + campo + " = \"" + valor + "\";";
                this.Abrir();
                mycom.Connection = conex;
                dtRd = mycom.ExecuteReader();
            }
            catch (SqlException sqlex)
            {
                error = "No se puede mostrar ningun campo Erron en la Conexion"+ sqlex.Message;
            }
            catch (Exception ex)
            {
                error = "No se puede mostrar ningun campo Error general en la conexion" + ex.Message;
            }
            return dtRd;
        }
    }
}
