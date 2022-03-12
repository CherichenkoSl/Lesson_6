using System.Diagnostics;
Process[] process = Process.GetProcesses();
Console.WriteLine("ID:\tName:");
for(int i=0; i<process.Length; i++)
{
    Console.WriteLine($"{process[i].Id}\t{process[i].ProcessName}");
}
Console.WriteLine("Укажите имя процесса или его ID, который хотите закрыть:");
string killProcess = Console.ReadLine();
if(int.TryParse(killProcess, out int result))
{
    for (int i = 0; i < process.Length; i++)
    {
        Process current = process[i];
        if(current.Id == result)
        {
            current.Kill();
        }
    }
}
else
{
    for (int i = 0; i < process.Length; i++)
    {
        Process current = process[i];
        if(process[i].ProcessName == killProcess)
        {
            current.Kill();
        }
    }
}

