using System.Xml;

string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
var xmlDoc = new XmlDocument();
xmlDoc.Load(exchangeRate);

//XmlElement root = xmlDoc.DocumentElement;

string usd = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod =\"USD\"]/BanknoteSelling")!.InnerXml;
Console.WriteLine(usd);
