namespace WEBAPI.models
{
    public class Goblin
    {
        public string Name {get; set;} = "Gbao'gla";
        public int Greed {get; set;} = 5;
        public int Id {get; set;} = 0;
        public GoblinJob Job {get; set;} = GoblinJob.Begger;
    }
}