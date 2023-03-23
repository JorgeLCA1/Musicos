abstract class Musico
{
    public string Nombre { get; set; }
   
    public Musico (string n){
        Nombre = n;
        
    }
    public void Saluda()=>Console.WriteLine($"Hola, soy {Nombre}");
    public /*virtual*/ abstract void Toca(); //=>Console.WriteLine($"Estoy tocando");
    
}
class Baterista:Musico
{
    public string Bateria{get;set;}
    public Baterista(string n, string bateria):base(n)=>Bateria=bateria;
    public override void Toca() //Para implementar metodos abrtractos se debe de usar el override
{
    Console.WriteLine($"{Nombre} Tocando su instrumento");
}
    
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
SodaStereo.Add(new Musico("Juan"));        
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