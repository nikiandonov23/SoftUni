
namespace ElectronicIdentityApp.GCommon
{
    public static class ValidationConstants
    {
        //Address validation constants
        public const int CityMinLength = 2;
        public const int CityMaxLength = 100;

        public const int StreetMinLength = 2;
        public const int StreetMaxLength = 150;

        public const int HouseNumberMinLength = 1;
        public const int HouseNumberMaxLength = 10;

        public const int HouseNameMinLength = 2;
        public const int HouseNameMaxLength = 200;

        public const int PostalCodeLength = 4;

        public const int BuildingTypeMinLength = 2;
        public const int BuildingTypeMaxLength = 50;

        //Document validation constants
        public const int DocumentFirstNameMinLength = 2;
        public const int DocumentFirstNameMaxLength = 50;

        public const int DocumentMiddleNameMinLength = 2; 
        public const int DocumentMiddleNameMaxLength = 50;

        public const int DocumentLastNameMinLength = 2;
        public const int DocumentLastNameMaxLength = 50;

        public const int DocumentNumberMinLength = 7; // 1-2 букви + 6 цифри
        public const int DocumentNumberMaxLength = 9; // 2 букви + 7 цифри

        public const string DocumentNumberRegex = @"^[A-Z]{1,2}\d{6,7}$";

        public const int ImageUrlMaxLength = 2083; // Максимална дължина на URL според стандарт
    }
}
