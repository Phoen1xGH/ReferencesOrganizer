using ReferencesOrganizer.ReferencesObjects;
using ReferencesOrganizer.ReferencesParsers;

var filesFolder = Directory
    .GetParent(Directory.GetCurrentDirectory())!
    .Parent!.Parent;

var booksFile = Path.Combine(filesFolder + @"\bookReferences.txt");
var gostFile = Path.Combine(filesFolder + @"\gostStandarts.txt");
var ruFile = Path.Combine(filesFolder + @"\ruReferences.txt");
var engFile = Path.Combine(filesFolder + @"\engReferences.txt");

List<string> booksLines = File.ReadAllLines(booksFile).ToList();
List<string> gostsLines = File.ReadAllLines(gostFile).ToList();
List<string> ruReferencesLines = File.ReadAllLines(ruFile).ToList();
List<string> engReferencesLines = File.ReadAllLines(engFile).ToList();

var books = booksLines
    .Where(x => !string.IsNullOrEmpty(x))
    .Select(BookReferenceParser.Parse)
    .OrderBy(x => x.Name)
    .ToList();

var gosts = gostsLines
    .Where(x => !string.IsNullOrEmpty(x))
    .Select(GostParser.Parse)
    .OrderBy(x => x.Title)
    .ToList();

var ruReferences = ruReferencesLines
    .Where(x => !string.IsNullOrEmpty(x))
    .Select(InternetSourceParser<RuReferenceObject>.Parse)
    .OrderBy(x => x.Name)
    .ToList();

var engReferences = engReferencesLines
    .Where(x => !string.IsNullOrEmpty(x))
    .Select(InternetSourceParser<EngReferenceObject>.Parse)
    .OrderBy(x => x.Name)
    .ToList();


List<IReferenceObject> references = new();
references.AddRange(gosts);
references.AddRange(books);
references.AddRange(ruReferences);
references.AddRange(engReferences);

Console.WriteLine(string.Join("\n", references));

var resultFilePath = Path.Combine(filesFolder!.FullName, "resultReferences.txt");

File.WriteAllLines(resultFilePath, references.Select(x => x.ToString()).ToArray()!);

var referencesWithPages = references.Select(x => (x.Name, x.PageNumber)).Where(x => x.PageNumber is not null);

var referenceWithPagesPath = Path.Combine(filesFolder!.FullName, "refsWithPages.txt");

File.WriteAllLines(referenceWithPagesPath, referencesWithPages.Select(x => $"{x.Name} - {x.PageNumber}"));