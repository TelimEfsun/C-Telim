using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_10_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy();

            Medicine med1 = new Medicine("Paracetamol", 2.5, 100);
            Medicine med2 = new Medicine("Aspirin", 3.0, 50);

            pharmacy.AddMedicine(med1);
            pharmacy.AddMedicine(med2);

            pharmacy.Sell("Paracetamol", 10); // 10 ədəd satılır
            pharmacy.Sell("Aspirin", 5); // 5 ədəd satılır

            Console.WriteLine($"Gelir: {pharmacy.TotalIncome} AZN");

            var found = pharmacy.FindMedicineByName("Aspirin");
            if (found != null)
                Console.WriteLine($"Tapilan derman: {found.Name}, Sayı: {found.Count}");
        }

        public class Medicine
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Count { get; set; }

            public Medicine(string name, double price, int count)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Dermanin adi bos ola bilmez");
                }
                if (price <= 0)
                {
                    throw new ArgumentException("Dermanin qiymeti 0-dan yuxari olmalidir");
                }
                if (Count < 0)
                {
                    throw new ArgumentException("Dermanin sayi minimum 1 olmalidir");
                }

                Name = name;
                Price = price;
                Count = count;
            }


        }

        public class Pharmacy
        {
            private List<Medicine> Medicines = new List<Medicine>();

            private double totalIncome;
            public double TotalIncome => totalIncome;

            public void AddMedicine(Medicine medicine)
            {
                if (Medicines.Exists(m => m.Name.Equals(medicine.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Bu adda derman artiq movcuddur.");
                    return;
                }

                Medicines.Add(medicine);
            }

            public Medicine FindMedicineByName(string name)
            {
                return Medicines.Find(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }

            public void Sell(string name, int count)
            {
                Medicine medicine = FindMedicineByName(name);

                if (medicine == null)
                {
                    Console.WriteLine("Bu adda derman tapelmadi.");
                    return;
                }

                if (count <= 0)
                {
                    Console.WriteLine("Satis miqdari 0-dan boyuk olmalidir.");
                    return;
                }

                if (medicine.Count < count)
                {
                    Console.WriteLine("Yeterli sayda derman yoxdur.");
                    return;
                }

                medicine.Count -= count;
                totalIncome += medicine.Price * count;
                Console.WriteLine($"{count} eded {medicine.Name} satıldı.");
            }
        }



    }
}
