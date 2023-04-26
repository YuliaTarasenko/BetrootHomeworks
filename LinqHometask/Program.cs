using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LinqHometask
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json"));

            //find out who is located farthest north/south/west/east using latitude/longitude data
            var northmost = persons.OrderBy(p => p.Latitude).Last(); 
            var southmost = persons.OrderBy(p => p.Latitude).First();
            var westmost = persons.OrderBy(p => p.Longitude).First();
            var eastmost = persons.OrderBy(p => p.Longitude).Last();

            //find max and min distance between 2 persons            
            persons.Distances(out var min, out var max);

            //find 2 persons whos ‘about’ have the most same words
            persons.MaxAbout(out var maxAbout);

            //find persons with same friends(compare by friend’s name)
            var sameFriends = persons.Select(p => new UserFriendsRecord(p.Index, string.Join("", p.Friends
                .Select(f => f.Name).OrderBy(n => n))))
                .GroupBy(pf => pf.FriendStr).Where(g => g.Count() > 1).ToList();
        }

        public record UserDistaceRecord(int FirstIndex, int SecondIndex, double Distance);
        public record UserAboutRecord(Person first, Person second, int WordsCount);
        public record UserFriendsRecord(int Index, string FriendStr);

        public static double Distance(double lat1, double lon1,double lat2, double lon2)
        {
            double r = 6371;
            double dLat = ToRadians(lat2-lat1);
            double dLon = ToRadians(lon2- lon1);
            double a = Math.Sin(dLat/2)*Math.Sin(dLat/2)+
                Math.Cos(ToRadians(lat1))*Math.Cos(ToRadians(lat2))*
                Math.Sin(dLon/2)*Math.Sin(dLon/2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = r * c;
            return distance;
        }

        private static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static void Distances(this IEnumerable<Person> persons, out UserDistaceRecord min, out UserDistaceRecord max)
        {
            min = new UserDistaceRecord(0, 0, 50000);
            max = new UserDistaceRecord(0, 0, 0);
            var personsList = persons.ToArray();
            for (int i = 0; i < personsList.Length - 1; i++)
                for (int j = i + 1; j < personsList.Length; j++)
                {
                    var rec = new UserDistaceRecord(personsList[i].Index, personsList[j].Index,
                        Distance(personsList[i].Latitude, personsList[i].Longitude,
                        personsList[j].Latitude, personsList[j].Longitude));
                    if (rec.Distance < min.Distance) min = rec;
                    else if (rec.Distance > max.Distance) max = rec;
                }
        }

        public static void MaxAbout(this IEnumerable<Person> persons, out UserAboutRecord max)
        {
            max = new UserAboutRecord(null, null, 0);
            var personsList = persons.ToArray();
            for (int i = 0; i<personsList.Length-1;i++)
                for(int j = i + 1;j < personsList.Length; j++)
                {
                    var first = personsList[i];
                    var second = personsList[j];
                    var firstWords = SplitAbout(first);
                    var secondWords = SplitAbout(second);
                    var common = firstWords.Intersect(secondWords).Count();
                    if(common > max.WordsCount)
                        max = new UserAboutRecord(first, second, common);
                }
        }
        private static string[] SplitAbout(Person person)
        {
            return person.About.ToLower().Replace("\r\n", "").Split('.', ',', ' ');
        }        
    }
}