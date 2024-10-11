using System.Numerics;
using Microsoft.VisualBasic;

namespace _5._Date_Modifier;

public class DateModifier
{
    private string date1;

 





    public BigInteger CalculateDiffrence(string date1, string date2)
    {
        DateTime dateTime1 = DateTime.Parse(date1);
        DateTime dateTime2 = DateTime.Parse(date2);



        TimeSpan diffrence=dateTime1-dateTime2;
        BigInteger diff = diffrence.Days;

        return diff;




    }
}