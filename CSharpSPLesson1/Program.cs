using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace CSharpSPLesson1
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox( IntPtr hWnd, string lpText, string lpCaption, uint uType);

        const uint MB_ICONWARNING = 0x0000030;
        const uint MB_CANCELTRYCONTINUE = 0x00000006;
        const uint MB_DEFBUTTON2 = 0x00000100;
        static void Main(string[] args)
        {

            MessageBox(IntPtr.Zero, "Hello world", "Title", MB_ICONWARNING | MB_CANCELTRYCONTINUE | MB_DEFBUTTON2);



            //Process process = new Process();
            //process.StartInfo = new ProcessStartInfo("notepad.exe");
            //process.Start();
            //process.WaitForExit();
            ////process.Kill(); немедленно убить процесс
            ////process.CloseMainWindow(); убирает интерфейсную часть процесса (его главное окно)
            //process.Close(); // высвобождает ресурсы выделенные на процесс
            //Console.WriteLine("После закрытия");
            

            /*Process[] processes = Process.GetProcesses();
            foreach(Process p in processes) 
            {
                Console.WriteLine("{0,-35}{1,10}",p.ProcessName , p.Id); 
            }

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("notepad.exe");
            Console.WriteLine(process.Handle);*/
            
        }
    }
}