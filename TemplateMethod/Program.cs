using TemplateMethod;

Console.WriteLine("Mens scoring algorithm:");
ScoringAlgorithm mensAlgorithm = new MensScoringAlgorithm();
Console.WriteLine(mensAlgorithm.CalculateScore(10, TimeSpan.FromMinutes(5)));

Console.WriteLine("Women scoring algorithm:");
ScoringAlgorithm womenAlgorithm = new WomenScoringAlgorithm();
Console.WriteLine(womenAlgorithm.CalculateScore(10, TimeSpan.FromMinutes(5)));

Console.WriteLine("Children scoring algorithm:");
ScoringAlgorithm childrenAlgorithm = new ChildrenScoringAlgorithm();
Console.WriteLine(childrenAlgorithm.CalculateScore(10, TimeSpan.FromMinutes(5)));
