using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; private set; }
        public Halaman Next { get; set; }

        public Halaman(string url)
        {
            URL = url;
            Next = null;
        }
    }

    public class HistoryManager
    {
        private Halaman top;

        public HistoryManager()
        {
            top = null;
        }

        public void KunjungiHalaman(string url)
        {
            Halaman newPage = new Halaman(url);
            newPage.Next = top;
            top = newPage;
            Console.WriteLine($"Mengunjungi halaman: {url}");
        }

        public string Kembali()
        {
            if (top == null || top.Next == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }
            top = top.Next;
            return top.URL;
        }

        public string LihatHalamanSaatIni()
        {
            return top != null ? top.URL : "Tidak ada halaman dalam history.";
        }

        public void TampilkanHistory()
        {
            Stack<string> tempStack = new Stack<string>();
            Halaman current = top;
            while (current != null)
            {
                tempStack.Push(current.URL);
                current = current.Next;
            }

            while (tempStack.Count > 0)
            {
                Console.WriteLine(tempStack.Pop());
            }
        }
    }
}
