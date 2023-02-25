using System.ComponentModel.DataAnnotations;

namespace Task9.Enums
{
    internal enum Environment
    {
        [Display(Name = "Forest")]
        Forest = 1,

        [Display(Name = "Field")]
        Field = 2,

        [Display(Name = "Steppe")]
        Steppe = 3,

        [Display(Name = "Desert")]
        Desert = 4,

        [Display(Name = "Sky")]
        Sky = 5,

        [Display(Name = "Lake")]
        Lake = 6,

        [Display(Name = "River")]
        River = 7,

        [Display(Name = "Sea")]
        Sea = 8,

        [Display(Name = "Ocean")]
        Ocean = 9,

        [Display(Name = "Underground")]
        Underground = 10,

        [Display(Name = "Town")]
        Town = 11,
    }
}