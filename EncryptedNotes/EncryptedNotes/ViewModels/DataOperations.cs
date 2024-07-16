using EncryptedNotes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EncryptedNotes.ViewModels
{
    internal static class DataOperations
    {
        static XElement xelement = XElement.Load(DicInfo.xmlPath);
        public static void NewData(string path, string title, string lastdate)
        {
            string Id = LastDateId();
            try
            {
                xelement.Add(new XElement("noteInfo",
                         new XElement("noteInfo_id", new XAttribute("id", Convert.ToInt32(Id) + 1)),
                         new XElement("noteInfo_title", new XAttribute("title", title)),
                         new XElement("noteInfo_path", new XAttribute("path", path)),
                         new XElement("noteInfo_lastdate", new XAttribute("lastdate", lastdate))));
                xelement.Save(DicInfo.xmlPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Yeni not oluştrulamadı" + "\n" + "Hata Kodu: " + e);
            }
            ToList();
        }
        public static string LastDateId()
        {
            return ToList().Last().id;
        }
        private static List<NoteInformation> DataList()
        {
            List<NoteInformation> list = new List<NoteInformation>();
            List<NoteInformation> removeList = new List<NoteInformation>();
            var datalist = from x in xelement.Descendants("noteInfo")
                           select new
                           {
                               xmlid = x.Element("noteInfo_id").Attribute("id").Value,
                               xmltitle = x.Element("noteInfo_title").Attribute("title").Value,
                               xmlpath = x.Element("noteInfo_path").Attribute("path").Value,
                               xmllastdate = x.Element("noteInfo_lastdate").Attribute("lastdate").Value
                           };
            if (datalist.Count() > 1)
                foreach (var item in datalist)
                {
                    if (File.Exists(item.xmlpath))
                    {
                        list.Add(new NoteInformation
                        {
                            id = item.xmlid,
                            title = item.xmltitle,
                            path = item.xmlpath,
                            lastDate = item.xmllastdate
                        });
                    }
                    else
                    {
                        if (item.xmlid != "0")
                            removeList.Add(new NoteInformation
                            {
                                id = item.xmlid,
                                title = item.xmltitle,
                                path = item.xmlpath,
                                lastDate = item.xmllastdate
                            });
                    }
                }
            else
                list.Add(new NoteInformation { id = "0" });
            RemovesData(removeList);
            return list;
        }

        public static List<NoteInformation> ToList()
        {
            return DataList();
        }
        public static List<NoteInformation> ToListSearches(string values)
        {
            List<NoteInformation> list = new List<NoteInformation>();
            if (values != "")
            {

                foreach (var item in DataList())
                {
                    if (item.title.ToLower().Contains(values.ToLower()))
                        list.Add(item);
                }
                return list.OrderBy(b => b.title.Length).ToList();
            }
            else
            {
                return ToList();
            }
        }
        public static void RemoveData(string id)
        {
            xelement.Descendants("noteInfo").Where(b => b.Element("noteInfo_id").Attribute("id").Value == id).Remove();
        }
        public static void UpdateData(string id, string value)
        {
            xelement.Descendants("noteInfo")
                    .Where(b => b.Element("noteInfo_id").Attribute("id").Value == id)
                    .First().Element("noteInfo_title").Attribute("title").Value = value;
            xelement.Save(DicInfo.xmlPath);
        }
       
        private static void RemovesData(List<NoteInformation> list)
        {
            foreach (var item in list)
            {
                xelement.Descendants("noteInfo").Where(b => b.Element("noteInfo_id").Attribute("id").Value == item.id).Remove();
            }
            xelement.Save(DicInfo.xmlPath);
            //  XTagElement.Descendants("tag_id").Where(status => status.Attribute("id").Value == _selectId.ToString()).ToList()
        }
    }
}
