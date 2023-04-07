
namespace Step_By_Step_Dungeon
{
    public interface IMovable : ILocated
    {
        public void Move(GameObject[,] FieldOfVision);
    }
}
