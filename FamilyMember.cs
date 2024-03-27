using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    enum Gender { Male, Female };
    internal class FamilyMember
    {
        public FamilyMember Mother { get { return mother; } set { mother = value; } }
        public FamilyMember Father { get { return father; } set { father = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Gender Sex { get { return sex; } set { sex = value; } }
        public List<FamilyMember> Children { get; }

        

        FamilyMember mother;
        FamilyMember father;
        string name;
        Gender sex;
        List<FamilyMember> children;

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

		public void Relation()
		{
			Console.WriteLine($"- Я: {this.Name}");
			if (mother != null) Console.WriteLine($"- Мама: {mother.Name}");
            if (father != null) Console.WriteLine($"- Папа: {father.Name}");
            if (Father.children != null && Mother.children != null)
            {
                if (father != null)
                {
                    foreach (var child in Father.children)
                        if (child.mother.Equals(this.mother))
                        {
                            if (!this.Equals(child)){
                                if (child.Sex == Gender.Female)
                                    Console.WriteLine($"- Сестра: {child.Name}");
                                else
                                    Console.WriteLine($"- Брат: {child.Name}"); 
                            }
                        }
                        else
                        {
							    if (child.Sex == Gender.Female)
									Console.WriteLine($"- Сводная сестра: {child.Name}");
								else
									Console.WriteLine($"- Сводный брат: {child.Name}");
						}
                }
                else
				{
					foreach (var child in Mother.Children)
						if (child.Sex == Gender.Female)
							Console.WriteLine($"- Сестра: {child.Name}");
						else
							Console.WriteLine($"- Брат: {child.Name}");
				}

			}
            if (this.Children != null)
            {
				foreach (var child in this.Children)
					if (child.Sex == Gender.Female)
						Console.WriteLine($"- Дочь: {child.Name}");
					else
						Console.WriteLine($"- Сын: {child.Name}");
					
			}

		}
		
		public void AddChild(FamilyMember child)
        {
            if (child != null)
                children.Add(child);
        }

        public FamilyMember()
        {
            children = new List<FamilyMember>();
        }

        public FamilyMember(FamilyMember Mother, FamilyMember Father, string Name, Gender Sex)
        {
            children = new List<FamilyMember>();
            this.mother = Mother;
            this.father = Father;
            this.name = Name;
            this.sex = Sex;
        }
    }
    
}
