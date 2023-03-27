using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public interface IAccionesBD
    {
        bool AccessDBSql(string SQLserver);

        object Abrir();

        bool Cerrar();

        bool Agregar(string tabla, string campos, string valores);

        bool Modificar(string tabla, string Valores, string where);

        bool Eliminar(string tabla, string condicion, string conBorrar);

        SqlDataReader Consultar(string tabla);
        SqlDataReader ConsultarTabla(string tabla, string campos, string valor);
    }
}
