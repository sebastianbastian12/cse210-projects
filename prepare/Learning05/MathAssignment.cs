using System;

public class MathAssignment: Assignment {
    private string _textBookSection;
    private string _problems;

    public MathAssignment (string studentName, string topic, string textBookSection, string problems) : base(studentName, topic) {
        _problems = problems;
        _textBookSection = textBookSection;
    }

    public string GetHomeworkList(){
        return $"Section {_textBookSection} Problems {_problems}";
    }
}