using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ex4
{
    //Максимов Дмитрий

    //Используя полученные знания и класс TrueFalse в качестве шаблона, 
    //разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
    public class Dictionary
    {
        public string word;         // Слово
        public string translate;    // Перевод

        public Dictionary()
        {
        }
        public Dictionary(string word, string translate)
        {
            this.word = word;
            this.translate = translate;
        }
    }

    class MyBase
    {
        string fileName;
        List<Dictionary> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public MyBase(string fileName)
        {
            this.fileName = fileName;
            list = new List<Dictionary>();
        }
        public void Add(string word, string translate)
        {
            list.Add(new Dictionary(word, translate));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public Dictionary this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Dictionary>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void SaveAs()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Dictionary>));
            Stream myStream = new FileStream(fileName, FileMode.Append, FileAccess.Write); ;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    xmlFormat.Serialize(myStream, list);
                    saveFileDialog1.RestoreDirectory = true;
                    myStream.Close();
                }
            }
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Dictionary>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Dictionary>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public int Count
        {
            get { return list.Count; }
        }
    }

}

