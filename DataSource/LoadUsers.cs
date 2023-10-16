using Faker;
using WebApiDayOne.Models;

namespace WebApiDayOne.DataSource
{
    public class LoadUsers
    {


        public static UserProfile genUsers()
        {
            var user = new UserProfile();
            user.Name = Name.FullName(NameFormats.WithPrefix);
            user.Followers = RandomNumber.Next(0, 10000);
            user.Area = $"{Address.Country()}, {Address.City()}";
            user.Bio = string.Join(" ", Lorem.Sentences(3));
            return user;
        }

    }
}
