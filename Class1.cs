using System;

public class Person   // 父類別
{
    public int Id;
    public string Name;
    // 建構子
    public Person(int id, string n)
    {
        Id = id;
        Name = n;
    }
    // 物件方法
    public string GetName() { return "姓名: " + Name; }
    public virtual string Info()
    {
        return "編號: " + Id + "\n" +
               "姓名: " + Name;
    }
}
public class Salesperson : Person  // 子類別
{
    private int Sales;
    // 建構子
    public Salesperson(int id, string n, int s) : base(id, n)
    {
        Sales = s;
    }
    // 隱藏方法
    public new string GetName()
    {
        return "業務員: " + Name;
    }
    // 覆寫方法
    public override string Info()
    {
        return "業務員編號: " + Id + "\n" +
               "業務員姓名: " + Name + "\n" +
               "業績(萬): " + Sales;
    }
    // 呼叫父類別的方法
    public string GetSalesName()
    {
        return base.GetName();
    }
}
