using System;
using System.Text;
using static System.Console;

namespace FindInText
{
    class Program
    {
        /*static int index = 0;
        static string changeString = "";*/

        static string[] text = {" Вряд ли где можно было найти человека, который так жил бы в своей должности. " +
            "Мало сказать: он служил ревностно, — нет, он служил с любовью. " +
            "Там, в этом переписыванье, ему виделся какой-то свой разнообразный и приятный мир. " +
            "Наслаждение выражалось на лице его; некоторые буквы у него были фавориты, до которых если он добирался, то был сам не свой: и подсмеивался, и подмигивал, и помогал губами, так что в лице его, казалось, можно было прочесть всякую букву, которую выводило перо его. Если бы соразмерно его рвению давали ему награды, он, к изумлению своему, может быть, даже попал бы в статские советники; но выслужил он, как выражались остряки, его товарищи, пряжку в петлицу да нажил геморрой в поясницу. ",
            " Впрочем, нельзя сказать, чтобы не было к нему никакого внимания. " +
            "Один директор, будучи добрый человек и желая вознаградить его за долгую службу, приказал дать ему что-нибудь поважнее, чем обыкновенное переписыванье; именно из готового уже дела велено было ему сделать какое-то отношение в другое присутственное место; дело состояло только в том, чтобы переменить заглавный титул да переменить кое-где глаголы из первого лица в третье. " +
            "Это задало ему такую работу, что он вспотел совершенно, тер лоб и наконец сказал: «Нет, лучше дайте я перепишу что-нибудь». " +
            "С тех пор оставили его навсегда переписывать. ",
            " Вне этого переписыванья, казалось, для него ничего не существовало. Он не думал вовсе о своем платье: вицмундир у него был не зеленый, а какого-то рыжевато-мучного цвета. " +
            "Воротничок на нем был узенький, низенький, так что шея его, несмотря на то что не была длинна, выходя из воротника, казалась необыкновенно длинною, как у тех гипсовых котенков, болтающих головами, которых носят на головах целыми десятками русские иностранцы. " +
            "И всегда что-нибудь да прилипало к его вицмундиру: или сенца кусочек, или какая-нибудь ниточка; к тому же он имел особенное искусство, ходя по улице, поспевать под окно именно в то самое время, когда из него выбрасывали всякую дрянь, и оттого вечно уносил на своей шляпе арбузные и дынные корки и тому подобный вздор. " +
            "Ни один раз в жизни не обратил он внимания на то, что делается и происходит всякий день на улице, на что, как известно, всегда посмотрит его же брат, молодой чиновник, простирающий до того проницательность своего бойкого взгляда, что заметит даже, у кого на другой стороне тротуара отпоролась внизу панталон стремешка, — что вызывает всегда лукавую усмешку на лице его." };
        static void Main(string[] args)
        {
            while (true)
            {
                FindText();
            }
        }

        static void FindText()
        {
            /*index = ReadIndex(index);*/
            string str = ReadFindString(); 

            for (int i = 0; i < text.Length; i++)
            {
                StringBuilder sb = new StringBuilder(text[i]);
                sb.Replace(str, CreateString4ReplaceAndFind(str));
                WriteTextWithColor(sb, str);
            }
            WriteLine();
        }

        static void WriteTextWithColor(StringBuilder text, string str)
        {
            WriteLine();
            for (int i = 0; i < text.Length; i++)
            { 
                if (text[i] == '*')
                {
                    ForegroundColor = ConsoleColor.Green;
                    Write(str);
                    i += str.Length - 1;
                    ResetColor();
                    continue;
                }
                Write(text[i]);
            }
            WriteLine();
        }

        /*static string ReplaceOrFind(int index)
        {
            var str = "";
            switch (index)
            {
                case 0:
                    WriteLine("Режим подсвечивания совпадений ");
                    break;
                case 1:
                    WriteLine("Режим замены совпадений ");
                    str = ReadReplaceString();
                    break;
            }
            return str;
        }*/
        static string ReadFindString()
        {
            WriteLine("Введите строку для поиска: ");
            var str = ReadLine();
            while (str == "")
            {
                Error.WriteLine("Вы ввели пустую строку");
                WriteLine("Введите строку для поиска: ");
                str = ReadLine();
            }
            return str;
        }

       /* static string ReadReplaceString()
        {
            WriteLine();
            var str = ReadLine();
            return str;
        }*/

       /* static int ReadIndex(int index)
        {
            var key = ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.F1:
                    Clear();
                    ShowMenu();
                    break;
            }
            return Math.Abs(index - 1);
        }*/

        static string CreateString4ReplaceAndFind(string str)
        {
            var str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                str1 += '*';
            }
            return str1;
        }

        /*static void ShowMenu()
        {
            BackgroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < WindowWidth; i++)
                Write(" ");
            CursorLeft = 0;
            PrintMenuCommand("F1", "Переключить режим");
            WriteLine();
            ResetColor();
        }

        static void PrintMenuCommand(string key, string action)
        {
            ForegroundColor = ConsoleColor.Red;
            Write(key);
            ForegroundColor = ConsoleColor.Green;
            Write(" " + action + " ");
        }*/

    }
}
