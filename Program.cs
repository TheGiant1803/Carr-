/* Sous-programme : calcule coin coin le petit canard 
    Paramètre d'entrée:
    -i : entier dont on souhaite le carré (entrée)
    valeur de retour : le carré de i */int carre(int i){
    return i*i;
}
int val=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(carre(val));