public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected int _targets;

    protected int _bonuses;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        return $"Name: {_shortName}, Description: {_description}, Points: {_points}";
    }

    public abstract string GetStringRepresentation();

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }


    public int GetPoints()
    {
        return _points;
    }

    public int GetTarget()
    {
        return _targets;
    }

    public int GetBonus()
    {
        return _bonuses;
    }

}

