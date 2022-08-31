using Project.FirstApp;

List<FamilyMember> family = new();

family.Add(new FamilyMember("Alexander", "Dolgosheev", 34));
family.Add(new FamilyMember("Daniil", "Dolgosheev", 22));
family.Add(new FamilyMember("Evgen", "Dolgosheev", 30));

Array.ForEach(family.ToArray(), Console.WriteLine);