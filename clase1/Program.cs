// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Linq;

Console.WriteLine("Hello, World!");

/*string nombre = "Jose";

int edad = 26;
string edadString = "12";

Console.WriteLine("Hola " + nombre + " tienes " + edad + " años");

string concatenado1 = "Hola " + nombre + " tienes " + edad + " años";
int concatenado2 = edad + 12;
string concatenado3 = edad + "12";
string concatenado4 = $"Hola {nombre} tienes {edad} años";

Console.WriteLine("concatenado4: " + concatenado4);

Console.WriteLine("Suma " + concatenado2);
Console.WriteLine("Suma2 " + concatenado3);

int sumaNumeros = edad + int.Parse(edadString);
Console.WriteLine("sumaNumeros: " + sumaNumeros);*/

bool esMayor = false;
bool es_mayor = true;

float precio = 12.5f;
double precio2 = 12.5;
decimal precio3 = 12.5m;
DateTime fecha = DateTime.Now;
DateTime fecha2 = new DateTime(2024, 01, 02);

// Pascal Case (Archivos, Clases, Metodos)
string StringNumericoSumar = "12";
// Camel Case (variables)
string stringNumericoSumar = "12";
// Snake Case (variables complejas)
string string_numerico_sumar = "12";


double facturaCabecera_valorTotal = 0;
int facturaCabecera_cantidadProductos = 0;

/*
Mayor que: >
Menor que: <
Mayor o igual que: >=
Menor o igual que: <=
Igual que: ==
Diferente que: !=

*/

/*
Y: &&
Or: ||
Not: !

*/

/*int edadMinima = 14;
int edadMaxima = 60;

int edadPersona = -12;

if (!(edadPersona >= edadMinima)) {
    Console.WriteLine("Verdadero");
} else {
    Console.WriteLine("Falso");
}

if (edadPersona >= edadMinima) {
    Console.WriteLine ("Es mayor edad minima");
} else if (edadPersona >= 0) {
    Console.WriteLine("Es mayor a 0");
} else {
    Console.WriteLine("Edad incorrecta, es menor a 0");
}*/

string codigo = "E";

/*if (codigo == "N") {
    Console.WriteLine("Es nombre");
} else if (codigo == "A") {
    Console.WriteLine("Es apellido");
} else if (codigo == "D") {
    Console.WriteLine("Es direccion");
} else {
    Console.WriteLine("No es valido");
}*/

/*switch(codigo) {
    case "N":
        Console.WriteLine("Es nombre");
        break;
    case "A":
        Console.WriteLine("Es apellido");
        break;
    case "D":
        Console.WriteLine("Es direccion");
        break;
    case "C":
    case "E":
        Console.WriteLine("Casoexcepcional");
        break;
    default:
        Console.WriteLine("No es valido");
        break;
}*/

/*
break: termina la ejecucion del switch
continue: termina la ejecucion de la iteracion actual
return: termina la ejecucion del metodo

*/

/*int numeroRecorrido = 1;
int numeroLimiteRecorrer = 10;
for(int i = numeroRecorrido; i <= numeroLimiteRecorrer; i++) {
    int calculoV = i % 2;
    if(calculoV != 0) {
        continue;
    }
    Console.WriteLine("Numero: " + i);
}*/

List<int> listaNumeros = new List<int>();
listaNumeros.Add(10);
listaNumeros.Add(4);
listaNumeros.Add(5);
listaNumeros.Add(3);
listaNumeros.Add(2);
listaNumeros.Add(1);
listaNumeros.Add(17);
listaNumeros.Add(8);
// Console.WriteLine("Lista de numeros: " + listaNumeros.ToString());

/*for(int i = 0; i < listaNumeros.Count; i++) {
    Console.WriteLine("Numero de lista: " + listaNumeros[i]);
}*/

/*foreach(int numeroL in listaNumeros) {
    
    int calculoV = numeroL % 2;
    if(calculoV != 0) {
        continue;
    }
    Console.WriteLine("* Numero de lista: " + numeroL);
}*/

/*int recorridoLista = 0;
while(recorridoLista < listaNumeros.Count) {
    
    int calculoV = listaNumeros[recorridoLista] % 2;
    if(calculoV != 0) {
        recorridoLista++;
        continue;
    }
    Console.WriteLine("Numero de lista: " + listaNumeros[recorridoLista]);
    recorridoLista++;
}*/


// Console.WriteLine("fecha: " + fecha);



/*
 -- Clases y sus propiedad --
 * public: se puede acceder desde cualquier parte del codigo
 * private: solo se puede acceder desde la misma clase
 * protected: solo se puede acceder desde la misma clase y sus clases hijas
*/

// Persona persona1 = new Persona("Jose", "Moran", new DateTime(2015, 01, 02));

// Persona persona2 = new Persona("Juan", "Lopez", new DateTime(1999, 12, 02));

// string variable1;
// string variable2 = "hola.....";
// DateTime fechaPrueba1;
// DateTime fechaPrueba2 = new DateTime(2021, 01, 02);
// DateTime fechaPrueba3;
// fechaPrueba3 = new DateTime(2021, 01, 02);

// Console.WriteLine($"Hola: {persona1.nombre} {persona1.apellido}");
// Console.WriteLine($"Es mayor de edad?: {persona1.EsMayorEdad()}");

// Console.WriteLine($"Hola: {persona2.nombre} {persona2.apellido}");
// Console.WriteLine($"Es mayor de edad?: {persona2.EsMayorEdad()}");

// Console.WriteLine($"Fecha prueba: {fechaPrueba1}");

// List<Persona> listaPersonas = new List<Persona>() {
//     new Persona {
//         nombre = "Jose",
//         apellido = "Moran",
//         fechaNacimiento = new DateTime(2015, 01, 02),
//         mascotas = [],
//         habilidades = new HabilidadesPersona {
//             nadar = true,
//             correr = true,
//             saltar = false
//         }
//     },
//     new Persona {
//         nombre = "Juan",
//         apellido = "Lopez",
//         fechaNacimiento = new DateTime(1999, 12, 02),
//         mascotas = new List<Mascota> {
//             new Mascota {
//                 nombre = "Max",
//                 tipo = "Perro"
//             },
//             new Mascota {
//                 nombre = "Garfield",
//                 tipo = "Gato"
//             }
//         },
//         habilidades = new HabilidadesPersona {
//             nadar = true,
//             correr = true,
//             saltar = true
//         }
//     },
//     new Persona {
//         nombre = "Maria",
//         apellido = "Perez",
//         fechaNacimiento = new DateTime(2000, 12, 02),
//         mascotas = new List<Mascota> {
//             new Mascota {
//                 nombre = "Garfield",
//                 tipo = "Gato"
//             }
//         },
//         habilidades = new HabilidadesPersona {
//             nadar = false,
//             correr = false,
//             saltar = false
//         }
//     },
//     new Persona {
//         nombre = "Pedro",
//         apellido = "Gonzalez",
//         fechaNacimiento = new DateTime(2005, 12, 02),
//         mascotas = new List<Mascota>(),
//         habilidades = new HabilidadesPersona {
//             nadar = false,
//             correr = true,
//             saltar = true
//         }
//     },
//     new Persona {
//         nombre = "Ana",
//         apellido = "Gomez",
//         fechaNacimiento = new DateTime(2007, 01, 02),
//         mascotas = new List<Mascota> {
//             new Mascota {
//                 nombre = "Firulais",
//                 tipo = "Perro"
//             }
//         },
//         habilidades = new HabilidadesPersona {
//             nadar = false,
//             correr = false,
//             saltar = false
//         }
//     },
// };

// foreach(Persona personaItem in listaPersonas) {
//     string mascotasMostrar = "";
//     bool tienePerro = false;
//     foreach(Mascota mascotaItem in personaItem.mascotas) {
//         tienePerro = mascotaItem.tipo == "Perro" ? true : tienePerro;
//         if(mascotasMostrar != "") {
//             mascotasMostrar += ", ";
//         }
//         mascotasMostrar += $"{mascotaItem.nombre} es de tipo {mascotaItem.tipo}";
//     }
//     if(!(tienePerro && personaItem.habilidades.correr)) {
//         continue;
//     }
//     Console.WriteLine($"Hola: {personaItem.nombre} {personaItem.apellido}, Sus mascotas: {mascotasMostrar}");
// }



string ambiente = "prod";

Ambiente ambienteConfig = null;
switch(ambiente) {
    case "prod":
        ambienteConfig = new Prod();
        break;
    case "dev":
        ambienteConfig = new Dev();
        break;
}


Console.WriteLine($"Url Servicio: {ambienteConfig.urlServicio}");

List<int> listaNumeros2 = new List<int>() {
    4, // posicion 0
    3, // posicion 1
    8, // posicion 2
    2, // posicion 3
    5, // posicion 4
    1 // posicion 5
};

listaNumeros2.Add(11); // posicion 6

// int producto1 = 20;
// double precioProducto1 = 12.5;

// double saldoPersona1 = 200;

// try {
//     listaNumeros2.RemoveAt(7);
//     // listaNumeros2.Add(int.Parse("a"));
// } catch(ArgumentOutOfRangeException ex) {
//     Console.WriteLine("Error fuera de rango: " + ex.Message);
// } catch (Exception ex) {
//     Console.WriteLine("Error: " + ex.Message);
// }

// double saldoModificar = saldoPersona1;
// int cantidadModificar = producto1;
// try{
//     saldoModificar = saldoPersona1 - precioProducto1;

//     // int.Parse("a");

//     cantidadModificar = producto1 - 1;
// } catch(Exception ex) {
//     saldoModificar = saldoPersona1;
//     cantidadModificar = producto1;
//     Console.WriteLine("Error: " + ex.Message);
// }

// saldoPersona1 = saldoModificar;
// producto1 = cantidadModificar;

// Console.WriteLine("Stock Actual: " + producto1);
// Console.WriteLine("Saldo persona1 : " + saldoPersona1);


// Persona persona1 = new Persona {
//     nombre = "Jose",
//     apellido = "Moran",
//     fechaNacimiento = new DateTime(2015, 01, 02),
//     mascotas = new List<Mascota>(),
//     habilidades = new HabilidadesPersona {
//         nadar = true,
//         correr = true,
//         saltar = false
//     },
//     saldo = 200
// };

// Producto1 producto1 = new Producto1 {
//     nombre = "Billetera",
//     precio = 3.5,
//     stock = 20
// };


// Persona personaMod = persona1;
// Producto1 productoMod = producto1;
// try{
//     personaMod.saldo = persona1.saldo - producto1.precio;
//     productoMod.stock = producto1.stock - 1;
// } catch(Exception ex) {
//     personaMod = persona1;
//     productoMod = producto1;
//     Console.WriteLine("Error: " + ex.Message);

// }
// persona1 = personaMod;
// producto1 = productoMod;


// Console.WriteLine($"Hola: {persona1.nombre} {persona1.apellido}, Saldo: {persona1.saldo}");
// Console.WriteLine($"Stock Actual: {producto1.stock}");


// // Registro del usuario
// envioCorreo("correo1@gmiail.com", 1);



// // Restablecer contraseña
// envioCorreo("correo1@gmail.com", 1);



// bool envioCorreo(string correo, int numeroIntento) {
//     Console.WriteLine($"Enviando correo a: {correo}, Intento: {numeroIntento}");
//     bool enviadoCorreo = false; // enviar correo
//     if(!enviadoCorreo && numeroIntento < 3) {
//         numeroIntento++;
//         return envioCorreo(correo, numeroIntento);
//     }
//     return false;
// }


// Console.WriteLine("Lista de numeros: " + string.Join(", ", listaNumeros2));



List<Persona> listaPersonas = new List<Persona>() {
    new Persona {
        nombre = "Jose",
        apellido = "Moran",
        saldo = 200
    },
    new Persona {
        nombre = "Juan",
        apellido = "Lopez",
        saldo = 233.2
    },
    new Persona {
        nombre = "Maria",
        apellido = "Perez",
        saldo = 100
    },
    new Persona {
        nombre = "Pedro",
        apellido = "Gonzalez",
        saldo = 50
    },
};

List<Producto> listaProductos = new List<Producto>() {
    new Producto {
        id = 1,
        nombre = "Billetera",
        precio = 3.5,
        stock = 20
    },
    new Producto {
        id = 2,
        nombre = "Cartera",
        precio = 5.5,
        stock = 10
    },
    new Producto {
        id = 3,
        nombre = "Bolso",
        precio = 10.5,
        stock = 5
    },
    new Producto {
        id = 4,
        nombre = "Mochila",
        precio = 15.5,
        stock = 3
    },
};


// listaProductos.Add(new Producto {
//     id = 5,
//     nombre = "Tomatodo",
//     precio = 4.5,
//     stock = 5
// });



List<Sucursal> sucursales = new List<Sucursal> {
    new Sucursal {
        nombre = "Sucursal 1",
        direccion = "Direccion 1",
        productos = new List<ProductoN> {
            new ProductoN {
                id = 1,
                nombre = "Billetera",
                precio = 3.5,
                stock = 20
            },
            new ProductoN {
                id = 2,
                nombre = "Cartera",
                precio = 5.5,
                stock = 10
            },
            new ProductoN {
                id = 3,
                nombre = "Bolso",
                precio = 10.5,
                stock = 15
            },
            new ProductoN {
                id = 4,
                nombre = "Mochila",
                precio = 15.5,
                stock = 1
            }
        }
    },
    new Sucursal {
        nombre = "Sucursal 2",
        direccion = "Direccion 2",
        productos = new List<ProductoN> {
            new ProductoN {
                id = 1,
                nombre = "Billetera",
                precio = 3.5,
                stock = 10
            },
            new ProductoN {
                id = 2,
                nombre = "Cartera",
                precio = 5.5,
                stock = 2
            },
            new ProductoN {
                id = 3,
                nombre = "Bolso",
                precio = 10.5,
                stock = 40
            },
            new ProductoN {
                id = 4,
                nombre = "Mochila",
                precio = 15.5,
                stock = 10
            }
        }
    }
};

// List<Sucursal> sucursalesStock = [];
// foreach(Sucursal sucursalItem in sucursales) {
//     bool faltaProductos = false;
//     foreach(ProductoN productoItem in sucursalItem.productos) {
//         if(productoItem.stock < 10) {
//             faltaProductos = true;
//             break;
//         }
//     }
    
//     if(faltaProductos) {
//         sucursalesStock.Add(sucursalItem);
//     }
// }

// List<Sucursal> sucursalesStock2 = sucursales.Where((sucItem) => {
//     return sucItem.productos.Any((prodItem) => {
//         return prodItem.stock < 10;
//     });
// }).ToList();

// Console.WriteLine($"Sucursales falta de stock: {sucursalesStock2.Count}");

string valorBuscar = "";

// while(valorBuscar != "0") {
//     Console.WriteLine("Ingrese el id del producto a buscar, o '0' en caso de querer cerrar");
//     valorBuscar = Console.ReadLine();

//     Producto prodEncontrado = listaProductos.FirstOrDefault((prod) => prod.id == int.Parse(valorBuscar));

//     if(prodEncontrado == null) {
//         Console.WriteLine("Producto no encontrado");
//     } else {
//         Console.WriteLine($"Producto encontrado: {prodEncontrado.nombre}");
//     }

// }


string opcionMenu = "";

while(opcionMenu != "4") {
    switch(opcionMenu) {
        case "1":
            Console.WriteLine("Listado de productos");
            ListarProductos();
            break;
        case "2":
            Console.WriteLine("Ingresar producto");
            IngresarProducto();
            break;
        case "3":
            Console.WriteLine("Eliminar producto");
            EliminarProducto();
            break;
        case "4":
            continue;
    }

    Console.WriteLine("");
    Console.WriteLine("");
    MensajesMenu();
    Console.WriteLine("Ingrese una opcion para continuar...");
    opcionMenu = Console.ReadLine();
}



Clase2 clase2 = new Clase2 {
    clase1 = new Clase1 {
        parametro1 = "Parametro 1"
    }
};


// Clase1 claseT1 = new Clase1 {
//     parametro1 = "Parametro 1"
// };
// Clase2 claseT2 = new Clase2 {
//     clase1 = claseT1
// };

// clase2.clase1.parametro1 = "Modificado";



void MensajesMenu() {
    Console.WriteLine("1 Para listar los productos");
    Console.WriteLine("2 Para ingresar un producto");
    Console.WriteLine("3 Para eliminar un producto");
    Console.WriteLine("4 para finalizar el programa");
}

void ListarProductos() {
    foreach(Producto prodItem in listaProductos) {
        Console.WriteLine($"{prodItem.id} - Producto: {prodItem.nombre}, Precio: {prodItem.precio}, Stock: {prodItem.stock}");
    }
}

void IngresarProducto() {
    Console.WriteLine("Ingrese el nombre del producto");
    string nombreProducto = Console.ReadLine();
    Console.WriteLine("Ingrese el precio del producto");
    double precioProducto = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el stock del producto");
    int stockProducto = int.Parse(Console.ReadLine());

    Producto ultimoProducto = listaProductos.LastOrDefault();
    int idProductoAgregar = ultimoProducto != null ? ultimoProducto.id + 1 : 1;

    listaProductos.Add(new Producto {
        id = idProductoAgregar,
        nombre = nombreProducto,
        precio = precioProducto,
        stock = stockProducto
    });
}

void EliminarProducto() {
    Console.WriteLine("Ingrese el id del producto a eliminar");
    int idProductoEliminar = int.Parse(Console.ReadLine());
    Producto prodEnc = listaProductos.FirstOrDefault((prod) => prod.id == idProductoEliminar);
    if(prodEnc != null) {
        listaProductos.Remove(prodEnc);
    } else {
        Console.WriteLine("Producto no encontrado");
    }
}



class ProductoN {
    public int id {get; set;}
    public string nombre {get; set;}
    public double precio {get; set;}
    public int stock {get; set;}

}

class Sucursal {
    public string nombre {get; set;}
    public string direccion {get; set;}
    public List<ProductoN> productos {get; set;}

}


// // Personas 3, quiere comprar 2 billeteras
// Persona personaModificar = listaPersonas[2];

// Producto productoModificar = listaProductos.First((prodM) => prodM.id == 1);

// Console.WriteLine($"Persona {personaModificar.nombre} {personaModificar.apellido} tiene un saldo de {personaModificar.saldo}");
// Console.WriteLine($"Stock Actual: {productoModificar.stock}");

// Console.WriteLine("Compra de 2 billeteras........");


// double valorDescontar = productoModificar.precio * 2;

// personaModificar.saldo = personaModificar.saldo - valorDescontar;
// productoModificar.stock = productoModificar.stock - 2;

// listaPersonas[2] = personaModificar;
// listaProductos[0] = productoModificar;

// Console.WriteLine($"Persona {personaModificar.nombre} {personaModificar.apellido} tiene un saldo de {personaModificar.saldo}");
// Console.WriteLine($"Stock Actual: {productoModificar.stock}");


// // productoModificar = null;
// // foreach(Producto prodM in listaProductos) {
// //     if(prodM.id == 1) {
// //         productoModificar = prodM;
// //         break;
// //     }
// // }

// if(productoModificar != null) {
//     Console.WriteLine($"Producto: {productoModificar.nombre}");
// } else {
//     Console.WriteLine("Producto no encontrado");

// }

// int cantidadProductos = listaProductos.Count();
// Console.WriteLine($"Cantidad de productos es {cantidadProductos}");

// listaProductos = listaProductos.Where((prod) => prod.stock <= 5).ToList();
// int cantidadProductosF = listaProductos.Count();
// Console.WriteLine($"Cantidad de productos filtrada es {cantidadProductosF}");




class Clase1 {
    public string parametro1 {get; set;}
}

class Clase2 {
    public Clase1 clase1 {get; set;}
}



class ClasePrueba1 {
    public string nombre {get; set; } = "INICIAL";
}

class ClasePrueba2 : ClasePrueba1 {
    public string nombre {get; set; } = "Modificado";
}



interface Ambiente {
    public string urlServicio {get; set;}
    public string urlBD {get; set;}
    public bool mostrarErrores {get; set;}
}


class Prod : Ambiente {
    public string urlServicio {get; set;} = "https://servicio.com";
    public string urlBD {get; set;} = "172.0.0.2";
    public bool mostrarErrores {get; set;} = false;


}

class Dev : Ambiente {
    public string urlServicio {get; set;} = "https://servicio_dev.com";
    public string urlBD {get; set;} = "168.0.0.2";
    public bool mostrarErrores {get; set;} = true;
}

partial class Carro {
    public string marca {get; set;}
    public string modelo {get; set;}
}

partial class Carro {
    public string color {get; set;}
    public string placa {get; set;}
}



/*{
    nombre = "Firulais",
    tipo = "Perro",
    raza = "Pastor Aleman",
    color = "Cafe",
    edad = 5
};
*/

class Persona {
    public string nombre {get; set;}
    public string apellido {get; set;}
    // public DateTime fechaNacimiento {get; set;}
    // public List<Mascota> mascotas {get; set;}
    // public HabilidadesPersona habilidades {get; set;}
    public double saldo {get; set;}


    // public Persona(string nombre, string apellido, DateTime fechaNacimiento, List<Mascota> mascotas) {
    //     this.nombre = nombre;
    //     this.apellido = apellido;
    //     this.fechaNacimiento = fechaNacimiento;
    //     this.mascotas = mascotas;
    // }

    // public bool EsMayorEdad() {
    //     return new DateTime(2006, 5, 22).CompareTo(fechaNacimiento) >= 0;
    // }
}

class Producto {
    public int id {get; set;}
    public string nombre {get; set;}
    public double precio {get; set;}
    public int stock {get; set;}
}

class Mascota {
    public string nombre {get; set;}
    public string tipo {get; set;}

    // public Mascota(string nombre, string tipo) {
    //     this.nombre = nombre;
    //     this.tipo = tipo;
    // }
}

class HabilidadesPersona {
    public bool nadar {get; set;}
    public bool correr {get; set;}
    public bool saltar {get; set;}
}