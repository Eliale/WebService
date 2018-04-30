using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de ConvertidorTemperatura
/// </summary>
[WebService(Namespace = "http://tempuriconversor.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
[System.Web.Script.Services.ScriptService]
public class ConvertidorTemperatura : System.Web.Services.WebService
{

    public ConvertidorTemperatura()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="farhenheit">Grados Farhenheit</param>
    /// <returns celsius>Equivalente en grados celcius de grados farhenheit</returns>
    [WebMethod]
    public double ConvertirFarhenheitACelcius(double farhenheit)
    {
        double celcius = (((farhenheit - 32) * 5) / 9); ;
        return celcius;
    }
    [WebMethod]
    public double ConvertirCelciusAFarhenheit(double celcius)
    {
        return ((celcius * 9) / 5) + 32;
    }
    [WebMethod]
    public double ConvertirKelvinACelcius(double kelvin)
    {
        return kelvin - 273.15;
    }
    [WebMethod]
    public double ConvertirCelciusAKelvin(double celcius)
    {
        return celcius + 273.15;
    }
    [WebMethod]
    public double ConvertirKelvinAFarhenheit(double kelvin)
    {
        return ((9 * (kelvin - 273.15)) / 5) + 32;
    }
    [WebMethod]
    public double ConvertirFarhenheitAKelvin(double farhenheit)
    {
        return ((5 * (farhenheit - 32)) / 9) + 273.15;
    }
    [WebMethod]
    public int SumaGauss(int n) {
        return (n * (n + 1)) / 2;
    }
    [WebMethod]
    public Boolean EsPrimo(int n) {
        Boolean esPrimo = true;
        if (n == 2) {
            return true;
        }
        if (n < 2) {
            return false;
        }
        for (int i = 2; i < n; i++ ) {
            if (n % i == 0) {
                esPrimo = false;
            }
        }
        return esPrimo;
    }

}
