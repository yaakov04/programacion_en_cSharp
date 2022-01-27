// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metodos\n");

float[] pricesArray;

pricesArray = new float[10];

pricesArray[0] = 1.5f;
pricesArray[1] = 2.5f;
pricesArray[3] = 3f;
pricesArray[4] = 5f;

/* 
 Un método es un bloque de código que contiene varias instrucciones que podemos ejecutar las veces que necesitemos. Son de gran ayuda cuando tienes que hacer lo mismo 
 varias veces en un mismo programa para no repetir el mismo código una y otra vez.
 */

//invocar un metodo

//instanciamos un objeto de tipo random
Random rnd = new Random();
Console.WriteLine("numero aleatorio");
// llamamos al metodo next(x,y), que es un metodo de la clase random
int randomNum =  rnd.Next(1, 10);
Console.WriteLine(randomNum);

Console.WriteLine("\nrandom price: " + pricesArray[randomNum]);


Console.WriteLine("\n\nMetodos de string\n");

string descartesQuote = "Pienso, luego existo";

Console.WriteLine(descartesQuote);

// metodo Clon(), retorna un objeto por lo que hay que  usando
// convertirlo ToString()

string cloneQuot = descartesQuote.Clone().ToString();

//metodo CompareTo(), si son iguales devuelve 0 y si son diferentes 1

Console.WriteLine(descartesQuote.CompareTo(cloneQuot));

//metodo Contains(), retorna true si contiene los caracteres que se pongan en los argumentos
string word = "Pienso";

bool contiene = descartesQuote.Contains(word);

Console.WriteLine("La cita de de Descartes contiene la palabra <<" + word + ">> es: " + contiene);

/*
 * Otros metodos de strings
 * EndsWith(), retorna un true   si los caracteres están al final
 * StartsWith(), retorna un true si empieza con una serie de caracteres indicados.
 * Equals(), retorna true si el contenido es igual
 * Indexof(), Regresa la posición dentro del string del carácter indicado en el argumento.
 * ToLower() y ToUpper(), Convierten el string en todas letras minúsculas o mayúsculas.
 * Insert(), Inserta un nuevo string dentro de otro en la posición indicada dentro de los argumentos.
 * LastIndexOf(), Regresa la posición de la última vez que aparece el carácter.
 * Remove(), Elimina los caracteres del string a partir de la posición que le indiquemos hasta el final.
 * Replace(), Reemplaza todos los caracteres por otro indicado.
 * Split(), Este es un caso especial donde creamos un nuevo string donde guardamos el string separado en trozos por la letra indicada en los argumentos del método. 
 * Substring(), Devuelve un substring o trozo de string de acuerdo a las posiciones indicadas en los argumentos.
 * ToCharArray(), Convierte el string en un arreglo de caracteres.
 * Trim(), Elimina espacios al principio y al final de un string.
 */


