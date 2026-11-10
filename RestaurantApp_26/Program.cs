using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Quanjude Roast Duck", Type = "Beijing Cuisine", Rating = 4.5 },
                new Restaurant { Id = 2, Name = "Donglaishun Hot Pot", Type = "Hot Pot", Rating = 4.6 },
                new Restaurant { Id = 3, Name = "Din Tai Fung", Type = "Taiwanese Cuisine", Rating = 4.7 },
                new Restaurant { Id = 4, Name = "Huguosi Snacks", Type = "Snacks", Rating = 4.2 },
                new Restaurant { Id = 5, Name = "Haidilao Hot Pot", Type = "Hot Pot", Rating = 4.8 },
                new Restaurant { Id = 6, Name = "Siji Minfu", Type = "Beijing Cuisine", Rating = 4.6 }
            };

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("===== RestaurantApp =====");
                Console.WriteLine("1. แสดงร้านอาหารทั้งหมด");
                Console.WriteLine("2. กรองร้านตามประเภท");
                Console.WriteLine("3. ค้นหาร้านตามชื่อ");
                Console.WriteLine("4. สรุปคะแนนร้านอาหาร");
                Console.WriteLine("0. ออกจากโปรแกรม");
                Console.Write("เลือกเมนู: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("=== รายชื่อร้านอาหาร ===");
                        foreach (Restaurant r in restaurants)
                        {
                            Console.WriteLine(
                            r.Id + " | " +
                            r.Name + " | " +
                            r.Type + " | " +
                            r.Rating
                            );
                        }
                        break;

                    case "2":
                        Console.Write("กรอกประเภทอาหาร: ");
                        string type = Console.ReadLine();
                        bool foundType = false;
                        foreach (Restaurant r in restaurants)
                        {
                            if (r.Type.Equals(type, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(
                                r.Name + " | " +
                                r.Type + " | " +
                                r.Rating
                                );
                                foundType = true;
                            }
                        }
                        if (!foundType)
                        {
                            Console.WriteLine("ไม่พบร้านอาหารประเภทนี้");
                        }
                        break;

                    case "3":
                        Console.Write("กรอกชื่อร้านที่ต้องการค้นหา: ");
                        string keyword = Console.ReadLine();
                        bool foundName = false;
                        foreach (Restaurant r in restaurants)
                        {
                            if (r.Name.IndexOf(
                            keyword,
                            StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                Console.WriteLine(
                                r.Name + " | " +
                                r.Type + " | " +
                                r.Rating
                                );
                                foundName = true;
                            }
                        }
                        if (!foundName)
                        {
                            Console.WriteLine("ไม่พบร้านอาหาร");
                        }
                        break;

                    case "4":
                        double total = 0;
                        double highest = double.MinValue;
                        foreach (Restaurant r in restaurants)
                        {
                            total += r.Rating;
                            if (r.Rating > highest)
                            {
                                highest = r.Rating;
                            }
                        }
                        double average = total / restaurants.Count;
                        Console.WriteLine("จำนวนร้าน: " + restaurants.Count);
                        Console.WriteLine("คะแนนเฉลี่ย: " + average.ToString("F2"));
                        Console.WriteLine("คะแนนสูงสุด: " + highest);
                        break;

                    case "0":
                        Console.WriteLine("ปิดโปรแกรม");
                        return;
                    default:
                        Console.WriteLine("ยังไม่เปิดใช้งานเมนูนี้");
                        break;
                }
            }

        }
    }
        namespace StoreRatingFeature
        {
        // 1. โมเดลข้อมูลร้านค้า
        public class Store
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Rating { get; set; }
        }

        public class Program
        {
            public static void GoodRating()
            {
                // ข้อมูลจำลองร้านค้า
                List<Store> stores = new List<Store>
            {
                new Store { Id = 1, Name = "ร้านกาแฟ A", Rating = 4.8 },
                new Store { Id = 2, Name = "ร้านชา B", Rating = 4.2 },
                new Store { Id = 3, Name = "ร้านเบเกอรี่ C", Rating = 4.5 },
                new Store { Id = 4, Name = "ร้านอาหาร D", Rating = 3.9 },
                new Store { Id = 5, Name = "ร้านไอศกรีม E", Rating = 5.0 }
            };

                // 2. กรองข้อมูลเฉพาะร้านที่มีคะแนนตั้งแต่ 4.5 ขึ้นไป (Rating >= 4.5)
                var highRatedStores = stores.Where(s => s.Rating >= 4.5).ToList();

                // 3. แสดงผลลัพธ์
                Console.WriteLine("=== รายชื่อร้านค้าที่มีคะแนน 4.5 ขึ้นไป ===");
                foreach (var store in highRatedStores)
                {
                    Console.WriteLine($"- {store.Name} (คะแนน: {store.Rating})");
                }
            }
        }
    }
}

