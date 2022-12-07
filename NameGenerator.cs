using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace FirstSteps
{
    internal class NameGenerator
    {
        public static void nameGenerator()//Done // Gives you random names
        {
            static void nameAndSurnameList(int NameGeneratorLoopAmount) //Creates lists of names and surnames
            {
                var html = @"https://www.ssa.gov/oact/babynames/decades/century.html"; //link of names list
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);
                var htmlSurname = @"https://www.thoughtco.com/most-common-us-surnames-1422656"; //link of surnames list
                HtmlWeb webSurname = new HtmlWeb();
                var htmlSurnameDoc = webSurname.Load(htmlSurname);
                List<string> nameList = new List<string>();
                List<string> surnameList = new List<string>();
                foreach (int i in Enumerable.Range(1, 100)) //adds the male names to the name list
                {
                    var node = htmlDoc.DocumentNode.SelectSingleNode($"//*[@id=\"content\"]/section[2]/div/div[2]/table/tbody/tr[{i}]/td[2]");
                    nameList.Add(node.InnerText);
                }
                foreach (int i in Enumerable.Range(1, 100)) //adds the female names to the name list
                {
                    var node = htmlDoc.DocumentNode.SelectSingleNode($"//*[@id=\"content\"]/section[2]/div/div[2]/table/tbody/tr[{i}]/td[4]");
                    nameList.Add(node.InnerText);
                }
                foreach (int i in Enumerable.Range(1, 100)) //adds the surnames to the name list
                {
                    var node = htmlSurnameDoc.DocumentNode.SelectSingleNode($"//*[@id=\"mntl-sc-block_1-0-5\"]/div/table/tbody/tr[{i}]/td[2]/p");
                    surnameList.Add(node.InnerText);
                }
                foreach (int j in Enumerable.Range(1, NameGeneratorLoopAmount))
                {
                    var NameGeneratorRandom = new Random();
                    int NameGeneratorNameIndex = NameGeneratorRandom.Next(nameList.Count);
                    int NameGeneratorSurnameIndex = NameGeneratorRandom.Next(surnameList.Count);
                    Console.WriteLine(nameList[NameGeneratorNameIndex] + " " + surnameList[NameGeneratorSurnameIndex]);
                }
            }
            Console.WriteLine("How many random names do you want? ");
            var NameGeneratorAmount = Console.ReadLine(); //The amount of times the names will be generated     
            nameAndSurnameList(int.Parse(NameGeneratorAmount));
        }
    }
}
