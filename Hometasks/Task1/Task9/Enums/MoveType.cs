using System.ComponentModel.DataAnnotations;

namespace Task9.Enums
{
    internal enum MoveType
    {
        [Display(Name = "Step")]
        Step = 1,

        [Display(Name = "Jump")]
        Jump = 2,

        [Display(Name = "Swim")]
        Swim = 3,

        [Display(Name = "Fly")]
        Fly = 4,

        [Display(Name = "Run")]
        Run = 5,
    }
}