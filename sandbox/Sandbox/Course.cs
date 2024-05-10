class Course
{
    public string _classCode;
    public string _className;
    public int _credits;
    public string _color;

    //method
    public void Display() {
        Console.WriteLine($"{_classCode} {_className} {_credits} {_color}");
    }

}