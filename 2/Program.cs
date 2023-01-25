int x1 = InputInt("Введите координату X первой точки: ");
int y1 = InputInt("Введите координату Y первой точки: ");
int z1 = InputInt("Введите координату Z первой точки: ");
int x2 = InputInt("Введите координату X второй точки: ");
int y2 = InputInt("Введите координату Y второй точки: ");
int z2 = InputInt("Введите координату Z второй точки: ");

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;
double length = Math.Sqrt(A * A + B * B + C * C);

System.Console.WriteLine($"Длинна отрезка {length}");