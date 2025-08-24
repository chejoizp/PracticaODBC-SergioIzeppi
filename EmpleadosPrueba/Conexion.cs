using System;
using System.Data.Odbc;

namespace EmpleadosPrueba
{
    class Conexion
    {

 public OdbcConnection conexion()
    {
        OdbcConnection conn = new OdbcConnection("Dsn=controlempleados;Database=controlempleados");
        try
        {
            conn.Open();
        }
        catch (OdbcException)
        {
            Console.WriteLine("No Conectó");
        }
        return conn;
    }

    public void desconexion(OdbcConnection conn)
    {
        try
        {
            conn.Close();
        }
        catch (OdbcException)
        {
            Console.WriteLine("No Conectó");
        }
    }

}
    }

