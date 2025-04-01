using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager historyManager = new HistoryManager();

        historyManager.KunjungiHalaman("google.com");
        historyManager.KunjungiHalaman("youtube.com");
        historyManager.KunjungiHalaman("portal.its.ac.id");

        Console.WriteLine($"Halaman saat ini : {historyManager.LihatHalamanSaatIni()}");

        Console.WriteLine("Kembali ke halaman sebelumnya");
        historyManager.Kembali();
        Console.WriteLine($"Halaman saat ini: {historyManager.LihatHalamanSaatIni()}");

        Console.WriteLine("Menampilkan history:");
        historyManager.TampilkanHistory();


        // Bracket validator

        BracketValidator validator = new BracketValidator();
        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {validator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {validator.ValidasiEkspresi(ekspresiInvalid)}");



        //Palindrome Checker

        string[] testStrings = { "Kasur ini rusak", "Rumah saya, sayah umur", "Hello World", "Step on no pets" };

        foreach (var test in testStrings)
        {
            Console.WriteLine($"Apakah '{test}' palindrom? {PalindromeChecker.CekPalindrom(test)}");
        }



    }
}
