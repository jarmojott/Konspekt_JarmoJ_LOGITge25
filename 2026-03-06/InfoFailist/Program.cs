using System.Runtime.InteropServices;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        string fileName = "savegame.txt";
        Tuple<int, List<string>, int, bool, string> mängija = new Tuple<int, List<string>, int, bool, string>(0, new List<string> { "" }, 0, false, "");
        if (!File.Exists(fileName))
        {
            List<string> info = new List<string>();
            info.Add("_integer");
            info.Add("_list");
            info.Add("_anotherInteger");
            info.Add("_boolean");
            info.Add("_message");

            File.WriteAllLines(fileName, info);
        }
        else
        {
            int lives = 0;
            List<string> backpack = new List<string>();
            int money = 0;
            bool haige = false;
            string message = "no msg";
            string[] loadedFile = File.ReadAllLines(fileName);
            //for (int i = 0; i < loadedFile.Length; i++)
            //{
            //    string[] seeRida = loadedFile[i].Split('_');
            //    if (seeRida.Length <= 1)
            //    {
            //        loadedFile[i] = string.Join("_", new string[] { seeRida[0], "_0"});

            //    }
            //}
            foreach (string rida in loadedFile)
            {
                string[] seeRida = rida.Split('_');
                switch (seeRida[0])
                {
                    case "_integer":
                        lives = int.Parse(seeRida[1]);
                        break;
                    case "_list":
                        backpack = seeRida[1].Split(',').ToList();
                        break;
                    case "_anotherInteger":
                        lives = int.Parse(seeRida[1]);
                        break;
                    case "_bool":
                        haige = bool.Parse(seeRida[1]);
                        break;
                    case "_message":
                        message = seeRida[1];
                        break;
                }
            }

            Console.WriteLine(); //pooleli

        }


    }
}

