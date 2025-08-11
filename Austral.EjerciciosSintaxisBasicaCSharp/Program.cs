// =====================
// 1. Variables y Tipos
// =====================

// a) Declarar una variable con el nombre de una empresa y mostrarla por consola.
using System;
using System.ComponentModel.Design;
using System.Net.Http.Json;

string variableEmpresa = "Mc Donald's";
Console.WriteLine("El nombre de la empresa es: " + variableEmpresa);

// b) Declarar una variable con la cantidad de empleados y mostrarla por consola.
int cantidadEmpleados = 100;
Console.WriteLine("La cantidad de empleados es: " + cantidadEmpleados);

// c) Declarar una variable decimal con el ingreso mensual estimado.
float ingresoMensual = 2250.50f;
Console.WriteLine("El ingreso mensual es de: " + ingresoMensual + " pesos");

// d) Mostrar por consola un mensaje que diga el nombre de la empresa, cantidad e empleados e ingreso.
Console.WriteLine("La empresa " + variableEmpresa + " trabaja con un total de " + cantidadEmpleados
    + " empleados, que cobran " + ingresoMensual + " por mes.");

// ==============
// 2. Operadores
// ==============

// a) Declarar dos precios de productos y calcular el total de los dos con IVA
int precioUno = 2000;
int precioDos = 3000;
int sumaPrecios = 2000 + 3000;
int iva = sumaPrecios * 21 / 100;
int precioTotal = sumaPrecios + iva;

Console.WriteLine("El total con IVA es: " + precioTotal);

// b) En base a la siguiente variable -> int ingresoAnual = 1500;
//    Hacer otra variable que represente el ingreso mensual y mostrarla por consola.

int ingresoAnual = 1500;
int ingresoMes = ingresoAnual / 12;

Console.WriteLine("El ingreso mensual es: " + ingresoMes);

// c) Crear una variable que represente si el ingreso anual es mayor a 1000 o no.
bool ingreso = ingresoAnual > 1000;
Console.WriteLine("Es el ingreso anual mayor a 1000? " + ingreso);

// d) Calcular cuánto gana una empresa por mes si su ingreso anual es 1500
//    y tiene que pagar 12% de impuestos al estado.
int impuesto = ingresoAnual * 12 / 100;
int ingresoAnualNeto = ingresoAnual - impuesto;
int gananciaMensual = ingresoAnualNeto / 12;

Console.WriteLine("El ingreso mensual de la empresa es " + gananciaMensual);


// ==========================
// 3. Estructuras de Control
// ==========================

// a) En base a la cantidad de empleados de una empresa, mostrar por consola el tamaño de la misma:
//     - Si tiene 10 o menos empleados → "Startup"
//     - Si tiene Entre 11 y 50 → "Pyme"
//     - Si tiene más de 50 → "Big"

cantidadEmpleados = 20;

if (cantidadEmpleados <= 10)
{
    Console.WriteLine("La empresa es una Startup");
}
else if (cantidadEmpleados > 50)
{
    Console.WriteLine("La empresa es Big");
}
else
{
    Console.WriteLine("La empresa es una Pyme");
}


// b) En base al monto de inversión de una empresa, clasificar la inversión como:
//     - Si es menor a 10,000 → "Baja"
//     - Si está entre 10,000 y 100,000 → "Media"
//     - Si es mayor a 100,000 → "Alta"

int montoInversion = 120000;

if (montoInversion < 10000)
{
    Console.WriteLine("La inversion es baja");
}

else if (montoInversion > 100.000)
{
    Console.WriteLine("La inversion es alta");
}

else
{
    Console.WriteLine("La inversion es media");
}

// c) Según el tipo de cliente ("mayorista" o "minorista"), mostrar el precio final de un producto con descuento si corresponde:
//     - Si es mayorista → 20% de descuento
//     - Si es minorista → precio completo

int precio = 200;
string cliente = "mayorista";

int descuentoMayorista = precio * 20 / 100;
int precioMayorista = precio - descuentoMayorista;

if (cliente == "mayorista")
{
    Console.WriteLine("El precio para el cliente mayorista es: " + precioMayorista);
}
else if (cliente == "minorista")
{
    Console.WriteLine("El precio para el cliente minorista es: " + precio);
}

//C.ALT- Hacerlo con switch, y agregando consumidor final - 80% descuento

int descuentoConsumidorFinal = precio * 80 / 100;
int precioConsumidorFinal = precio - descuentoConsumidorFinal;

switch (cliente)
{
    case "mayorista":
        Console.WriteLine("El precio para el cliente mayorista es: " + precioMayorista);
        break;
    case "minorista":
        Console.WriteLine("El precio para el cliente minorista es: " + precio);
        break;
    case "consumidor final":
        Console.WriteLine("El precio para el cliente final es: " + precioConsumidorFinal);
        break;
    default:
        Console.WriteLine("Tipo de cliente no encontrado");
        break;
}

// d) Una distribuidora tiene 20 unidades de cerveza en stock. Un cliente solicita 25 unidades.
//    Verificar si hay suficiente stock para concretar la venta:
//     - Si alcanza, mostrar por consola: "Venta confirmada. Cervezas en stock suficientes."
//     - Si no alcanza, mostrar: "No hay suficientes cervezas en stock. Faltan X unidades."
//       (donde X debe calcularse dinámicamente en base a las variables)

int unidadesStock = 20;
int solicitudCliente = 25;

if (unidadesStock >= solicitudCliente)
{
    Console.WriteLine("Venta confirmada. Cervezas en stock suficientes.");
}
else
{
    Console.WriteLine("No hay suficientes cervezas en stock. Faltan 5 unidades.");
}

// ==========
// 4. Bucles
// ==========

// a) Mostrar los primeros 10 números naturales usando un for.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Los 10 primeros numeros naturales son: " + i);
}

// b) Dado este array que representa las ventas de una empresa:
//    int[] ventasMensuales = { 1000, 1200, 950, 1100 };
//    Sumar las ventas mensuales con un foreach y mostrar el total por consola.

int[] ventasMensuales = { 1000, 1200, 950, 1100 };

int ventasTotales = 0;

foreach (int venta in ventasMensuales)
{
    ventasTotales = ventasTotales + venta; //+= significa: sumale el valor de i a suma y guardá el resultado en suma.
    Console.WriteLine(venta);
}
Console.WriteLine("total de ventas: " + ventasTotales);
//podria usar 'i' en vez de 'ventas', como podria usar 'suma' en vez de 'ventasTotales'

// c) Hacer una cuenta regresiva del 5 al 1 con while.

int n = 5;
do
{
    Console.Write(n);
    n--;
} while (n > 0);

// d) Simular un login: pedir usuario hasta que ingrese "admin" con do-while.

//d.ALT - crear variable de reitentos, proponer numeros de reitentos y al final de la
//ejeccucion mostrar si el usuario pudo acceder al panel o si todos los intentos fueron fallidos

string usuario = "";
int intentosRestantes = 3;

do
{

    Console.WriteLine("Ingrese el usuario");
    usuario = Console.ReadLine(); //lo q vos ingreses a la consola lo guarde como usuario.

    if (usuario == "admin")
    {
        Console.WriteLine("La contrasena ingresada es correcta");
        break;
    }
    else if (usuario != "admin" && intentosRestantes > 0)
    {
        intentosRestantes--;
        Console.WriteLine("La contrasena ingresada es incorrecta. Quedan " + intentosRestantes + " intentos restantes.");
    }
} while (intentosRestantes > 0);

if (usuario == "admin")
{
    Console.WriteLine("El acceso ha sido concedido");
}
else
{
    Console.WriteLine("No puedes acceder a la cuenta");
}

//=============
//5.Funciones
//=============

//a) Crear una función que reciba el ingreso mensual y devuelva el anual.
//   Llamar a la función y mostrar el resultado en consola.

Console.WriteLine("Escriba el ingreso mensual: ");
int ingresoUno = int.Parse(Console.ReadLine());
int CalculoAnual(int ingresoUno)
{
    return ingresoUno * 12;
}

int Resultado = CalculoAnual(ingresoUno);
Console.WriteLine("El ingreso anual es: " + Resultado);

// b) Crear una función que reciba una edad y devuelva si es mayor o menor de edad.
//    Llamar a la función y mostrar el resultado en consola.

Console.WriteLine("Ingreses edad");
int edad = int.Parse(Console.ReadLine());

string VerificarEdad(int edad)
{
    if (edad >= 18)
    {
        return "Mayor";
    }
    else
    {
        return "Menor";
    }
}
var ResultadoDos = VerificarEdad(edad);
Console.WriteLine(ResultadoDos);

// c) Crear una función que reciba el precio y el tipo de cliente y devuelva el precio final con o sin descuento.
//    Llamar a la función y mostrar el resultado en consola.

Console.WriteLine("Escriba el precio: ");
double precio1 = double.Parse(Console.ReadLine());

Console.WriteLine("Escriba el tipo de cliente: ");
string cliente1 = (Console.ReadLine());

double PrecioFinal(double precio1, string cliente1)
{
    if (cliente1 == "mayorista")
    {
        return precio1 - (precio1 * 0.20);
    }
    
    else if (cliente1 == "minorista")
    {
        return precio1;
    }

    else
    {
        Console.WriteLine("El cliente ingresado no existe");
        return 0;
    }
}

Console.WriteLine("El precio final es: " + PrecioFinal(precio1, cliente1));


// ===================
// 6. Listas y arrays
// ===================

// a) Crear un array con nombres de 3 productos y mostrarlos por consola. AGREGAMOS TMB LISTA

string[] Productos = { "hoja", "lapiz", "birome"};
foreach (string producto in Productos)
{
    Console.WriteLine("Los productos son: " + producto);
}

List<string> ProductosDos = new List<string>(); //creamos lista vacia
ProductosDos.Add("calculadora"); ProductosDos.Add("boligoma");
foreach (string producto2 in ProductosDos)
{
    Console.WriteLine("Los productos nuevos son: " + producto2);
}

// b) Crear un array con los ingresos trimestrales (double) y calcular el total anual.

double sumatoria1 = 0;
double[] ingresosTrimestrales = { 300, 200, 100, 400 };
int cantidadTrimestres = 4;
foreach (double ingreso1 in ingresosTrimestrales)
{
    sumatoria1 = sumatoria1 + ingreso1; // Sumar en cada iteración

}
Console.WriteLine("La suma anual de los ingresos trimestrales es " + sumatoria1);


// c) Mostrar el producto más vendido de un array con cantidades vendidas.

double[] cantidadesVendidas = {100, 500, 1000, 900 };

double mayorCantidad = cantidadesVendidas[0]; //significa "el primer elemento del array"
//En tu ejemplo cantidadesVendidas es {100, 500, 1000, 900},
//así que cantidadesVendidas[0] vale 100.
//Guardamos ese valor (100) en la variable mayorCantidad.
//Esto es nuestra cantidad más alta encontrada hasta ahora.

int posicionMayor = 0; //guarda el indice del elemento. Los arrays empiezan en 0, así que el primer producto está en la posición 0.

for (int i = 1; i < cantidadesVendidas.Length; i++)
//Este for recorre el array desde el segundo elemento (i = 1),
//porque el primero ya lo tomamos como referencia.
//i < cantidadesVendidas.Length → el bucle se repite mientras i sea menor que 4 (longitud del array).
//En cada vuelta, revisamos si el elemento en la posición i es mayor que mayorCantidad.
{
    if (cantidadesVendidas[i] > mayorCantidad)
    {
        mayorCantidad = cantidadesVendidas[i];
        posicionMayor = i;
    }
}
Console.WriteLine("El producto más vendido es el número " + (posicionMayor + 1) +  " con " + mayorCantidad + " ventas.");

// d) Crear una lista de precios y calcular el promedio.
//    Usar List<double> para practicar con listas.

int sumatoria = 0;

List<double> Precios = new List<double>();
Precios.Add(200); Precios.Add(100); Precios.Add(50);
foreach (int i in Precios)
{
    sumatoria = sumatoria + i;   
}

double promedio = sumatoria / Precios.Count; // Precios.Count devuelve cant de precios q tengo
Console.WriteLine("El promedio de los precio es: " + promedio);

//CON READLINE

double sumatoria2 = 0;
List<double> Precios2 = new List<double>();
int respuesta;

//Repeticion permanente hasta una condicion de salida
do
{
    double i = double.Parse(Console.ReadLine());  //double.Parse es convertir lo q esta entre parentesis. En string lo convierte a double
    Precios2.Add(i);

    Console.WriteLine("Desea ingresar un nuevo producto?");
    respuesta = int.Parse(Console.ReadLine());
}

while (respuesta == 1);

//  dowhile para premitir otro ingreso de datos,      
//  continuar con un igreso de datos. Entra a bloque do. 
//  repetir este bloque mientras condicion es verdadera. rta ==1, 
//  si usuario apretaba 1, te permitia ingresar de nuevo otro precio. 

foreach (var item in Precios2)
{
    sumatoria2 = sumatoria2 + item;

Console.WriteLine(sumatoria2);
}


