namespace Exercise_Ch10_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 簡單範例，展示 virtual/override 與 new/base 的差別
            Person p = new Person(1, "小明");
            Salesperson s = new Salesperson(2, "小華", 50);
            Person p2 = new Salesperson(3, "小強", 80); // 用父類別變數指向子類別物件

            Console.WriteLine("1) 用 Person 變數呼叫 Person 實例:");
            Console.WriteLine(p.Info());         // Person.Info()
            Console.WriteLine(p.GetName());      // Person.GetName()
            Console.WriteLine();

            Console.WriteLine("2) 用 Salesperson 變數呼叫 Salesperson 實例:");
            Console.WriteLine(s.Info());         // Salesperson.Info()（override）
            Console.WriteLine(s.GetName());      // Salesperson.GetName()（new）
            Console.WriteLine(s.GetSalesName()); // 呼叫 base.GetName()，會回到 Person.GetName()
            Console.WriteLine();

            Console.WriteLine("3) 用 Person 變數指向 Salesperson（多型測試）:");
            Console.WriteLine(p2.Info());        // 會呼叫 Salesperson.Info()（因為 Info 是 virtual 並被 override）
            Console.WriteLine(p2.GetName());     // 會呼叫 Person.GetName()（GetName 不是 virtual，子類用 new 隱藏）
            Console.WriteLine();

            Console.WriteLine("說明：");
            Console.WriteLine("- 若父類的方法用 virtual，子類用 override，則多型會生效（呼叫時會選擇子類的實作）。");
            Console.WriteLine("- 若父類的方法不是 virtual，子類用 new 隱藏，則以父類型呼叫時仍會使用父類的方法。\n");

            Console.WriteLine("按 Enter 結束...");
            Console.ReadLine();
        }
    }
}
