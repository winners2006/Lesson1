using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    enum Gender { Male, Female };
    internal class FamilyMember : IComparable<FamilyMember>
    {
        public FamilyMember Mother { get { return mother; } set { mother = value; } }
        public FamilyMember Father { get { return father; } set { father = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Gender Sex { get { return sex; } set { sex = value; } }
        public ListT<FamilyMember> Children { get; }

        

        FamilyMember mother;
        FamilyMember father;
        string name;
        Gender sex;
        ListT<FamilyMember> children;

        public void MothersLine()
        {
            if (sex == Gender.Female)
                Console.WriteLine(name);
            MothersLinePrivate();
        }
        private void MothersLinePrivate()
        {
            if (mother != null) {
                Console.WriteLine(mother.name);
                mother.MothersLinePrivate();
            }
        }

        public void AddChild(FamilyMember child)
        {
            if (child != null)
                children.Add(child);
        }

        public int CompareTo(FamilyMember? other)
        {
            throw new NotImplementedException();
        }

        public FamilyMember()
        {
            children = new ListT<FamilyMember>();
        }

        public FamilyMember(FamilyMember Mother, FamilyMember Father, string Name, Gender Sex)
        {
            children = new ListT<FamilyMember>();
            this.mother = Mother;
            this.father = Father;
            this.name = Name;
            this.sex = Sex;
        }
    }
    
}
