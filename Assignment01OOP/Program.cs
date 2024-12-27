using Assignment01OOP.UserDefindDataType;

namespace Assignment01OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1. Create an enum called "WeekDays" with the days of the week (Monday 
            // to Sunday) as its members.Then, write a C# program that prints out all 
            //the days of the week using this enum.
            //foreach (WeekDaysEnums days in Enum.GetValues(typeof(WeekDaysEnums)))
            //{
            //    Console.WriteLine(days);
            //}

            #endregion
            #region Q2

            ////Create an enum called "Season" with the four seasons(Spring, Summer,
            ////Autumn, Winter) as its members.Write a C# program that takes a season 
            ////name as input from the user and displays the corresponding month range 
            ////for that season. Note range for seasons (spring march to may , summer
            ////june to august, autumn September to November, winter December to February)
            //bool isParsed;
            //SeasonEnum SeasonsMoth;
            //do
            //{
            //    Console.WriteLine("Please Enter The Seasons");
            //    isParsed = Enum.TryParse<SeasonEnum>(Console.ReadLine() ?? "", out SeasonsMoth);
            //} while (!isParsed);
            //switch (SeasonsMoth)
            //{
            //    case SeasonEnum.Spring:
            //        Console.WriteLine("Spring Months: March to May");
            //        break;
            //    case SeasonEnum.Summer:
            //        Console.WriteLine("Spring Months: June to Augest");
            //        break;
            //    case SeasonEnum.Autumn:
            //        Console.WriteLine("Spring Months: September to November");
            //        break;
            //    case SeasonEnum.Winter:
            //        Console.WriteLine("Spring Months: December to Febraury");
            //        break;
            //    default:
            //        Console.WriteLine("Season is exist");
            //        break;
            //}

            #endregion
            #region Q3
            // . Assign the following Permissions(Read, write, Delete, Execute) in a form
            //of Enum. 
            //⮚ Create Variable from previous Enum to Add and Remove Permission
            //from variable, check if specific Permission is existed inside variable
            //PermissionEnum permission = PermissionEnum.Read;
            //Console.WriteLine(permission);
            //// add Permision 
            //permission |= PermissionEnum.Write;
            //Console.WriteLine(permission);
            //// Remover Permision use NAND BitWise Operator 
            //permission &= ~PermissionEnum.Read;
            //Console.WriteLine(permission);
            //// check Permission Tggle Permission user xor Bitwise Operator 
            //permission ^= PermissionEnum.Delete;
            //Console.WriteLine(permission);

            #endregion
            #region Q4
            ////Create an Enum called "Colors" with the basic colors(Red, Green, Blue) as its members
            ////    .Write a C# program that takes a color name as input from the user and displays
            ////    message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Please Enter Color ");
            //if (Enum.TryParse<ColorEnum>(Console.ReadLine(), true, out ColorEnum color))
            //    Console.WriteLine("Primary color ");
            //else
            //    Console.WriteLine("invalid Color");
            #endregion
        }
    }
}
