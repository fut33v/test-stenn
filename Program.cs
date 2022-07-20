// Заданы три целочисленные переменные с начальными значениями X=X0, Y=Y0, Z=Z0.
// Поменяйте значения этих переменных так, чтобы X=Y0, Y=Z0, Z=X0.
// Необходимо написать метод, реализующий алгоритм обмена, без использования дополнительных переменных кроме X,Y,Z.

static void Swap(ref int x, ref int y, ref int z) {
    x = x + y + z;
    z = x - (y+z);
    y = x - (y+z);
    x = x - (y+z);
}

int x = 1, y = 2, z = 3;
Console.WriteLine($"x={x} y={y} z={z}");
Swap(ref x, ref y, ref z);
Console.WriteLine($"x={x} y={y} z={z}");

// У автосалона в распоряжении есть парк автомобилей (задана коллекция экземпляров класса Car; Model - марка и модель авто; Color - его цвет; Description - описание особенностей экземпляра). 
// При этом особенности автомобиля автосалону не важны, менеджер различает автомобили лишь по марке, модели и цвету.
// Напишите переопределение Equals и GetHashCode для класса так, чтобы оно наилучшим образом соответствовало условиям задачи.
var tesla = new Car("tesla", "white", "some stuff");
var vaz = new Car("vaz", "black", "without abs");
var vazAbs = new Car("vaz", "black", "with abs");

Console.WriteLine("tesla equals vaz:");
Console.WriteLine(tesla.Equals(vaz));
Console.WriteLine("vaz equals vazAbs:");
Console.WriteLine(vaz.Equals(vazAbs));

// Реализовать алгоритм, который возвращает все имена Name, содержащиеся в этом дереве.
var tree = new Tree();
tree.Children = new Tree[3]{new Tree{Name="One"}, new Tree{Name="Two"}, new Tree{Name="Three"}};
var names = tree.GetNames();
Console.WriteLine("names:");
foreach (var n in names) {
    Console.WriteLine(n);
}