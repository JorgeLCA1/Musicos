class Musico
{
    public string Nombre { get; set; }
   
    public Musico (string n){
        Nombre = n;
        
    }
    public void Saluda()=>Console.WriteLine($"Hola, soy {Nombre}");
    public virtual void Toca()=>Console.WriteLine($"Estoy tocando");
    
}
class Baterista:Musico
{
    public string Bateria{get;set;}
    public Baterista(string n, string bateria):base(n)=>Bateria=bateria;
    
}
class Bajista:Musico
{
    public string bajo {get;set;}
    public Bajista(string n, string b):base(n)=> bajo= b;
    public override void Toca()
{
    Console.WriteLine($"{Nombre} Tocando su instrumento");
}
    
}

internal class Program
{
    private static void Main(string[] args)
    {
List<Musico> SodaStereo = new List<Musico>();
SodaStereo.Add(new Bajista("Zeta", "MusicMan"));
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