// See https://aka.ms/new-console-template for more information
using BangKhaiTan_Lab03;

MyList list = new MyList();
list.Input();
list.ShowList();
Console.WriteLine("Nhap so can tim: ");
int x = Convert.ToInt32(Console.ReadLine());
IntNode kq = list.SearchX(x);
if (kq == null)
    Console.WriteLine("khong tim thay: ");
else
    Console.WriteLine("Tim thay: ");
Console.WriteLine("Gia tri lon nhat la: " + list.GetMax());