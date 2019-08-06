using System;

namespace GitHub4Everyone
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Config

            Console.Title = "GitHub for Everyone!";

            try
            {
                /* May Crash on certain screen sizes */
                Console.SetWindowSize(80, 40);
            }
            catch (Exception)
            {
                /* Do Nothing */
            }

            #endregion

            #region Print ASCII Art
            Console.WriteLine(".------------------------------------------------------------------------------.");
            Console.WriteLine("|                             .mmMMMMMMMMMMMMMmm.                              |");
            Console.WriteLine("|                         .mMMMMMMMMMMMMMMMMMMMMMMMm.                          |");
            Console.WriteLine("|                      .mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm.                       |");
            Console.WriteLine("|                    .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.                     |");
            Console.WriteLine("|                  .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.                   |");
            Console.WriteLine("|                 MMMMMMMM'  `\"MMMMM\"\"\"\"\"\"\"MMMM\"\"`  'MMMMMMMM                  |");
            Console.WriteLine("|                MMMMMMMMM                           MMMMMMMMM                 |");
            Console.WriteLine("|               MMMMMMMMMM:                         :MMMMMMMMMM                |");
            Console.WriteLine("|              .MMMMMMMMMM                           MMMMMMMMMM.               |");
            Console.WriteLine("|              MMMMMMMMM\"                             \"MMMMMMMMM               |");
            Console.WriteLine("|              MMMMMMMMM                               MMMMMMMMM               |");
            Console.WriteLine("|              MMMMMMMMM                               MMMMMMMMM               |");
            Console.WriteLine("|              MMMMMMMMMM                             MMMMMMMMMM               |");
            Console.WriteLine("|              `MMMMMMMMMM                           MMMMMMMMMM`               |");
            Console.WriteLine("|               MMMMMMMMMMMM.                     .MMMMMMMMMMMM                |");
            Console.WriteLine("|                MMMMMM  MMMMMMMMMM         MMMMMMMMMMMMMMMMMM                 |");
            Console.WriteLine("|                 MMMMMM  'MMMMMMM           MMMMMMMMMMMMMMMM                  |");
            Console.WriteLine("|                  `MMMMMM  \"MMMMM           MMMMMMMMMMMMMM`                   |");
            Console.WriteLine("|                    `MMMMMm                 MMMMMMMMMMMM`                     |");
            Console.WriteLine("|                      `\"MMMMMMMMM           MMMMMMMMM\"`                       | ");
            Console.WriteLine("|                         `\"MMMMMM           MMMMMM\"`                          | ");
            Console.WriteLine("|                             `\"\"M           M\"\"`                              | ");
            Console.WriteLine("|                                                                              |");
            Console.WriteLine("|                         ____ _ _   _   _       _                             |");
            Console.WriteLine("|                        / ___(_) |_| | | |_   _| |__                          |");
            Console.WriteLine(@"|                       | |  _| | __| |_| | | | | '_ \                         |");
            Console.WriteLine("|                       | |_| | | |_|  _  | |_| | |_) |                        |");
            Console.WriteLine(@"|                        \____|_|\__|_| |_|\__,_|_.__/                         |");
            Console.WriteLine("|                                                                              |");
            Console.WriteLine("|           _____            _____                                             |");
            Console.WriteLine("|          |  ___|__  _ __  | ____|_   _____ _ __ _   _  ___  _ __   ___       |");
            Console.WriteLine(@"|          | |_ / _ \| '__| |  _| \ \ / / _ \ '__| | | |/ _ \| '_ \ / _ \      |");
            Console.WriteLine(@"|          |  _| (_) | |    | |___ \ V /  __/ |  | |_| | (_) | | | |  __/      |");
            Console.WriteLine(@"|          |_|  \___/|_|    |_____| \_/ \___|_|   \__, |\___/|_| |_|\___|      |");
            Console.WriteLine("|                                                 |___/                        |"); Console.WriteLine("|                                                                              |");
            Console.WriteLine("'------------------------------------------------------------------------------'");
            #endregion
        }
    }
}