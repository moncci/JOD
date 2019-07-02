using JOD.Writer.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Utils
{
    public static class IgnoreHelper
    {
        public static string TextAlignEnumToString(TextAlignEnum? value)
        {
            return value.HasValue ? value.Value.EnumConvertToString() : null;
        }

        public static TextAlignEnum? StringToTextAlignEnum(string value)
        {
            TextAlignEnum? result;
            if (value == null)
            {
                result = null;
            }
            else
            {
                TextAlignEnum ienum;
                bool bool_enum = value.StringConvertToEnum<TextAlignEnum>(out ienum);
                if (bool_enum)
                {
                    result = ienum;
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }


        public static string TextLineThroughStyleEnumToString(TextLineThroughStyle? value)
        {
            return value.HasValue ? value.Value.EnumConvertToString() : null;
        }

        public static TextLineThroughStyle? StringToTextLineThroughStyleEnum(string value)
        {
            TextLineThroughStyle? result;
            if (value == null)
            {
                result = null;
            }
            else
            {
                TextLineThroughStyle ienum;
                bool bool_enum = value.StringConvertToEnum<TextLineThroughStyle>(out ienum);
                if (bool_enum)
                {
                    result = ienum;
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public static string TextLineThroughTypeEnumToString(TextLineThroughType? value)
        {
            return value.HasValue ? value.Value.EnumConvertToString() : null;
        }

        public static TextLineThroughType? StringToTextLineThroughTypeEnum(string value)
        {
            TextLineThroughType? result;
            if (value == null)
            {
                result = null;
            }
            else
            {
                TextLineThroughType ienum;
                bool bool_enum = value.StringConvertToEnum<TextLineThroughType>(out ienum);
                if (bool_enum)
                {
                    result = ienum;
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public static string FontSizeEnumToString(FontSizeEnum? value)
        {
            if (!value.HasValue)
            {
                return null;
            }
            else
            {
                FontSizeEnum font = value.Value;
                double size = 14;
                switch (font)
                {
                    case FontSizeEnum.初号:
                        size = 42;
                        break;
                    case FontSizeEnum.小初:
                        size = 36;
                        break;
                    case FontSizeEnum.一号:
                        size = 26;
                        break;
                    case FontSizeEnum.小一:
                        size = 24;
                        break;
                    case FontSizeEnum.二号:
                        size = 22;
                        break;
                    case FontSizeEnum.小二:
                        size = 18;
                        break;
                    case FontSizeEnum.三号:
                        size = 16;
                        break;
                    case FontSizeEnum.小三:
                        size = 15;
                        break;
                    case FontSizeEnum.四号:
                        size = 14;
                        break;
                    case FontSizeEnum.小四:
                        size = 12;
                        break;
                    case FontSizeEnum.五号:
                        size = 10.5;
                        break;
                    case FontSizeEnum.小五:
                        size = 9;
                        break;
                    case FontSizeEnum.六号:
                        size = 7.5;
                        break;
                    case FontSizeEnum.小六:
                        size = 6.5;
                        break;
                    case FontSizeEnum.七号:
                        size = 5.5;
                        break;
                    case FontSizeEnum.八号:
                        size = 5;
                        break;
                    case FontSizeEnum.p6:
                        size = 6;
                        break;
                    case FontSizeEnum.p7:
                        size = 7;
                        break;
                    case FontSizeEnum.p8:
                        size = 8;
                        break;
                    case FontSizeEnum.p9:
                        size = 9;
                        break;
                    case FontSizeEnum.p10:
                        size = 10;
                        break;
                    case FontSizeEnum.p10d5:
                        size = 10.5;
                        break;
                    case FontSizeEnum.p11:
                        size = 11;
                        break;
                    case FontSizeEnum.p12:
                        size = 12;
                        break;
                    case FontSizeEnum.p13:
                        size = 13;
                        break;
                    case FontSizeEnum.p14:
                        size = 14;
                        break;
                    case FontSizeEnum.p15:
                        size = 15;
                        break;
                    case FontSizeEnum.p16:
                        size = 16;
                        break;
                    case FontSizeEnum.p18:
                        size = 18;
                        break;
                    case FontSizeEnum.p20:
                        size = 20;
                        break;
                    case FontSizeEnum.p22:
                        size = 22;
                        break;
                    case FontSizeEnum.p24:
                        size = 24;
                        break;
                    case FontSizeEnum.p26:
                        size = 26;
                        break;
                    case FontSizeEnum.p28:
                        size = 28;
                        break;
                    case FontSizeEnum.p32:
                        size = 32;
                        break;
                    case FontSizeEnum.p36:
                        size = 36;
                        break;
                    case FontSizeEnum.p40:
                        size = 42;
                        break;
                    case FontSizeEnum.p44:
                        size = 44;
                        break;
                    case FontSizeEnum.p48:
                        size = 48;
                        break;
                    case FontSizeEnum.p54:
                        size = 54;
                        break;
                    case FontSizeEnum.p60:
                        size = 60;
                        break;
                    case FontSizeEnum.p66:
                        size = 66;
                        break;
                    case FontSizeEnum.p72:
                        size = 72;
                        break;
                    case FontSizeEnum.p80:
                        size = 80;
                        break;
                    case FontSizeEnum.p88:
                        size = 88;
                        break;
                    case FontSizeEnum.p96:
                        size = 96;
                        break;
                    default:
                        break;
                }
                return size + "pt";
            }
        }

        public static FontSizeEnum? StringToFontSizeEnum(string value)
        {
            FontSizeEnum? result;
            if (value == null)
            {
                result = null;
            }
            else
            {
                string low = value.Trim().ToLower();
                low = low.Replace("pt", "");
                switch (low)
                {
                    case "42":
                        result = FontSizeEnum.初号;
                        break;
                    case "36":
                        result = FontSizeEnum.小初;
                        break;
                    case "26":
                        result = FontSizeEnum.一号;
                        break;
                    case "24":
                        result = FontSizeEnum.小一;
                        break;
                    case "22":
                        result = FontSizeEnum.二号;
                        break;
                    case "18":
                        result = FontSizeEnum.小二;
                        break;
                    case "16":
                        result = FontSizeEnum.三号;
                        break;
                    case "15":
                        result = FontSizeEnum.小三;
                        break;
                    case "14":
                        result = FontSizeEnum.四号;
                        break;
                    case "12":
                        result = FontSizeEnum.小四;
                        break;
                    case "10.5":
                        result = FontSizeEnum.五号;
                        break;
                    case "9":
                        result = FontSizeEnum.小五;
                        break;
                    case "7.5":
                        result = FontSizeEnum.六号;
                        break;
                    case "6.5":
                        result = FontSizeEnum.小六;
                        break;
                    case "5.5":
                        result = FontSizeEnum.七号;
                        break;
                    case "5":
                        result = FontSizeEnum.八号;
                        break;
                    case "6":
                        result = FontSizeEnum.p6;
                        break;
                    case "7":
                        result = FontSizeEnum.p7;
                        break;
                    case "8":
                        result = FontSizeEnum.p8;
                        break;
                    //case "9":
                    //    result = FontSizeEnum.p9;
                    //    break;
                    case "10":
                        result = FontSizeEnum.p10;
                        break;
                    //case "10.5":
                    //    result = FontSizeEnum.p10d5;
                    //    break;
                    case "11":
                        result = FontSizeEnum.p11;
                        break;
                    //case "12":
                    //    result = FontSizeEnum.p12;
                    //    break;
                    case "13":
                        result = FontSizeEnum.p13;
                        break;
                    //case "14":
                    //    result = FontSizeEnum.p14;
                    //    break;
                    //case "15":
                    //    result = FontSizeEnum.p15;
                    //    break;
                    //case "16":
                    //    result = FontSizeEnum.p16;
                    //    break;
                    //case "18":
                    //    result = FontSizeEnum.p18;
                    //    break;
                    case "20":
                        result = FontSizeEnum.p20;
                        break;
                    //case "22":
                    //    result = FontSizeEnum.p22;
                    //    break;
                    //case "24":
                    //    result = FontSizeEnum.p24;
                    //    break;
                    //case "26":
                    //    result = FontSizeEnum.p26;
                    //    break;
                    case "28":
                        result = FontSizeEnum.p28;
                        break;
                    case "32":
                        result = FontSizeEnum.p32;
                        break;
                    //case "36":
                    //    result = FontSizeEnum.p36;
                    //    break;
                    //case "42":
                    //    result = FontSizeEnum.p42;
                    //    break;
                    case "44":
                        result = FontSizeEnum.p44;
                        break;
                    case "48":
                        result = FontSizeEnum.p48;
                        break;
                    case "54":
                        result = FontSizeEnum.p54;
                        break;
                    case "60":
                        result = FontSizeEnum.p60;
                        break;
                    case "66":
                        result = FontSizeEnum.p66;
                        break;
                    case "72":
                        result = FontSizeEnum.p72;
                        break;
                    case "80":
                        result = FontSizeEnum.p80;
                        break;
                    case "88":
                        result = FontSizeEnum.p88;
                        break;
                    case "96":
                        result = FontSizeEnum.p96;
                        break;
                    default:
                        result = FontSizeEnum.四号;
                        break;
                }
            }
            return result;
        }

        public static string FtStyleEnumToString(FtStyleEnum? value)
        {
            return value.HasValue ? value.Value.EnumConvertToString() : null;
        }

        public static FtStyleEnum? StringToFtStyleEnum(string value)
        {
            FtStyleEnum? result;
            if (value == null)
            {
                result = null;
            }
            else
            {
                FtStyleEnum ienum;
                bool bool_enum = value.StringConvertToEnum<FtStyleEnum>(out ienum);
                if (bool_enum)
                {
                    result = ienum;
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public static string TextUnderlineStyleEnumToString(TextUnderlineStyle? value)
        {
            return value.HasValue ? value.Value.EnumConvertToString() : null;
        }

        public static TextUnderlineStyle? StringToTextUnderlineStyleEnum(string value)
        {
            TextUnderlineStyle? result;
            if (value == null)
            {
                result = null;
            }
            else
            {
                TextUnderlineStyle ienum;
                bool bool_enum = value.StringConvertToEnum<TextUnderlineStyle>(out ienum);
                if (bool_enum)
                {
                    result = ienum;
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public static string FontWeightEnumToString(FontWeightEnum? value)
        {
            return value.HasValue ? value.Value.EnumConvertToString() : null;
        }

        public static FontWeightEnum? StringToFontWeightEnum(string value)
        {
            FontWeightEnum? result;
            if (value == null)
            {
                result = null;
            }
            else
            {
                FontWeightEnum ienum;
                bool bool_enum = value.StringConvertToEnum<FontWeightEnum>(out ienum);
                if (bool_enum)
                {
                    result = ienum;
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }


        public static string BoolToString(bool? value)
        {
            return value.HasValue ? value.Value.ToString() : null;
        }

        public static bool? StringToBool(string value)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                string low = value.Trim().ToLower();
                if (low == "false")
                {
                    return false;
                }
                else if (low == "true")
                {
                    return true;
                }
                else
                {
                    return null;
                }
            }
        }

        public static string CMToString(double? value)
        {
            return value.HasValue ? value.Value.ToString("0.00") + "cm" : null;
        }

        public static double? StringToCM(string value)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                string low = value.Trim().ToLower();
                low = low.Replace("cm", "");
                double result;
                if (double.TryParse(low, out result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
