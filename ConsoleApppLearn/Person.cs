using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

class Profile
{ }


class Person : IEquatable<Person>, IComparable<Person>
{
    public bool Equals(Person other)
    {
        return FirstName == other.FirstName && LastName == other.LastName;
    }

    public string PassNo { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ LastName.GetHashCode();
    }

    void Demo()
    {
        var map = new Dictionary<Person, Profile>();
        var mapPassNo = new Dictionary<Person, Profile>(new PassNoEqComparer());

        var sortedMapByPassNo = new SortedDictionary<Person, Profile>(new PassNoComparer());

        try
        {

        }
        catch(Exception ex)
        {
            throw; // shows original place of Exception
            throw ex; // rewrites Stack trace property to point to this line
        }
    }

    public int CompareTo(Person? other)
    {
        throw new NotImplementedException();
    }

    class PassNoEqComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person? x, Person? y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            throw new NotImplementedException();
        }
    }

    class PassNoComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            throw new NotImplementedException();
        }
    }
}
