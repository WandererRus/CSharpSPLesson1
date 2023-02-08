using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace CSharpSPLesson1
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        const uint MB_ICONWARNING = 0x030;
        const uint MB_CANCELTRYCONTINUE = 0x06;
        const uint MB_DEFBUTTON2 = 0x0100;
        const uint MB_YESNOCANCEL = 0x00000003;

        static int MyMessageBox(int number)
        {
            return MessageBox(IntPtr.Zero, "YES - число угадано верно, " +
                "NO - загаданное число меньше, " +
                "Cancel - загаднное число больше \n Может быть вы загадали " + number.ToString(), 
                "Угадай число", MB_YESNOCANCEL | MB_DEFBUTTON2);
        }
        static void Main(string[] args)
        {
            //2 - cancel, yes - 6, no - 7            
            int minNumber = 0;
            int maxNumber = 100;
            Random random= new Random();
            int result = random.Next(minNumber, maxNumber);
            int answer = 0;
            while ((answer = MyMessageBox(result)) != 6)
            {
                if (answer == 2) 
                {
                    minNumber = result;
                    result = random.Next(minNumber, maxNumber);
                }
                if (answer == 7)
                {
                    maxNumber = result;
                    result = random.Next(minNumber, maxNumber);
                }
            }
            MessageBox(IntPtr.Zero, "Ура, я прочитал ваши мысли! Число " + result.ToString(), 
                "Число угадано", 0x0);


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