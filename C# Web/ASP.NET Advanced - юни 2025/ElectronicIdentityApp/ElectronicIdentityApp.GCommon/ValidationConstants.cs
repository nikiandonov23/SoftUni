
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
    }
}
