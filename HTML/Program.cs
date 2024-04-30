using System;
using System.Net;
using HtmlAgilityPack; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите URL страницы:");
        string url = Console.ReadLine();

        
        WebClient client = new WebClient();
        string html = client.DownloadString(url);

       
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(html);

      
        string pageTitle = doc.DocumentNode.SelectSingleNode("//title").InnerText;
        Console.WriteLine("Заголовок страницы: " + pageTitle);

       
        int tagCount = doc.DocumentNode.SelectNodes("//*").Count;
        Console.WriteLine("Количество тегов на странице (без учета закрывающих тегов): " + tagCount);

       
        client.Dispose();
    }
}
