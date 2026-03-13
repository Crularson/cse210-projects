public class Checklist : Goal
{
    private int _completionNumber;
    private int _maxNumber;
    private int _bonusPoints;

    public Checklist(string name, string desc, int points, int maxNum) : base(name, desc, points)
    {
        _maxNumber = maxNum;
        _bonusPoints = points*_maxNumber;
        _completionNumber = 0;
    }
    
    public override int CompleteGoal()
    {
        _completionNumber ++;
        if(_completionNumber < _maxNumber)
        {
            
            return this.GetPoints();
        }
        else if (_completionNumber == _maxNumber)
        {
            
            _isComplete = true;
            return this.GetPoints()+_bonusPoints;
        }
        else
        {
            return 0;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public void SetCompletionNumber(int number)
    {
        _completionNumber = number;
    }
    
    public override string DisplayGoal()
    {
        if (this.IsComplete())
        {   
        return $"[X] {this.GetName()} ({_completionNumber}/{_maxNumber})";
        }
        else
        {
            return $"[ ] {this.GetName()} ({_completionNumber}/{_maxNumber})";
        }
    }
    public override string Delimited()
    {
        return $"Checklist|{this.GetName()}|{this.GetDescription()}|{this.GetPoints()}|{_completionNumber}|{_maxNumber}|{this.IsComplete()}";
    }
}