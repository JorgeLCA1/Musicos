class Musico
{
    public string Nombre { get; set; }
    public string Instrumento { get; set; }
    public Musico (string n, string instrumento){
        Nombre = n;
        Instrumento = instrumento;
    }
    public void Saluda()=>Console.WriteLine($"Hola, soy {Nombre} y toco {Instrumento}");
    public virtual void Toca()=>Console.WriteLine($"Estoy tocando {Instrumento}");
    
}
class Baterista:Musico
{
    public string Bateria{get;set;}
    public Baterista(string n, string bateria):base(n)=>Bateria=bateria;
    
}
class Bajista:Musico
{
    public string Bajo {get;set;}
    public Bajista(string n, string bajo):base(n)=> Bajo= bajo;
    public override void Toca()
{
    Console.WriteLine($"{Nombre} Tocando su {bajo}");
}
    
}

internal class Program
{
    private static void Main(string[] args)
    {
List<Musico> SodaStereo = new List<Musico>();
SodaStereo.Add(new Bajo("Zeta", "MusicMan"));
SodaStereo.Add(new Baterista("Charlie", "Tama")); //Esto se le llama polimorfismo

foreach (var m in SodaStereo)
{
    m.Saluda();
}
foreach(var m in SodaStereo)
{
    m.Toca();
}
    }
}