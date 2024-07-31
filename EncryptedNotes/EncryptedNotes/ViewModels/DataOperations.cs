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
        /// <Summary>
        /// XML belgesini yükler ve üzerinde işlemler yapabilmek için bir `XElement` oluşturur.
        /// </Summary>
        static XElement xelement = XElement.Load(DirInfo.xmlPath);

        /// <Summary>
        /// Yeni bir not bilgisi ekler ve XML dosyasını günceller.
        /// </Summary>
        /// <param name="path">Notun kaydedildiği dosya yolu.</param>
        /// <param name="title">Notun başlığı.</param>
        /// <param name="lastdate">Notun son değişiklik tarihi.</param>
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
                xelement.Save(DirInfo.xmlPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Yeni not oluştrulamadı" + "\n" + "Hata Kodu: " + e);
            }
            ToList();
        }

        /// <Summary>
        /// En son eklenen notun ID'sini döndürür.
        /// </Summary>
        /// <Returns>
        /// En son notun ID'si döndürülür.
        /// </Returns>
        public static string LastDateId()
        {
            return ToList().Last().id;
        }

        /// <Summary>
        /// XML dosyasından tüm not bilgilerini okur ve bir liste olarak döndürür.
        /// Geçersiz veya var olmayan dosyaları temizler.
        /// </Summary>
        /// <Returns>
        /// Not bilgilerini içeren `NoteInformation` nesnelerinden oluşan bir liste döner.
        /// </Returns>
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

        /// <Summary>
        /// Geçerli notların bir listesini döndürür.
        /// </Summary>
        /// <Returns>
        /// `NoteInformation` nesnelerinden oluşan bir liste döner.
        /// </Returns>
        public static List<NoteInformation> ToList()
        {
            return DataList();
        }

        /// <Summary>
        /// Arama değeri ile eşleşen notları döndürür.
        /// </Summary>
        /// <Returns>
        /// Arama değerine göre filtrelenmiş `NoteInformation` nesnelerinden oluşan bir liste döner.
        /// </Returns>
        /// <param name="values">Aranacak değer.</param>
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

        /// <Summary>
        /// Belirtilen ID'ye sahip notu XML dosyasından siler.
        /// </Summary>
        /// <param name="id">Silinecek notun ID'si.</param>
        public static void RemoveData(string id)
        {
            xelement.Descendants("noteInfo").Where(b => b.Element("noteInfo_id").Attribute("id").Value == id).Remove();
        }

        /// <Summary>
        /// Belirtilen ID'ye sahip notun başlığını günceller.
        /// </Summary>
        /// <param name="id">Güncellenecek notun ID'si.</param>
        /// <param name="value">Yeni başlık değeri.</param>
        public static void UpdateData(string id, string value)
        {
            xelement.Descendants("noteInfo")
                    .Where(b => b.Element("noteInfo_id").Attribute("id").Value == id)
                    .First().Element("noteInfo_title").Attribute("title").Value = value;
            xelement.Save(DirInfo.xmlPath);
        }

        /// <Summary>
        /// Geçerli olmayan dosya yollarına sahip notları temizler.
        /// </Summary>
        /// <param name="list">Silinecek not bilgilerini içeren liste.</param>
        private static void RemovesData(List<NoteInformation> list)
        {
            foreach (var item in list)
            {
                xelement.Descendants("noteInfo").Where(b => b.Element("noteInfo_id").Attribute("id").Value == item.id).Remove();
            }
            xelement.Save(DirInfo.xmlPath);
            //  XTagElement.Descendants("tag_id").Where(status => status.Attribute("id").Value == _selectId.ToString()).ToList()
        }
    }
}
