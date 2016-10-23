# VK_Searcher
Project contain some method's that give you ability to search user's likes in  social network "Vkontakte"
1.	http://vksearcher.azurewebsites.net/api/friend/1
         Метод получает список друзей пользователя 
          ……./api/friend/1
1- Айдишник пользователя список друзей которого нужно получить
   2. http://vksearcher.azurewebsites.net/api/photo/likes/?friendsId=81959312&targetUserId=78158948
targetUserId – айдишник пользователя среди фотографий  которого нужно искать лайки
friendsId – айдишник человека лайки которого нужно искать среди фотографий у пользователя targetUserId
3. http://vksearcher.azurewebsites.net/api/wall/likes/?friendsId=78158948&targetUserId=81959312
friendsId – айдишник пользователя на странице которого нужно искать лайки
targetUserId – айдишник человека лайки которого нужно искать на странице у пользователя friendsId


