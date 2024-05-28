
Console.WriteLine("Ingrese el salario mensual del trabajador:");
double salarioMensual = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Ingrese la antigüedad en años del trabajador:");
int antiguedad = Convert.ToInt32(Console.ReadLine());

double utilidad = 0;

switch (antiguedad)
{
    case int n when (n < 1):
        utilidad = salarioMensual * 0.05; 
        break;
    case int n when (n < 2):
        utilidad = salarioMensual * 0.07;
        break;
    case int n when (n < 5):
        utilidad = salarioMensual * 0.10;
        break;
    default:
        utilidad = salarioMensual * 0.20; 
        break;
}

Console.WriteLine("La utilidad anual del trabajador es: $" + utilidad);