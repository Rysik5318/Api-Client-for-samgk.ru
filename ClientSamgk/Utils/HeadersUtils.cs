using RestSharp;

namespace ClientSamgk.Utils;

public static class HeadersUtils
{
    public static void ConfigureAntiGreedHeaders(this RestRequest request)
    {
        request.AddOrUpdateHeaders(new[]
        {
            new KeyValuePair<string, string>("origin", "https://samgk.ru"),
            new KeyValuePair<string, string>("referer", "https://samgk.ru")
        });
    }

    //private static ICollection<KeyValuePair<string,string>> GetHeaders() // ����� ��� ��� ������ ��������� �������? (�������) P.s. � �����, ����� �������� dickPick
    //{
    //    var dickPick = new List<KeyValuePair<string, string>>()
    //    {
    //        new KeyValuePair<string, string>("origin", "https://samgk.ru"),
    //        new KeyValuePair<string, string>("referer", "https://samgk.ru"),
    //    };
    //    return dickPick;
    //}
}