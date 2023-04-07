
namespace Step_By_Step_Dungeon
{
    public interface ICanBeDestroyed
    {
        public int HealthPoint { get; set; }
        bool isDestroyed { get; set; }

        public void HealthUpdate();

    }
}
