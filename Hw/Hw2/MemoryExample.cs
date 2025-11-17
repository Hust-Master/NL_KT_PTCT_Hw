using System;

class MemoryExample
{
    class MyClass
    {
        public int Value;
    }

    static void Main()
    {
        // Cấp phát bộ nhớ
        MyClass obj = new MyClass();
        obj.Value = 42;

        Console.WriteLine(obj.Value);

        // Giải phóng bộ nhớ (không cần delete, GC tự xử lý)
        obj = null;
        GC.Collect(); // bắt GC chạy ngay (thường không cần gọi)
    }
}
