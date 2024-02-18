using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProjetoMVC.Extension;

public class ExtensionMethods
{
    public static int ValidateId(List<int> src)
    {
        Dictionary<int, string> keyValues = new Dictionary<int, string>();

        var expectedId = 1;
        src.ForEach(x =>
        {
            if (expectedId == x)
                keyValues.TryAdd(expectedId, "V");

            keyValues.TryAdd(expectedId, "F");
            expectedId ++;
        });

        var SequencyHasFail = keyValues.FirstOrDefault(x => x.Value == "F");
        if (SequencyHasFail.Value != default)
            return SequencyHasFail.Key;

        return src.Count == 0 ? 1 : src.Last() + 1;
    }
}