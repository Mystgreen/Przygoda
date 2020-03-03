using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygoda_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu główne
            Menu.MenuFields();

            //Start gry
            //Utworzyć krótkie info o statystykach postacić - ile ma HP/Ataku/Armora

            #region Rasy - ich statystyki i właściwości.
            #region Druid

            Rase Paladin = new Rase();
            Paladin.basicHealth = 100;
            Paladin.basicDamage = 30;
            Paladin.basicArmor = 5;
            Paladin.prefix = "Elder ";
            #endregion
            #region Knight

            Rase Knight = new Rase();
            Knight.basicHealth = 150;
            Knight.basicDamage = 20;
            Knight.basicArmor = 10;
            Knight.prefix = "Elite ";
            #endregion

            #endregion

        }
    }



}
