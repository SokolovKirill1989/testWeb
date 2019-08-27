using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using ServiceReference1;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebApplication2.Models
{
    public class CursModel
    {
        public XElement element { get; set; }

        
        public VALUTES GetValutes()
        {
            try
            {

                DailyInfoSoapClient clientValuta = new DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
                Task<XElement> t = clientValuta.EnumValutesXMLAsync(false);

                XElement elem = t.Result;
                this.element = elem;
                Console.WriteLine("elem - " + elem.ToString());
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(VALUTES));
                VALUTES vals = (VALUTES)xmlSerializer.Deserialize(elem.CreateReader());
                return vals;
            }
            catch (Exception e)
            {
                Console.WriteLine("!!!!!!" + e.ToString());
                return null;
            }
            
        }
        public CURSES GetCursOnDate()
        {
            string tabl = string.Empty;
            DailyInfoSoapClient clientCurs = new DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            Task<XElement> t = clientCurs.GetCursOnDateXMLAsync(DateTime.Now);
            XElement elemCurs = t.Result;
            Console.WriteLine("elemCurs - " + elemCurs.ToString());
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CURSES));
            CURSES curCurs = (CURSES)xmlSerializer.Deserialize(elemCurs.CreateReader());
            Console.WriteLine("curCurs.Count - " + curCurs.Count);
            
            if (curCurs.Count == 0) tabl = "Нет данных";
            Console.WriteLine("result - " + tabl);
            return curCurs;
        }
        public DCURSES GetDynamicCurs(DateTime startDate, DateTime endDate, string code)
        {
            string tabl = string.Empty;
            DailyInfoSoapClient clientCurs = new DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            Task<XElement> t = clientCurs.GetCursDynamicXMLAsync(startDate,endDate,code);
            XElement elemDCurs = t.Result;
            Console.WriteLine("elemDCurs - " + elemDCurs.ToString());
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DCURSES));
            DCURSES curCurs = (DCURSES)xmlSerializer.Deserialize(elemDCurs.CreateReader());
            Console.WriteLine("DDDcurCurs.Count - " + curCurs.Count);
            
            return curCurs;
        }

    }
    [XmlRoot(ElementName = "ValuteData")]
    public class VALUTES : List<Val> { }

    [XmlType(TypeName = "EnumValutes")]
    public class Val
    {
        [XmlElement(ElementName = "Vcode")]
        public string Vcode { get; set; }

        [XmlElement(ElementName = "Vname")]
        public string Vname { get; set; }

        [XmlElement(ElementName = "VEngname")]
        public string VEngname { get; set; }

        [XmlElement(ElementName = "Vnom")]
        public int Vnom { get; set; }

        [XmlElement(ElementName = "VcommonCode")]
        public string VcommonCode { get; set; }

        [XmlElement(ElementName = "VnumCode")]
        public int VnumCode { get; set; }

        [XmlElement(ElementName = "VcharCode")]
        public string  VcharCode { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}", Vname);
        }
    }
    [XmlRoot(ElementName = "ValuteData")]
    public class CURSES : List<CURS> { }
    [XmlType(TypeName = "ValuteCursOnDate")]
    public class CURS
    {
        [XmlElement(ElementName = "Vname")]
        public string Vname { get; set; }

        [XmlElement(ElementName = "Vnom")]
        public int Vnom { get; set; }

        [XmlElement(ElementName = "Vcurs")]
        public double Vcurs { get; set; }

        [XmlElement(ElementName = "Vcode")]
        public int Vcode { get; set; }

        [XmlElement(ElementName = "VchCode")]
        public string VchCode { get; set; }
    }
    [XmlRoot(ElementName = "ValuteData")]
    public class DCURSES : List<DCURS> { }
    [XmlType(TypeName = "ValuteCursDynamic")]
    public class DCURS
    {
        [XmlElement(ElementName = "CursDate")]
        public DateTime CursDate { get; set; }

        [XmlElement(ElementName = "Vcode")]
        public string Vcode { get; set; }

        [XmlElement(ElementName = "Vnom")]
        public int Vnom { get; set; }

        [XmlElement(ElementName = "Vcurs")]
        public double Vcurs { get; set; }
    }
}
