
using Newtonsoft.Json;

namespace Step_By_Step_Dungeon
{
    public class ScreenLib
    {
        public StartScreen Start { get; set; }

        public ManualScreen Manual { get; set; }

        public LevelsScreen Levels { get; set; }

        public GameScreen[] Game { get; set; }

        public EndScreen End { get; set; }

        private string json;

        public void MakeBackup()
        {
            json = JsonConvert.SerializeObject(Game, Formatting.Indented);

        }
        public void LoadBackup()
        {
            Game = JsonConvert.DeserializeObject<GameScreen[]>(json);
        }

    }
}
