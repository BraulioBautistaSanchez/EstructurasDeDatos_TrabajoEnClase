List<string> Enemys = new List<string>();
Enemys.Add("Orco");
Enemys.Add("Araña");
Enemys.Add("Minotauro");
Enemys.Add("Zombie");
Enemys.Add("Esqueleto");

string[] hotbar = new string[5];
hotbar[0] = "Espada";
hotbar[1] = "Escudo";
hotbar[2] = "Poción";
hotbar[3] = "Hacha";
hotbar[4] = "Flor";

int enemigosVivos = Enemys.Count;

while (enemigosVivos > 0)
{
    Console.WriteLine("¡Cuidado! Tienes " + enemigosVivos + " enemigos adelante:");

    Console.WriteLine("A continuación, escribe un número del 1 al 5 para escoger a que enemigo te vas a enfrentar:");
    int numEnemigo;
    if (!int.TryParse(Console.ReadLine(), out numEnemigo) || numEnemigo < 1 || numEnemigo > Enemys.Count)
    {
        Console.WriteLine("Opción no válida.");
        continue;
    }
    numEnemigo = numEnemigo - 1;

    if (Enemys[numEnemigo] == "(derrotado)")
    {
        Console.WriteLine("Aquí ya no existe enemigo.");
        continue;
    }

    Console.WriteLine("\nTe enfrentas a: " + Enemys[numEnemigo]);
    Console.WriteLine("\nTu inventario tiene: " + string.Join(" | ", hotbar));
    Console.WriteLine("¿Con qué atacas? ()");

    int numObjeto;
    if (!int.TryParse(Console.ReadLine(), out numObjeto) || numObjeto < 1 || numObjeto > 5)
    {
        Console.WriteLine("Opción no válida.");
        continue;
    }
    numObjeto = numObjeto - 1;

    if (hotbar[numObjeto] == "vacío")
    {
        Console.WriteLine("Ese espacio está vacío, no tienes nada ahí.");
        continue;
    }

    Console.WriteLine("\nAtacas al " + Enemys[numEnemigo] + " con " + hotbar[numObjeto] + " y... ¡lo derrotas!\n");

    Enemys[numEnemigo] = "(derrotado)";
    enemigosVivos = enemigosVivos - 1;
    hotbar[numObjeto] = "vacío";
}

Console.WriteLine("\n¡Ganaste! Derrotaste a todos los enemigos.");