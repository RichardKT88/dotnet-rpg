namespace dotnet_rpg.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public Character Character { get; set; }
        //The entity framework knows that this is the corresponding foreign key for the Character property
        public int CharacterId { get; set; }
    }
}