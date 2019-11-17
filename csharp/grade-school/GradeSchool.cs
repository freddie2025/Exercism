using System;
using System.Linq;
using System.Collections.Generic;

public class GradeSchool
{
  	private SortedList<string, int> _roster;
	
	public GradeSchool()
	{
		_roster = new SortedList<string, int>();
	}
	
    public void Add(string student, int grade)
    {
        _roster.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        return _roster.OrderBy(x => x.Value).Select(x => x.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _roster.Where(x => x.Value == grade).Select(x => x.Key);
    }
}