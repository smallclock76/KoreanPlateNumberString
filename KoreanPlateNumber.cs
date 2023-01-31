using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PlateNumberString
{
    class KoreanPlateNumber
    {
        public static bool IsKoreanPlateNumber(string platenumber)
        {
            string pattern = @"^(((서울)|(경기)|(부산)|(대구)|(인천)|(광주)|(대전)|(울산)|(강원)|(충북)|(충남)|(전북)|(전남)|(경북)|(경남)|(제주))"
                             + "[1-9]{1,2}[가나다라마거너더러머버서어저고노도로모보소오조구누두루무부수우주아바사자하허호배]{1}[1-9]{4})"
                             + "|^([0-9]{2,3}[가나다라마거너더러머버서어저고노도로모보소오조구누두루무부수우주아바사자하허호배]{1}[0-9]{4})";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(platenumber);
        }
    }
}
