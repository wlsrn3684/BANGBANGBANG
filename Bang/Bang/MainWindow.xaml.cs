using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bang
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        enum job
        {
            sheriff,
            Deputy,
            Outlaw,
            Renegade
        }

        enum card
        {
            Bang,
            Missed,
            Beer,
            Duel,
            Indian,
            Gatling,
            Saloon,
            Panic,
            Cat_Balou,
            General_Store,
            Stagecoach,
            Wells_Fargo,
            Schofield,
            Remington,
            Rev_Carabine,
            Winchester,
            Volcanic,
            Scope,
            Mustang,
            Barrel,
            Jail,
            Dynamite,
            Knife,
            Derringer,
            Pepperbox,
            Buffalo_Rifle,
            Howitzer,
            Iron_Plate,
            Bible,
            Ten_Gallon_Hat,
            Sombrero,
            Canteen,
            Can_Can,
            Conestoga,
            Pony_Express,
            Pardner,
            Bottle,
            Shot,
            Rhum,
            Union_Pacific,
            Gold_Rush,
            Wanted,
            Horseshoe,
            Gun_Belt,
            Rucksack,
            Gold_Pan,
            Lucky_Charm,
            Boots,
            Calumet,
            Pickaxe,
            Big_Fifty,
            Buntline_Special,
            Double_Barrel,
            Thunderer,
            Ace_Up_The_Sleeve,
            Bandolier,
            Beer_Keg,
            Bell_Tower,
            Bomb,
            Crate,
            Lock_Pick,
            Tumbleweed,
            Whip,

        }

        enum character
        {
            Willy_The_Kid,
            Calamity_Janet,
            Kit_Carlson,
            Bart_Cassidy,
            Sid_Ketchum,
            Lucky_Duke,
            Jourdonnais,
            Black_Jack,
            Vulture_Sam,
            Jesse_Jones,
            Suzy_Lafayette,
            Pedro_Ramirez,
            Slab_The_Killer,
            Rose_Doolan,
            Paul_Regret,
            El_Gringo
        }

        enum type
        {
            use,
            equip
        }

        public struct Card
        {
            public String name;
            public String symbol;
            public int type;

            public Card(String name, String symbol, int type)
            {
                this.name = name;
                this.symbol = symbol;
                this.type = type;
            }
        }
        
        public Card[] cardInfo = new Card[63]
        {
            new Card("Bang", "12H2D8C1S", 0),
            new Card("Missed", "", 0),

            new Card("Beer", "", 0),
            new Card("Duel", "", 0),
            new Card("Indian", "", 0),
            new Card("Gatling", "", 0),
            new Card("Saloon", "", 0),
            new Card("Panic", "", 0),
            new Card("Cat_Balou", "", 0),
            new Card("General_Store", "", 0),
            new Card("Stagecoach", "", 0),
            new Card("Wells_Fargo", "", 0),

            new Card("Schofield", "", 0),
            new Card("Remington", "", 0),
            new Card("Rev_Carabine", "", 0),
            new Card("Winchester", "", 0),
            new Card("Volcanic", "", 0),
            new Card("Scope", "", 0),
            new Card("Mustang", "", 0),
            new Card("Barrel", "", 0),
            new Card("Jail", "", 0),
            new Card("Dynamite", "", 0),

            new Card("Knife", "", 0),
            new Card("Derringer", "", 0),
            new Card("Pepperbox", "", 0),
            new Card("Buffalo_Rifle", "", 0),
            new Card("Howitzer", "", 0),
            new Card("Iron_Plate", "", 0),
            new Card("Bible", "", 0),
            new Card("Ten_Gallon_Hat", "", 0),
            new Card("Sombrero", "", 0),
            new Card("Canteen", "", 0),

            new Card("Can_Can", "", 0),
            new Card("Conestoga", "", 0),
            new Card("Pony_Express", "", 0),
            new Card("Pardner", "", 0),
            new Card("Bottle", "", 0),
            new Card("Shot", "", 0),
            new Card("Rhum", "", 0),
            new Card("Union_Pacific", "", 0),
            new Card("Gold_Rush", "", 0),
            new Card("Wanted", "", 0),

            new Card("Horseshoe", "", 0),
            new Card("Gun_Belt", "", 0),
            new Card("Rucksack", "", 0),
            new Card("Gold_Pan", "", 0),
            new Card("Lucky_Charm", "", 0),
            new Card("Boots", "", 0),
            new Card("Calumet", "", 0),
            new Card("Pickaxe", "", 0),
            new Card("Big_Fifty", "", 0),
            new Card("Buntline_Special", "", 0),

            new Card("Double_Barrel", "", 0),
            new Card("Thunderer", "", 0),
            new Card("Ace_Up_The_Sleeve", "", 0),
            new Card("Bandolier", "", 0),
            new Card("Beer_Keg", "", 0),
            new Card("Bell_Tower", "", 0),
            new Card("Bomb", "", 0),
            new Card("Crate", "", 0),
            new Card("Lock_Pick", "", 0),
            new Card("Tumbleweed", "", 0),

            new Card("Whip", "", 0),
        };

        
        //cardInfo[Bang]("Bang", "",type.use);

    }
}
