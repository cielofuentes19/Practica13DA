using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de StockQuote_DataObject
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script,
    // usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class StockQuote_DataObject : System.Web.Services.WebService
    {

        [WebMethod(Description ="Get a price for a stock")]
        public StockInfo GetStockQuote(string sticker)
        {
            StockInfo quote = new StockInfo();
            quote.Symbol = sticker;
            quote = FillQuoteFromDB(quote);
            return quote;
        }
        private StockInfo FillQuoteFromDB(StockInfo lookup) 
        {
            lookup.CompanyName = "Trapezoid";
            lookup.Price = 400;
            lookup.High_52week = 410;
            lookup.Low_52week = 20;
            return lookup;
        }
    }
    public class StockInfo
    {
        public decimal Price;
        public string Symbol;
        public decimal High_52week;
        public decimal Low_52week;
        public string CompanyName;
    }
}





