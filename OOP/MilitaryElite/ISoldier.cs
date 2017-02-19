namespace _08.MilitaryElite
{
    interface ISoldier
    {
        string Id { get; }
        string FirstName { get; }
        string LastName { get; }
        string Type { get; set; }
    }
}
