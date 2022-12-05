using System;

namespace Polymorphism
{
    internal class Program
    {
        //private static string _FriendName;

        static void Main(string[] args)
        {
            //eyni class icinde bir methodu 2ci defe ovverride elemek olmaz?
            //overloada aid consturcturdan basqa orney gosterin, pls
            //interface, delegate kececeyik?
            //inhertens eleyende compiler birinci base clasa sora o biri klasa girir de constructurda zadda?
            //BaseClase bc = new SecondClass(); bu miras almaq kimi bir seydi yoxsa hec dexli yoxdu?
            //overriding operator nedi? ornney pls
            //eyni adli ve eyni signitureli method yarada bilmek ucun override veya
            //new keyword iseldirik, new veya override yazmadiqda default olaraq new qebul edir.
            //is 2 ferqli klasi yoxlayanda ne donderi? bes as? bide bular ancaq inherents edilmislerde olmalidi?
            //boyuyu kiciye as elesek nolar? xeta?
            //as cevire bilse geri ne donderi ki? kasin icindeki seyleri?
            //methodlari as elemey olarmi
            //daire area da sual
            //string remove method neis gorurdu

            #region ah
            Shape sp = new Shape();

            //Methodlari cagiram Area
            Console.WriteLine(sp.Area(2));
            Console.WriteLine(sp.Area(4, "a")); //bunun helli
            Console.WriteLine(sp.Area(4, 3.2));


            MethodOverloading mol = new MethodOverloading();
            //int array yaziram
            string a = mol.PrintArray(1, 2, 3, 4);
            Console.WriteLine(a);
            //Console.WriteLine( mol.PrintArray(2, 3, 4) ); //systemint32 xetasi


            //char array yaziram
            mol.PrintArray('s', 'a', 'l', 'a', 'm');

            //string array yaziram
            mol.PrintArray("baki");
            #endregion

            #region sd
            string Name, Surname, id;
            int ClaseNumber;

            Console.WriteLine("Eneter Name");
            Name = Console.ReadLine();

            Console.WriteLine("Eneter SurName");
            Surname = Console.ReadLine();

            Console.WriteLine("Eneter Clase number");
            ClaseNumber = int.Parse(Console.ReadLine());

            id = Name.Substring(0, 1) + Surname.Substring(0, 1) + ClaseNumber;


            Student std = new Student(id);

            std.Surname = Surname;
            std.Name = Name;
            std.ClassNumber = ClaseNumber;

            Console.WriteLine(std.Name);
            Console.WriteLine(std.Surname);
            Console.WriteLine(std.ClassNumber);
            Console.WriteLine(std.Id);

            #endregion

            #region ds
            string _FriendName = null;
            Console.WriteLine("Enter Name");
            _FriendName = Console.ReadLine();
            istenilenAdda ia = new istenilenAdda(_FriendName);
            ia.GreetFriend();
            #endregion

            #region gf
            Console.WriteLine("Enter First Text:");
            string fg = Console.ReadLine();

            Console.WriteLine("Enter Second Text:");
            string gf = Console.ReadLine();

            StringCount(fg,gf);

            #endregion
        }

        private static void StringCount(string first, string second)
        {
            char[] charsFirst = first.ToCharArray();
            char[] charsSecond = second.ToCharArray();
            //abbc
            //sgbg
            int count = 0;

            for (int i = 0; i < charsSecond.Length; i++)
            {
                for (int j = 0; j <charsFirst.Length ; j++)
                {
                    if (charsSecond[i] == charsFirst[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
