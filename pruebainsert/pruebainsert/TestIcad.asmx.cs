
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace pruebainsert
{
    /// <summary>
    /// Descripción breve de TestIcad
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class TestIcad : System.Web.Services.WebService
    {
        public static string Logarchivo ="ClosEvent.txt";

       [WebMethod]
       
        public int CloseEvent(string ConsecutivoCad,string CodCierre,DateTime FechaCierre)
        {
            EscribeLog.escribe("se recibe el consecutivo icad : " + ConsecutivoCad + " con codigo de cierre: " + CodCierre + " con fecha y hora de cierre: " + FechaCierre.ToString(), Logarchivo);
            return 1;
        }
    }
}
