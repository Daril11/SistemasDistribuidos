using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using HtmlAgilityPack;

namespace WebServiceDEB
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class WebService1 : System.Web.Services.WebService
    {

        string nuevomsg = "";
        [WebMethod]
        public string RetornarDolarVenta()
        {
            int cont = 0;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);

            string texto = "";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.lostiempos.com/servicios/cotizaciones");

            foreach (HtmlNode item in doc.DocumentNode.SelectNodes("//div[@class='field-content']"))
            {

                if (cont == 2)
                {
                    texto = texto + item.InnerText;
                }
                cont++;




            }


            return "Dolar Venta vale " + texto + " Bolivianos";

        }

        [WebMethod]
        public string RetornarDolarCompra()
        {
            int cont = 0;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);

            string texto = "";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.lostiempos.com/servicios/cotizaciones");

            foreach (HtmlNode item in doc.DocumentNode.SelectNodes("//div[@class='field-content']"))
            {

                if (cont == 1)
                {
                    texto = texto + item.InnerText + " Bolivianos";
                }
                cont++;




            }




            return "Dolar Compra vale " + texto;

        }


        [WebMethod]
        public string TemperaturaEnSantaCruzBolivia()
        {
            int cont = 0;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);

            string texto = "";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doce = web.Load("https://weather.com/es-BO/tiempo/hoy/l/-17.81,-63.16?par=google");

            foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//span[@data-testid='TemperatureValue']"))
            {

                if (cont == 0)
                {
                    texto = texto + item.InnerText + " Grados";
                }
                cont++;

            }

            return "La Temperatura actual en Santa Cruz es:" + texto+ "° F";

        }




        [WebMethod]
        public string ConvertidorHora(string pais)
        {
            int cont = 0;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);



            string hora = "";
            string horados = "";
            string minutodos = "";
            string minuto = "";
            int horis = 0;
            int minus = 0;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doce = web.Load("https://dayspedia.com/time/co/Bolivia/?lang=es");

           
             
            if (pais == "Bolivia")
            {
                foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                {

                    if (cont == 0)
                    {
                        hora = hora + item.InnerText;
                    }
                    
                    cont++;

                }
                cont = 0;
                foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                {

                    if (cont == 1)
                    {
                        horados = horados + item.InnerText;
                    }


                    cont++;

                }
                cont = 0;
                foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                {

                    if (cont == 2)
                    {
                        minuto = minuto + item.InnerText;
                    }

                    cont++;

                }
                cont = 0;

                foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                {

                    if (cont == 3)
                    {
                        minutodos = minutodos + item.InnerText;
                    }

                    cont++;

                }

                horis = (Convert.ToInt32(hora+""+horados))+1;
                minus = Convert.ToInt32(minuto+""+minutodos);


                int horafinal = 0;
                if (horis > 24)
                {
                    horafinal = horis - 24;

                }
                else
                {
                    horafinal = horis;
                }
                nuevomsg = "La Hora en " + pais + " es: " + horafinal + ":" + minus;
            }
            else
            {
                if (pais == "Peru")
                {
                    foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                    {

                        if (cont == 0)
                        {
                            hora = hora + item.InnerText;
                        }

                        cont++;

                    }
                    cont = 0;
                    foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                    {

                        if (cont == 1)
                        {
                            horados = horados + item.InnerText;
                        }


                        cont++;

                    }
                    cont = 0;
                    foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                    {

                        if (cont == 2)
                        {
                            minuto = minuto + item.InnerText;
                        }

                        cont++;

                    }
                    cont = 0;

                    foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                    {

                        if (cont == 3)
                        {
                            minutodos = minutodos + item.InnerText;
                        }

                        cont++;

                    }

                    horis = Convert.ToInt32(hora + "" + horados);
                    minus = Convert.ToInt32(minuto + "" + minutodos);

                    int horafinal = 0;
                    if (horis > 24)
                    {
                        horafinal = horis - 24;

                    }
                    else
                    {
                        horafinal = horis;
                    }
                    nuevomsg = "La Hora en " + pais + " es: " + horafinal + ":" + minus;
                }
                else
                {
                    if (pais == "China")
                    {
                        foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                        {

                            if (cont == 0)
                            {
                                hora = hora + item.InnerText;
                            }

                            cont++;

                        }
                        cont = 0;
                        foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                        {

                            if (cont == 1)
                            {
                                horados = horados + item.InnerText;
                            }


                            cont++;

                        }
                        cont = 0;
                        foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                        {

                            if (cont == 2)
                            {
                                minuto = minuto + item.InnerText;
                            }

                            cont++;

                        }
                        cont = 0;

                        foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                        {

                            if (cont == 3)
                            {
                                minutodos = minutodos + item.InnerText;
                            }

                            cont++;

                        }

                        horis = (Convert.ToInt32(hora + "" + horados))+13;
                        minus = Convert.ToInt32(minuto + "" + minutodos);

                        int horafinal = 0;
                        if (horis > 24)
                        {
                            horafinal = horis - 24;

                        }
                        else
                        {
                            horafinal = horis;
                        }
                        nuevomsg = "La Hora en " + pais + " es: " + horafinal + ":" + minus;

                    }
                    else
                    {
                        if (pais == "España")
                        {
                            foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                            {

                                if (cont == 0)
                                {
                                    hora = hora + item.InnerText;
                                }

                                cont++;

                            }
                            cont = 0;
                            foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                            {

                                if (cont == 1)
                                {
                                    horados = horados + item.InnerText;
                                }


                                cont++;

                            }
                            cont = 0;
                            foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                            {

                                if (cont == 2)
                                {
                                    minuto = minuto + item.InnerText;
                                }

                                cont++;

                            }
                            cont = 0;

                            foreach (HtmlNode item in doce.DocumentNode.SelectNodes("//div[@class='number']"))
                            {

                                if (cont == 3)
                                {
                                    minutodos = minutodos + item.InnerText;
                                }

                                cont++;

                            }

                            horis = (Convert.ToInt32(hora + "" + horados))+7;
                            minus = Convert.ToInt32(minuto + "" + minutodos);

                            int horafinal = 0;
                            if (horis > 24)
                            {
                                horafinal = horis - 24;

                            }
                            else
                            {
                                horafinal = horis;
                            }
                            nuevomsg = "La Hora en " + pais + " es: " + horafinal + ":" + minus;

                        }
                        else
                        {
                            nuevomsg = "Pais no disponible";
                        }

                    }
                }
            }

     
            return nuevomsg;

        }



    }
}
