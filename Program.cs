namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grandMother = new FamilyMember() { Mother = null, Father = null, Name = "Маша", Sex = Gender.Female };
            var grandFather = new FamilyMember() { Mother = null, Father = null, Name = "Миша", Sex = Gender.Male };
            var father = new FamilyMember() { Mother = null, Father = null, Name = "Игорь", Sex = Gender.Male };
            var mother = new FamilyMember() { Mother = grandMother, Father = grandFather, Name = "Ира", Sex = Gender.Female };
            grandMother.AddChild(mother);
            grandFather.AddChild(mother);
            var son = new FamilyMember() { Mother = mother, Father = father, Name = "Антон", Sex = Gender.Male };
            var daughter = new FamilyMember() { Mother = mother, Father = father, Name = "Аня", Sex = Gender.Female };
            mother.AddChild(son);
            father.AddChild(son);
            father.AddChild(daughter);
            mother.AddChild(daughter);

			//daughter.MothersLine();

			daughter.Relation();

		}
    }
}