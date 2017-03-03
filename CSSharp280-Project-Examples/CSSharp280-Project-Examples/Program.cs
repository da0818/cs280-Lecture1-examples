using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSharp280_Project_Examples
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Height = 2.0f;
            pokemon.Weight = 12.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            Console.WriteLine("身高:{0}公尺, 體重{1}磅",
                pokemon.Height, pokemon.Weight);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}