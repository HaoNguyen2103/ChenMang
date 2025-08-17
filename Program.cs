public class Program
{
    public static void Main(string[] args)
    {
        List<int> array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 18, 24, 35, 42, 46 };
        Console.WriteLine("nhap vao so can chen: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap vi tri can chen: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x <0 || x >= array.Count)
        {
            Console.WriteLine("khong the chen phan tu vao mang");
        }
        array.Insert(x, number);
        foreach (int num in array)
            Console.Write(num + " ");
    }
}