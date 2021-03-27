using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrototypeDesingPattern
{
    #region
    public class kisi
    {
        public int yas;
        public DateTime dogumGunu;
        public string isim;
        public IdInfo IdInfo;

        public kisi ShallowCopy()
        {
            return (kisi)this.MemberwiseClone();
        }

        public kisi DeepCopy()
        {
            kisi clone = (kisi)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.isim = String.Copy(isim);
            return clone;
        }
    }
    #endregion
    #region
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
    #endregion
    #region
    class Program
    {
        static void Main(string[] args)
        {
            kisi p1 = new kisi();
            p1.yas = 42;
            p1.dogumGunu = Convert.ToDateTime("1970-05-29");
            p1.isim = "Tony Stark";
            p1.IdInfo = new IdInfo(3000);

            //P1'in basit bir kopyasını(Shallow) yapın ve p2'ye atayın.
            kisi p2 = p1.ShallowCopy();
            // P1'in derin bir kopyasını(Deep Copy) alın ve p3'e atayın.
            kisi p3 = p1.DeepCopy();

            // P1, p2 ve p3 değerlerini görüntüleyin.
            Console.WriteLine("P1, p2, p3'ün orijinal değerleri:");
            Console.WriteLine("   p1 örnek değerleri: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 örnek değerleri:");
            DisplayValues(p2);
            Console.WriteLine("   p3 örnek değerleri:");
            DisplayValues(p3);

            // P1 özelliklerinin değerini değiştirin ve p1, p2 ve p3 değerlerini görüntüleyin.
            p1.yas = 32;
            p1.dogumGunu = Convert.ToDateTime("1900-01-01");
            p1.isim = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nP1'e değiştikten sonra p1, p2 ve p3 değerleri:");
            Console.WriteLine("   p1 örnek değerleri: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 örnek değerleri (referans değerleri değişti):");
            DisplayValues(p2);
            Console.WriteLine("   p3 örnek değerleri (her şey aynı tutuldu):");
            DisplayValues(p3);
            Console.ReadLine();
        }
        #endregion
        #region
        public static void DisplayValues(kisi p)
        {
            Console.WriteLine("      isim: {0:s}, yas: {1:d}, dogumGunu: {2:MM/dd/yy}",
                p.isim, p.yas, p.dogumGunu);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
        #endregion
    }
}