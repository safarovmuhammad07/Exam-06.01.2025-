
using System.Xml;

var users = new List<User>
{
    new User { Id = 1, Username = "alex_cool", City = "Москва", FollowersCount = 150, RegisterDate = new DateTime(2023, 1, 15), IsActive = true },
    new User { Id = 2, Username = "maria_smith", City = "Санкт-Петербург", FollowersCount = 320, RegisterDate = new DateTime(2023, 2, 20), IsActive = true },
    new User { Id = 3, Username = "john_doe", City = "Москва", FollowersCount = 90, RegisterDate = new DateTime(2023, 3, 10), IsActive = false },
    new User { Id = 4, Username = "kate_wilson", City = "Казань", FollowersCount = 280, RegisterDate = new DateTime(2023, 4, 5), IsActive = true },
    new User { Id = 5, Username = "mike_brown", City = "Москва", FollowersCount = 420, RegisterDate = new DateTime(2023, 5, 1), IsActive = true }
};

var posts = new List<Post>
{
    new Post { Id = 1, UserId = 1, Content = "Привет всем!", LikesCount = 25, CreatedDate = new DateTime(2023, 6, 1), IsPublic = true },
    new Post { Id = 2, UserId = 2, Content = "Отличный день!", LikesCount = 45, CreatedDate = new DateTime(2023, 6, 2), IsPublic = true },
    new Post { Id = 3, UserId = 1, Content = "Личный пост", LikesCount = 10, CreatedDate = new DateTime(2023, 6, 3), IsPublic = false },
    new Post { Id = 4, UserId = 3, Content = "Новости дня", LikesCount = 15, CreatedDate = new DateTime(2023, 6, 4), IsPublic = true },
    new Post { Id = 5, UserId = 4, Content = "Мое хобби", LikesCount = 35, CreatedDate = new DateTime(2023, 6, 5), IsPublic = true }
};

var comments = new List<Comment>
{
    new Comment { Id = 1, PostId = 1, UserId = 2, Content = "Супер!", CreatedDate = new DateTime(2023, 6, 1), LikesCount = 5 },
    new Comment { Id = 2, PostId = 1, UserId = 3, Content = "Класс!", CreatedDate = new DateTime(2023, 6, 1), LikesCount = 3 },
    new Comment { Id = 3, PostId = 2, UserId = 1, Content = "Согласен!", CreatedDate = new DateTime(2023, 6, 2), LikesCount = 7 },
    new Comment { Id = 4, PostId = 4, UserId = 5, Content = "Интересно", CreatedDate = new DateTime(2023, 6, 4), LikesCount = 4 },
    new Comment { Id = 5, PostId = 5, UserId = 2, Content = "Круто!", CreatedDate = new DateTime(2023, 6, 5), LikesCount = 6 }
};

var likes = new List<Like>
{
    new Like { Id = 1, UserId = 1, PostId = 2, CreatedDate = new DateTime(2023, 6, 2) },
    new Like { Id = 2, UserId = 2, PostId = 1, CreatedDate = new DateTime(2023, 6, 1) },
    new Like { Id = 3, UserId = 3, PostId = 1, CreatedDate = new DateTime(2023, 6, 1) },
    new Like { Id = 4, UserId = 4, PostId = 2, CreatedDate = new DateTime(2023, 6, 2) },
    new Like { Id = 5, UserId = 5, PostId = 4, CreatedDate = new DateTime(2023, 6, 4) }
};









//Task_1
//Получить всех пользователей из города "Москва". Ҳамаи истифодабарандагонро аз шаҳри "Москва" гиред. Get all users from the city "Moscow".
//Описание:
//Используйте метод Where для фильтрации пользователей по городу.
//Барои филтр кардани истифодабарандагон аз рӯи шаҳр методи Where-ро истифода баред.
//Use the Where method to filter users by city.

// var query1 = users.Where(w=>w.City=="Москва").ToList();

// foreach (var i in query1)
// {
//     Console.WriteLine(i.Id + " "+ i.Username + " " + i.City + " " + i.FollowersCount + " " + i.RegisterDate + " " + i.IsActive);
// }


// Task2
//Найти все публичные посты. Ҳамаи постҳои оммавиро ёбед. Find all public posts.
//Описание:
//Примените Where для фильтрации постов по свойству IsPublic.
//Барои филтр кардани постҳо аз рӯи хосияти IsPublic методи Where-ро истифода баред.
//Apply Where to filter posts by IsPublic property.

// var query2 = posts.Where(p=>p.IsPublic==true).ToList();

// foreach (var i in query2)
// {
//     Console.WriteLine(i.Id + " "+ i.UserId + " " + i.Content+ " " + i.LikesCount+ " " + i.CreatedDate + " " + i.IsPublic);
//}


//Task3
//Получить количество комментариев к посту с Id = 1. Шумораи шарҳҳоро барои пости Id = 1 ҳисоб кунед. Get the number of comments for the post with Id = 1.
//Описание:
//Используйте метод Count с условием для подсчета комментариев определенного поста.
//Барои ҳисоб кардани шарҳҳои пости муайян методи Count-ро бо шарт истифода баред.
//Use the Count method with a condition to count comments for a specific post.
// int postId=int.Parse(System.Console.ReadLine());
// var query3=posts.Count()


//Task4
//Получить список имен всех активных пользователей. Рӯйхати номҳои ҳамаи истифодабарандагони фаъолро гиред. Get a list of names of all active users.
//Описание:
//Используйте Where для фильтрации активных пользователей и Select для выбора только имен.
  //  Барои филтр кардани истифодабарандагони фаъол Where ва барои интихоби танҳо номҳо Select-ро истифода баред.
  // Use Where to filter active users and Select to choose only names.


// var query4 = users.Where(p=>p.IsActive==true).ToList();

// foreach (var i in query4)
// {
//     Console.WriteLine(i.Id + " "+ i.Username + " " + i.City + " " + i.FollowersCount + " " + i.RegisterDate + " " + i.IsActive);
// }



//Task5
//Найти первого пользователя из Москвы с более чем 200 подписчиками. Аввалин истифодабарандаи аз Москваро, ки зиёда аз 200 обуначӣ дорад, ёбед. Find the first user from Moscow with more than 200 followers.
//  Описание:
  //Примените FirstOrDefault с комбинированным условием для города и количества подписчиков.
      //Барои шаҳр ва миқдори обуначиён методи FirstOrDefault-ро бо шартҳои якҷояшуда истифода баред.
     // Apply FirstOrDefault with a combined condition for city and follower count.

//   var query5 = users.First(u=>u is { City: "Москва", FollowersCount: > 200 });
//      System.Console.WriteLine(query5.Username +" "+ query5.City + " "+ query5.FollowersCount);


//Task6
//Подсчитать количество постов каждого пользователя. Шумораи постҳои ҳар як истифодабарандаро ҳисоб кунед. Count the number of posts for each user.
//Описание:
//Используйте Select для создания анонимного типа с именем пользователя и количеством его постов (Count).
//Барои сохтани навъи беном бо номи истифодабаранда ва шумораи постҳои он Select-ро истифода баред (Count).
//Use Select to create an anonymous type with username and post count (Count).

// var query6=posts.GroupBy(p=>p.UserId).Select(a=>new
// {
//     Count=a.Count()
// });
// foreach (var i in query6)
// {
//     System.Console.WriteLine( i.Count);     
// }



//Task 7
//Получить последние 3 поста пользователя с Id = 2. 3 пости охирини истифодабарандаи Id = 2-ро гиред. Get the last 3 posts of the user with Id = 2.
//Описание:

     //Примените Where для фильтрации постов пользователя, OrderByDescending для сортировки по дате и Take для ограничения количества.
       //  Барои филтр кардани постҳои истифодабаранда Where, барои мураттабсозӣ аз рӯи сана OrderByDescending ва барои маҳдуд кардани миқдор Take-ро истифода баред.
         //Apply Where to filter user's posts, OrderByDescending to sort by date, and Take to limit the quantity.

//  int userid=int.Parse(System.Console.ReadLine());
//  var query7= posts.Where(p=>p.UserId==userid).OrderByDescending(p=>p.CreatedDate).Take(1);
//  foreach (var i in query7)
//  {
//      System.Console.WriteLine(i.Id+ " " + i.UserId+" "+ i.Content+" "+ i.LikesCount+ " "+ i.CreatedDate);
            
//  }


//Task 8
//Получить список всех постов с именами их авторов, у которых больше 100 лайков.
//Рӯйхати ҳамаи постҳоро бо номи муаллифонашон, ки зиёда аз 100 лайк доранд, гиред.
//Get a list of all posts with their authors' names that have more than 100 likes.
//Описание:
//Используйте Where для фильтрации постов по лайкам и Join для соединения с таблицей пользователей.
//Барои филтр кардани постҳо аз рӯи лайкҳо Where ва барои пайваст кардан бо ҷадвали истифодабарандагон Join-ро истифода баред.
//Use Where to filter posts by likes and Join to combine with users table.

// var query8=posts.Where(p=>p.LikesCount>100).Join(users, u=>u.UserId, p=>p.Id,(u,p) => new { User=u, Post=p });

//Task9 
//Получить список постов с именами их авторов и количеством комментариев, отсортированный по количеству комментариев.
//Рӯйхати постҳоро бо номи муаллифон ва шумораи шарҳҳо гиред, ки аз рӯи шумораи шарҳҳо ба тартиб дароварда шудаанд.
//Get a list of posts with their authors' names and number of comments, sorted by comment count.

//Описание:

//Примените Join для соединения постов с пользователями, подсчитайте комментарии для каждого поста и отсортируйте результат.
//Барои пайваст кардани постҳо бо истифодабарандагон Join-ро истифода баред, шарҳҳоро барои ҳар як пост ҳисоб кунед ва натиҷаро ба тартиб дароред.
//Apply Join to combine posts with users, count comments for each post and sort the result.
//
var query9=posts.Join(users,u=>u.UserId,p=>p.Id,(u,p) => new { User=u,P=p});

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string City { get; set; }
    public int FollowersCount { get; set; }
    public DateTime RegisterDate { get; set; }
    public bool IsActive { get; set; }
}



public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public int LikesCount { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsPublic { get; set; }
}



public class Comment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
    public int LikesCount { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
}


public class Like
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
    public DateTime CreatedDate { get; set; }
}