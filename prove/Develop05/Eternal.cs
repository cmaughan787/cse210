class Eternal : Goal
{
    private int _count;

    public Eternal(string description, int points, string title) : base(description, points, title)
    {
        // Initialize additional fields specific to Eternal goals if needed
        _count = 0; // Example initialization
    }
}