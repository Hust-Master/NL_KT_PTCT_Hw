# Homework 2
Lựa chọn 1 công cụ/ngôn ngữ lập trình mà nhóm thống nhất là nắm vững nhất:
1. Minh họa ý tưởng phân tích chương trình sử dụng Dataflow Analysis
2. Minh họa ý tưởng phân tích mã nguồn chương trình sử dụng kỹ thuật CFG
3. Minh họa các thuật cấp phát bộ nhớ và giải phóng bộ nhớ
4. Minh họa ý tưởng sử dụng và giải phóng pointer


## 1. Minh họa ý tưởng phân tích chương trình sử dụng Dataflow Analysis
Dataflow Analysis là kỹ thuật theo dõi giá trị biến tại từng điểm trong chương trình. Ví dụ: xác định giá trị có thể của biến x tại mỗi dòng.

```csharp
using System;

class DataflowExample
{
    static void Main()
    {
        int x = 0;  // Dòng 1
        int y = 5;  // Dòng 2

        if (y > 3)  // Dòng 3
        {
            x = y + 1; // Dòng 4
        }
        else
        {
            x = y - 1; // Dòng 5
        }

        Console.WriteLine(x); // Dòng 6
    }
}
```

Phân tích:
- Trước dòng 3: x=0, y=5
- Nếu nhánh if đi vào (đúng): x = 6
- Nếu nhánh else đi vào (sai): x = 4
- Dòng 6: x ∈ {4,6}  

Đây là lấy tập giá trị khả dĩ cho mỗi biến tại mỗi điểm, ý tưởng cơ bản của Dataflow Analysis.

## 2. Minh họa ý tưởng phân tích mã nguồn chương trình sử dụng kỹ thuật CFG


## 3. Minh họa các thuật cấp phát bộ nhớ và giải phóng bộ nhớ
Trong C#, bộ nhớ cho objects được cấp phát trên heap và garbage collector tự động giải phóng.
```csharp
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
```
Ý tưởng:
- new MyClass() cấp phát heap
- obj = null làm object không còn tham chiếu → GC sẽ giải phóng


## 4. Minh họa ý tưởng sử dụng và giải phóng pointer
Trong C#, pointer chỉ dùng được trong unsafe context:

```csharp
unsafe static void Main()
{
    int x = 10;
    int* px = &x;  // Lấy địa chỉ

    Console.WriteLine("Value of x via pointer: " + *px);

    *px = 20;  // Thay đổi giá trị thông qua pointer
    Console.WriteLine("New value of x: " + x);

    // Không cần free, vì C# quản lý stack
}
```

Chú ý:
- Cần bật unsafe trong project
- Bộ nhớ stack tự động giải phóng khi thoát scope