// Calcula el IVA de un precio y devuelve el resultado

// Definimos las variables
double precio;
double iva = 1.21;
double total;

Console.WriteLine("Ingrese un número entero");
string texto = Console.ReadLine();
precio = double.Parse(texto);
total = precio * iva;
Console.WriteLine("El precio + IVA es: {0}", total);