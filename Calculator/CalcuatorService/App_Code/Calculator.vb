Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Calculator
     Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Double Add (Double f1, Double f2)
    {
        
        Return f1 + f2; 
        }

        [WebMethod]
        Public Double Subtrct(Double f1, Double f2)
        {
            Return f1 - f2;
        }

    [WebMethod]
        
    Public Double Mutliply(Double f1, Double f2)
        {
            Return f1 * f2; 
        }
         
    [WebMethod]
    Public Double  Divide(Double f1, Double f2)
        {
            Return f1 / f2;
        }
    

End Class