using System.Diagnostics;
Process[] process = Process.GetProcesses();
for(int i=0; i<process.Length; i++)
{
    Console.WriteLine(process[i].ProcessName);
}    
