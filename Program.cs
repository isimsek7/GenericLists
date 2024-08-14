List<string> Davetliler = new List<string>();
bool looper = true;
Console.WriteLine("Lutfen davetlileri giriniz ve yeterli oldugu zaman yeterli yaziniz.");
while(looper)
{
    string input = Console.ReadLine();
    if(input.ToLower()=="yeterli")
    {
        looper = false;
        break;
    }
        
    Davetliler.Add(input);

}
foreach (string p in Davetliler)
{
    Console.WriteLine(p);
}
