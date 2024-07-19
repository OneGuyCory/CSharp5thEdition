Console.WriteLine("How many chocolate eggs were gathered?");
int eggs = Convert.ToInt32(Console.ReadLine());
int sisterEggs = eggs / 4;
int duckbearEggs = eggs % 4;

Console.WriteLine("Each sister gets " + sisterEggs + " eggs.");
Console.WriteLine("The duckbear will get " + duckbearEggs + " eggs.");