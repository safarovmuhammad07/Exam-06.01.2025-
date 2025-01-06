# Экзаменационные задачи по LINQ (Социальная сеть)

## Исходные данные

### Класс User (Пользователь)
```csharp
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string City { get; set; }
    public int FollowersCount { get; set; }
    public DateTime RegisterDate { get; set; }
    public bool IsActive { get; set; }
}
```

### Класс Post (Пост)
```csharp
public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public int LikesCount { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsPublic { get; set; }
}
```

### Класс Comment (Комментарий)
```csharp
public class Comment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
}
```

### Класс Like (Лайк)
```csharp
public class Like
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
    public DateTime CreatedDate { get; set; }
}
```

## Задания | Супоришҳо | Tasks

### Task 1
Получить всех пользователей из города "Москва".
Ҳамаи истифодабарандагонро аз шаҳри "Москва" гиред.
Get all users from the city "Moscow".

*Описание:*
- Используйте метод Where для фильтрации пользователей по городу.
- Барои филтр кардани истифодабарандагон аз рӯи шаҳр методи Where-ро истифода баред.
- Use the Where method to filter users by city.

### Task 2
Найти все публичные посты.
Ҳамаи постҳои оммавиро ёбед.
Find all public posts.

*Описание:*
- Примените Where для фильтрации постов по свойству IsPublic.
- Барои филтр кардани постҳо аз рӯи хосияти IsPublic методи Where-ро истифода баред.
- Apply Where to filter posts by IsPublic property.

### Task 3
Получить количество комментариев к посту с Id = 1.
Шумораи шарҳҳоро барои пости Id = 1 ҳисоб кунед.
Get the number of comments for the post with Id = 1.

*Описание:*
- Используйте метод Count с условием для подсчета комментариев определенного поста.
- Барои ҳисоб кардани шарҳҳои пости муайян методи Count-ро бо шарт истифода баред.
- Use the Count method with a condition to count comments for a specific post.

### Task 4
Получить список имен всех активных пользователей.
Рӯйхати номҳои ҳамаи истифодабарандагони фаъолро гиред.
Get a list of names of all active users.

*Описание:*
- Используйте Where для фильтрации активных пользователей и Select для выбора только имен.
- Барои филтр кардани истифодабарандагони фаъол Where ва барои интихоби танҳо номҳо Select-ро истифода баред.
- Use Where to filter active users and Select to choose only names.

### Task 5
Найти первого пользователя из Москвы с более чем 200 подписчиками.
Аввалин истифодабарандаи аз Москваро, ки зиёда аз 200 обуначӣ дорад, ёбед.
Find the first user from Moscow with more than 200 followers.

*Описание:*
- Примените FirstOrDefault с комбинированным условием для города и количества подписчиков.
- Барои шаҳр ва миқдори обуначиён методи FirstOrDefault-ро бо шартҳои якҷояшуда истифода баред.
- Apply FirstOrDefault with a combined condition for city and follower count.

### Task 6
Подсчитать количество постов каждого пользователя.
Шумораи постҳои ҳар як истифодабарандаро ҳисоб кунед.
Count the number of posts for each user.

*Описание:*
- Используйте Select для создания анонимного типа с именем пользователя и количеством его постов (Count).
- Барои сохтани навъи беном бо номи истифодабаранда ва шумораи постҳои он Select-ро истифода баред (Count).
- Use Select to create an anonymous type with username and post count (Count).

### Task 7
Получить последние 3 поста пользователя с Id = 2.
3 пости охирини истифодабарандаи Id = 2-ро гиред.
Get the last 3 posts of the user with Id = 2.

*Описание:*
- Примените Where для фильтрации постов пользователя, OrderByDescending для сортировки по дате и Take для ограничения количества.
- Барои филтр кардани постҳои истифодабаранда Where, барои мураттабсозӣ аз рӯи сана OrderByDescending ва барои маҳдуд кардани миқдор Take-ро истифода баред.
- Apply Where to filter user's posts, OrderByDescending to sort by date, and Take to limit the quantity.

### Task 8
Получить список всех постов с именами их авторов, у которых больше 100 лайков.
Рӯйхати ҳамаи постҳоро бо номи муаллифонашон, ки зиёда аз 100 лайк доранд, гиред.
Get a list of all posts with their authors' names that have more than 100 likes.

*Описание:*
- Используйте Where для фильтрации постов по лайкам и Join для соединения с таблицей пользователей.
- Барои филтр кардани постҳо аз рӯи лайкҳо Where ва барои пайваст кардан бо ҷадвали истифодабарандагон Join-ро истифода баред.
- Use Where to filter posts by likes and Join to combine with users table.

### Task 9
Получить список постов с именами их авторов и количеством комментариев, отсортированный по количеству комментариев.
Рӯйхати постҳоро бо номи муаллифон ва шумораи шарҳҳо гиред, ки аз рӯи шумораи шарҳҳо ба тартиб дароварда шудаанд.
Get a list of posts with their authors' names and number of comments, sorted by comment count.

*Описание:*
- Примените Join для соединения постов с пользователями, подсчитайте комментарии для каждого поста и отсортируйте результат.
- Барои пайваст кардани постҳо бо истифодабарандагон Join-ро истифода баред, шарҳҳоро барои ҳар як пост ҳисоб кунед ва натиҷаро ба тартиб дароред.
- Apply Join to combine posts with users, count comments for each post and sort the result.

### | Task 10
Сгруппировать пользователей по городам и вывести количество пользователей в каждом городе.
Истифодабарандагонро аз рӯи шаҳрҳо гурӯҳбандӣ карда, шумораи истифодабарандагонро дар ҳар як шаҳр нишон диҳед.
Group users by cities and display the number of users in each city.

*Описание:*
- Используйте GroupBy для группировки по городу и Select для создания анонимного типа с названием города и количеством пользователей.
- Барои гурӯҳбандӣ аз рӯи шаҳр GroupBy ва барои сохтани навъи беном бо номи шаҳр ва шумораи истифодабарандагон Select-ро истифода баред.
- Use GroupBy to group by city and Select to create an anonymous type with city name and user count.
