using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Linq;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void MainOPP2(string[] args)
        {
            
            //abstract class ucun orney, harda onu isledilller
            //bir clasda abstrac metod varsa hemin klasi inherent eledikde overrride elemek lazimdi hemin methodu
            //eyni adli coxlu metod yaratmaq olar constructurdan ferqli?
            //bir nece dene statit method yaratmaq olar?
            //baseClass daki static method birinci isleyer yoxsa bundan toredilen clasin conustruturu
            //abstrac class bir clasa toredile biler ancaq?
            //abstrac medod abstra clasda olur ve bu clas hara inherent edilibse olarda bu metod yazilmalidi mutleq body ile?
            // public int StudentID { get; set; } ne bu
            //emlpoye class icinde suallar var

            #region Task1

            //1.Phone adlı class olacaq.İçində Company, Model, ReleaseDay deyə üç string field olacaq.Və bu classın 3 fərqli constructoru olacaq.
            //- constructor bütün bu bu fieldlerin hamısının dəyərini “unknown” yazacaq
            //-digər bir constructor isə 2 parametr qəbul edəcək(company və model) və uyğun fieldlərə gələn dəyəri set edəcək
            //-digər constructor 3 argument qəbul edəcək(company, model, releaseday) və uyğun fieldlərə bu qəbul etdiyi dəyərlərə set edəcək


            #endregion
            #region Task2

            //2.Employee adlı base class yaradın.
            //Propertyleri-Name,FirstName,Salary olacaq.
            //Və iki metodu olacaq.Work() və Pause().
            //Daha sonra onnan törənən class olacaq Boss adlı.
            //CompanyCar adlı property Lead() metodu olacaq.
            //İkinci bir class olacaq yenə Employee-dən törənən Trainees adlı.
            //Propertyləri  WorkingHours və SchoolHours olacaq. Learn() metodu
            //1.Work() metodunu override edeceksiz Trainee classında(tərkibini dəyişərək)
            //2.Constructorları yaratmağı da unutmayin hər bir classda.

            Trainees trn = new Trainees();


            #endregion
            #region Task3

            //3.Daha sonra hər bir classında obyektini yaradın(içinə istədiyiniz valuelar göndərin özünüz yazıb).
            //Və Boss classın Lead() metodunu və Trainee classının  Work() metodnu çağırın.
            //Metodların içincə cnsole mesaj çıxardın kı hansının şlədiyini bilək.Məsələn Lead() metodu “I am leading” kimi mesaj çıxarsın

            Trainees trainers = new Trainees() { WorkingHours = "5", SchoolHours = "3"};
            Boss boss =  new Boss();
            boss.CompanyCar = "Fiat";

            boss.Name = "Qasim";
            trainers.Name = "Moon";

            boss.Lead();
            trainers.Work("baki");
            #endregion

            #region

            //4.Arraydan Duplikatları silmək.Sizə sıralanmış array veriləcək(Consolde-dan daxil edilməyəcək əlavə metod kimi yazın)
            //Və o arrayda təkrarlananları sildikdən sonra array uzunlugu nə olar onu qaytaracaqsiz.
            //Burda önəmli olan mövcüd array üzərində dəyişiklik edəcəksiz.Yəni əslində heçnə silmiyəcəksiz.
            //Önəmli olan ilk əvvəkl unikal olan rəqəmlər üzunluğu gəlsin geridə qalanlara fikir verməyin

            //Input: nums = [1, 1, 2] -
            //Output: 2 olacaq çünki[1, 2, _]
            //Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
            //Output: 5 olacaq çünki nums = [0, 1, 2, 3, 4, _, _, _, _, _]

            int[] nums = { 3, 3, 1, 3};

            int[] check = new int[nums.Length];
            int say = 0;
            int checkk =0;

            Console.WriteLine(nums[0]);

            for (int j = 1; j < nums.Length; j++)
            {
                for (int i = j; i >= 0; i--)
                {
                    if (nums[j] != nums[i])
                    {
                        checkk ++;
                    }
                }

                if (checkk == j)
                {
                    Console.WriteLine(nums[j]);
                    say++;
                    
                }
                checkk = 0;
            }

           Console.WriteLine(say + 1 );

            #endregion
        }

        static void MainClass(string[] args)
        {
            #region Task1
            //Task 1
            //Real heyatdan numune goture bileceyiniz her hansisa bir obyektin classini yaradin.
            //Fieldler ve funksiyalar verin.Daha sonra Classin instansini alib ferqli
            //obyektler yaradin ve fieldlerin deyerleri ferqli olsun.
            Student sdtId0 = new Student(0);
            Student sdtId1 = new Student(1);

           // sdtId0 = new Student(2);//bu ne??

            sdtId1.studentName = "Namiq";
            sdtId1.studentSurname = "Sekiyev";
            sdtId1.studentAge = "19";
            sdtId1.studentGender = 'M';
            sdtId1.firstExam = 45;
            sdtId1.secondExam = 76;

            sdtId0.studentName = "Samir";
            sdtId0.studentSurname = "Qanixov";
            sdtId0.studentAge = "16";
            sdtId0.studentGender = 'W';
            sdtId0.firstExam = 56;
            sdtId0.secondExam = 67;


            ////Id aliram
            //int? id = null;
            //while (true)
            //{
            //    Console.WriteLine("Please Enter Id");
            //    bool check = int.TryParse(Console.ReadLine(), out int givenId);
            //    if (check == true && (givenId == 1 || givenId == 0))
            //    {
            //        id = givenId;
            //        break;
            //    }
            //    else { Console.WriteLine("Invalid Access, Try Again\n"); }
            //}


            //Console.WriteLine("Sellect Operation 1 - Show Information 2 - Clear ");


            ////secdiyi emaliyat ve id gore proses
            //while (true)
            //{
            //    try
            //    {
            //        int sellect = int.Parse(Console.ReadLine());
            //        if (sellect == 1)
            //        {
            //            if (id == 1)
            //            {
            //                sdtId1.information();
            //                break;
            //            }
            //            else if (id == 0)
            //            {
            //                sdtId0.information();
            //                break;
            //            }
            //        }
            //        else if (sellect == 2)
            //        {
            //            if (id == 1)
            //            {
            //                sdtId1.Clear();
            //                sdtId1.information();
            //                break;
            //            }
            //            else if (id == 0)
            //            {
            //                sdtId0.Clear();
            //                sdtId0.information();
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Access, Try Again\n");
            //        }
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Invalid Access, Try Again\n");
            //    }
            //}

            #endregion

            #region Task2

            //2.Metod yazin parametr olaraq String verilecek.
            //Onu ters cevirin geriye hemen stringi qaytarin.
            //Mes:almaz-zamla


            reverse(Console.ReadLine());

            #endregion

            #region Task3

            //3.Bir metod yazin.Duzbucaglinin sahesini hesablayan
            //(Elave metod olacag.Program classin icinde o metodu
            //cagirib ishledecem)Duzbucaglinin sahesini hesablayan.

            //int firstValue = 0, secondValue = 0;
            //Console.Clear();
            //Console.WriteLine("Task 3");
            //Console.WriteLine("Please Enter Value With Whait-Space");


            //string[] value = Console.ReadLine().Split(' ');

            //while (true)
            //{
            //    if (value.Length > 2)
            //    {
            //        Console.WriteLine("Invalid Access, Try Again");
            //    }
            //    else { break; }
            //}

            //for (int i = 0; i < value.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        firstValue = Convert.ToInt32(value[i]);
            //        continue;
            //    }

            //    if (i == 1)
            //    {
            //        secondValue = Convert.ToInt32(value[i]);
            //        break;
            //    }
            //}



            //try
            //{
            //    Console.WriteLine(Area(firstValue, secondValue));
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Invalid Access, Try Again");
            //}


            #endregion



        }
        static void MainLesson5Array(string[] args)
        {
            //arayyda longlengt nedi
            //task1 sual var icinde
            //bu klasda method statik olmalidi amma studentde buna gereek yoxdu niye?
            //task 2de sualim var icinde
            //sual demeli bir applicationda 1 esas proqram adinda class olur ve elave diger basqa classalrdan da ibaret olur demeli?
            //fild ve propeti ferqi
            //static methodda class olanda hemin clasinin neyini qaytarir? gorduyu isi?
            //params tezeden basa salin
            //construct ile static ile deyer vermeyin ferqi
            #region Task1
            //Task1.2method olacag.Bunu Main metodunda da yaza bilərsiniz.

            //GetOdd() verilen arraydakı bütün cüt rəqəmləri gətirəcək
            //GetEven() verilən arraydakə tək rəqəmləri gətirəcək.(burda input array 2D olacaq)


            int[] intArray = { 1, 2, 3, 4, 5, 9, 14, 13, 45, 32 };
            int[,] intArray2 = new int[2, 5]
            {
                {1,2,3,4,5 },
                {9,14,13,45,32}
            };

            Console.WriteLine("Task 1\n");

            Console.WriteLine("Odd Numbers:");
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    Console.WriteLine(intArray[i]);
                }
            }

            Console.WriteLine("\nEven Numbers:");
            foreach (var item in intArray2)
            {
                if (!(item % 2 == 0))
                {
                    Console.WriteLine(item);
                }
            }

            //for (int i = 0; i < intArray2.Length; i++)
            //{
            //    for (int j = 0; j < intArray2.GetLength(i); j++)
            //    {
            //        if (!(j % 2 == 0))
            //        {
            //            Console.WriteLine(intArray2[i,j]);
            //        }
            //    }
            //}

            #endregion

            #region Task3

            //Task3.İnt array veriləcək(istifadəçi yazacag)
            //İçindəki elementlərin cəmin tapın-hazır funksiya(məs sum) istifadə etmək olmaz

            Console.WriteLine("\nTask 3\n");

            Console.WriteLine("Write Numbers With White-Space");

        task2head:
            string[] enterdStringArray = Console.ReadLine().Split(' ');
            int sumArray = 0;

            foreach (var item in enterdStringArray)
            {
                bool result = int.TryParse(item, out int value);
                if (result == true)
                {
                    sumArray += value;
                }
                else
                {
                    Console.WriteLine("Invalid Access, Try Again");
                    goto task2head;
                }
            }

            Console.WriteLine($"Sum Of Your Array Is Equal {sumArray}");


            #endregion

            #region Task4

            //Task4..İnt array veriləcək(istifadəçi yazacag)
            //İçindəki max elementri tapın-həm hazır funksiya ilə həm də onsuz yazın
            //Console.WriteLine("\nTask 1");
            Console.WriteLine("\nTask 4\n");
            Console.WriteLine("Write Numbers With White-Space");


            string[] enterdStringArray2 = Console.ReadLine().Split(' ');


            int[] ints = Array.ConvertAll(enterdStringArray2, int.Parse);

            Console.WriteLine(ints.Max());

            int check = ints[0];

            for (int i = 0; i < ints.Length; i++)
            {

                if (check < ints[i])
                {
                    check = ints[i];
                }
            }



            Console.WriteLine(check);


            #endregion

            #region Task 5

            //Task5.Arraydan ibarət array veriləcək.İçidəki maks uzunluqlu arrayı tapın
            Console.WriteLine("\nTask 5\n");
            int[][] jaggedArray = new int[][]
            {
                new int [] { 1, 2},
                new int [] { 3, 4, 5, 8 },
                new int[] {5,6,8}
            };

            int checkLong0 = 0;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {

                    if (checkLong0 <= j)
                    {
                        checkLong0 = j;
                    }
                }

                //duzu budu:

                //if (jaggedArray.Length < jaggedArray[i].Length)
                //{
                //    checkLong0 = jaggedArray[i].Length;
                //}

            }

            Console.WriteLine(checkLong0 + 1);

             #endregion

            //Console.WriteLine("Enter Something");
            //string valueT2 = Console.ReadLine().ToLower();

            //string choseifbool=null;

            //if (valueT2 == "false" || valueT2 == "true")
            //{
            //    choseifbool = "ok";
            //}

            //bool checkt2=int.TryParse(Console.ReadLine(), out int task2);

            //Console.WriteLine("Press 1 for String\nPress 2 for integer\nPress 3 for Boolean");
            //string Chose= Console.ReadLine();



            //if (checkt2 == true && Chose == "2" )
            //{
            //    Console.WriteLine("Number is integer");
            //}
            //else if (checkt2 == true && choseifbool=="ok")
            //{
            //    Console.WriteLine("Invalid Access");
            //}
        }
        static void MainLesson4String(string[] args)
        {
            #region Task 1
            //Task1.Console - dan ad və ya hər hansısa bir string daxil edilməlidi.
            //Daxil edilən string üzərində aşağıdakı əməliyyatlar yerinə yetirilib ekrana çıxarılsın
            //1.Daxil edilən string UpperCase edilib 1ci sətrdə console çıxarılsın
            //2.Daxil edilən string LowerCase edilib 2 - ci sətrdə console çıxarılsın
            //3.Daxil edilən stringdə boşluqlar varsa silinib 3 - cü sətrdə console çıxarılsın
            //4.Daxil edilən string Substring edilib 4 - cu sətrdə console çıxarılsın(istənilən index qeyd edə bilərsiniz)


            Console.WriteLine("Task 1 \n");

            Console.WriteLine("Please, Enter Your Text");

            string enteredText = Console.ReadLine();
            string upperCase = enteredText.ToUpper();
            string lowerCase = enteredText.ToLower();
            string trim = enteredText.Trim();


            Console.WriteLine("UpperCase: {0}", upperCase);
            Console.WriteLine("LowerCase: {0}", lowerCase);
            Console.WriteLine($"Trim: {trim}");

            string substring;

            if (enteredText.Length < 3)
            {
                substring = enteredText.Substring(0,0);
            }
            else
            {
                substring = enteredText.Substring(0, 2);
            }

            Console.WriteLine($"Substring: {substring}");

            #endregion

            #region Task 2

            //Task2.İstifadəçi string input daxil edəcək.(məsələn alma) Daha sonra axtarmalı olduğu xarakteri daxil edecek.
            //(məsələn a) Geriyə o xarakterin o sözdəki ilk indexini göndərəcəksiz(yuxaridakı nümunədə 0)

            Console.WriteLine("\n Task 2 \n");

            Console.WriteLine("Please Enter Your Text");
            string enteredText2 = Console.ReadLine();


            Console.WriteLine("Please Enter Your Letter");
            char letter;


            while (true)
            {
                
                bool checkChar = char.TryParse(Console.ReadLine(), out letter);

                if (checkChar == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Access, Please Try Again");

                }
            }

            //-1 karakter yoxdursa
            int indexOfletter = enteredText2.IndexOf(letter);

            Console.WriteLine("Index Of Latter is {0}", indexOfletter);


            #endregion

            #region Task 3

            //Task3.Daxil edilən stringdə(bu cümlə ola bilər) söz sayını geriyə döndərin. 

            Console.WriteLine("\nTask 3 \n");

            Console.WriteLine("Please, Enter Your Text");
            string enteredTextTask3 = Console.ReadLine();

            string[] wordsInEnteredText = enteredTextTask3.Split(' ');

            Console.WriteLine($"Count Of Words Are {wordsInEnteredText.Length}");
            


            #endregion

            #region Task 4

            //Task4.İstifadəçi ad daxil etsin.Sonra soyad daxil etməyini istəyin soyad daxil etsin.Geriyə onun ad soyadını döndərin.

            Console.WriteLine("\nTask 4 \n");

            Console.WriteLine("Please, Enter Your Name");
            string userName = Console.ReadLine();

            Console.WriteLine("Please, Enter Your Surname");
            string userSurname = Console.ReadLine();

            //string nameAndSurname = string.Concat(userName, userSurname,userName);
            //Console.WriteLine("Your Name and Surname is {0} ", nameAndSurname);
            
            Console.WriteLine($"Name: {userName} \nSurname: {userSurname}");

            #endregion

            #region Task 5

            //Task5.Hər hansısa string daxil etməyini istəyin. Daha sonra eyni stringi yeniden daxil etməyini istəyin.
            //Geriyə daxil edilən 2 stringi muqayisə edib bərabər olub olmadığı haqda info döndərin.
            //Böyük və ya kiçik hərflər nəzərə alınmamalıdır

            Console.WriteLine("\nTask 5 \n");

            Console.WriteLine("Please, Enter Your Text");
            string enteredTextElcin = Console.ReadLine();

            Console.WriteLine("Please, Enter Your Text Again");
            string enteredTextElcin2 = Console.ReadLine();

            int resultCompare = String.Compare(enteredTextElcin, enteredTextElcin2, true);

            if (resultCompare==0)
            {
                Console.WriteLine("Your First Text Is Equal To The Second Text");
            }
            else
            {
                Console.WriteLine("Your First Text Is Not Equal To The Second Text");
            }


            #endregion
        }
        static void MainLesson3(string[] args)
        {
            #region Task1

            /*
            Task1.İstifadəçi rəqəm daxil edəcək.Əgər 3-ə bölünürsə “3-ə bölünən” Əgər 3-ə bölünmür
            7-yə bölünürsə “7-ə bölünən”
            Digər hallarda -cüt olarsa “cüt rəqəm’ -deyilsə “tək rəqəm” sözünü ekrana çıxarın
            */
            int EnteretNumber;
            int MaxInt = int.MaxValue;
            int MinInt = int.MinValue;

           // Console.WriteLine("Task 1 \n");

            //Number Checking - is integer?
            while (true)
            {
                Console.WriteLine($"Please, Enter A Number to {MinInt} from {MaxInt}");

                string NumberInString = Console.ReadLine().Trim();

                decimal NumberInDecimal;

                if (string.IsNullOrEmpty(NumberInString))
                {
                    NumberInDecimal = 0;
                }
                else 
                { 
                    decimal.TryParse(NumberInString, out NumberInDecimal);
                }

                bool NumberCheck = int.TryParse(NumberInString, out EnteretNumber);

                // EnteretNumber result;
                if ((NumberCheck == true) && (NumberInDecimal <= MaxInt || NumberInDecimal >= MinInt))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Access, Try Again\n");
                }
            }

            //condition checking
            if (EnteretNumber % 3 == 0 || EnteretNumber % 7 == 0)
            {
                if (EnteretNumber % 3 == 0)
                {
                    Console.WriteLine($"{EnteretNumber} can be divide to 3");
                }
                else
                {
                    Console.WriteLine($"{EnteretNumber} can be divide to 7");
                }
            }
            else if (EnteretNumber % 2 == 0)
            {
                Console.WriteLine($"{EnteretNumber} is even number");
            }
            else
            {
                Console.WriteLine($"{EnteretNumber} is odd number");
            }


            #endregion
            #region Task2

            ////3dən başlayıb -3ə qədər olan rəqəmləri bir bir ekrana çıxarın
            //Console.WriteLine("\nTask 2");
            //for (int i = 3; i >= -3; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

        }
        static void MainLesson2(string[] args)
        {
            #region Task1
            //tapsiriq 1 metod olacaq 2 int deyeri alib cemini qaytar
            int FirstNumber, SecondNumer;
            int MaxiumValue = int.MaxValue;
            int MiniumValue = int.MinValue;

            Console.WriteLine("Task 1\n");

            //1ci reqem
            while (true)
            {
                Console.WriteLine("Please, Enter First Number from " + MaxiumValue + " to " + MiniumValue);
                bool CheckFirstNumber = int.TryParse(Console.ReadLine(), out FirstNumber);
                if (CheckFirstNumber == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Access, Please Try Again");
                    Task.Delay(500).Wait();
                }
            }

        //2ci reqem
        SecondNumberEntry:

            Console.WriteLine("Please, Enter Second Number from " + MaxiumValue + " to " + MiniumValue);

            bool CheckSecondNumber = int.TryParse(Console.ReadLine(), out SecondNumer);

            if (CheckSecondNumber == false)
            {
                Console.WriteLine("Invalid Access, Please Try Again");
                Task.Delay(500).Wait();
                goto SecondNumberEntry;
            }

            //Hesablama
            Console.WriteLine("Result = " + (FirstNumber + SecondNumer) + "\n");

            #endregion

            #region Task2

            // readline ad soy ad alib netice versin.
            Console.WriteLine("Task 2\n");

            string Name, Surname;

        //Name
        NameLink:
            Console.WriteLine("Please, Write Name:");
            Name = Console.ReadLine().ToUpper().Trim(' ', '.', ',');

            bool CheckedName = decimal.TryParse(Name, out decimal a);

            if (CheckedName == true || Name == "")
            {
                Console.WriteLine("Please, Try Again");
                Task.Delay(500).Wait();
                goto NameLink;
            }

            //Surname


            while (true)
            {
                Console.WriteLine("\nPlease, Write Surname:");
                Surname = Console.ReadLine().ToUpper().Trim(' ', '.', ',');
                bool CheckedSurname = decimal.TryParse(Surname, out decimal b);

                if (CheckedSurname == true || Surname == "")
                {
                    Console.WriteLine("Please, Try Again");
                    Task.Delay(500).Wait();
                }
                else
                {
                    break;
                }
            }

            //result

            Console.WriteLine($"\nName: {Name} \nSurname:  {Surname}" );



            #endregion
        }

        static void reverse(string text)
        {
            char[] textToChar = text.ToCharArray();

            for (int i = textToChar.Length; i > 0; i--)
            {
                Console.Write(textToChar[i-1].ToString());
                //Console.ReadLine();
            }
            
           // Console.WriteLine("\nSecond Way {0}",text.Reverse().ToString()); // bunun xetasi nedi?

        }

        static int Area(int a ,int b)
        {
            return a * b;
        }
    }
}
