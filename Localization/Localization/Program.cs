using System;
using System.IO;
using System.Xml;

namespace Localization
{
    class Program
    {

        static void Main(string[] args)
        {
            // Запуск их папки с exe
            //var adress = $"{Environment.CurrentDirectory}\\strings.xml";
            //var writePath = $"{Environment.CurrentDirectory}\\Localizable.strings";

            var adress = $"E:\\ALEX\\.net проекты\\Localization\\strings.xml";
            var writePathLocalizableStrings = $"E:\\ALEX\\.net проекты\\Localization\\Localizable.strings";
            var writePathMainStrings = $"E:\\ALEX\\.net проекты\\Localization\\Main.strings";

            ParsLocalizable(adress, writePathLocalizableStrings);
            ParsMain(adress, writePathMainStrings);

            Console.Read();
        }

        private static void ParsLocalizable(string adress, string writePath)
        {

            var localizableStrings = new LocalizableStrings();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(adress);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {

                if (xnode == null)
                {
                    continue;
                }

                // получаем атрибут name
                XmlNode attr = xnode.Attributes?.GetNamedItem("name");
                if (attr == null)
                {
                    continue;
                }

                switch (attr.Value)
                {
                    case "meal1_name":
                        localizableStrings.meal1_name = xnode.InnerText;
                        break;
                    case "meal2_name":
                        localizableStrings.meal2_name = xnode.InnerText;
                        break;
                    case "meal3_name":
                        localizableStrings.meal3_name = xnode.InnerText;
                        break;
                    case "meal4_name":
                        localizableStrings.meal4_name = xnode.InnerText;
                        break;
                    case "meal5_name":
                        localizableStrings.meal5_name = xnode.InnerText;
                        break;
                    case "meal_status_next":
                        localizableStrings.meal_status_next = xnode.InnerText;
                        break;
                    case "meal_status_missed":
                        localizableStrings.meal_status_missed = xnode.InnerText;
                        break;
                    case "meal_status_vin":
                        localizableStrings.meal_status_vin = xnode.InnerText;
                        break;
                    case "delete_record":
                        localizableStrings.delete_record = xnode.InnerText;
                        break;
                    case "description":
                        localizableStrings.description = xnode.InnerText;
                        break;
                    case "cancel":
                        localizableStrings.cancel = xnode.InnerText;
                        break;
                    case "add":
                        localizableStrings.add = xnode.InnerText;
                        break;
                    case "name":
                        localizableStrings.name = xnode.InnerText;
                        break;
                    case "time":
                        localizableStrings.time = xnode.InnerText;
                        break;
                    case "meal_win":
                        localizableStrings.meal_win = xnode.InnerText;
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"{attr.Value} | {xnode.InnerText}");

                Console.WriteLine();
            }

            Console.WriteLine("========localizableStrings============");
            Console.WriteLine(localizableStrings.ToString());
            Console.WriteLine("======================================");

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(localizableStrings.ToString());
                }

                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void ParsMain(string adress, string writePath)
        {

            var mainString = new MainString();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(adress);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {

                if (xnode == null)
                {
                    continue;
                }

                // получаем атрибут name
                XmlNode attr = xnode.Attributes?.GetNamedItem("name");
                if (attr == null)
                {
                    continue;
                }

                Console.WriteLine($"{attr.Value} | {xnode.InnerText}");

                mainString.SetAtribute(attr.Value, xnode.InnerText);

                Console.WriteLine();
            }

            Console.WriteLine("========MainString============");
            Console.WriteLine(mainString.ToString());
            Console.WriteLine("======================================");

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(mainString.ToString());
                }

                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
