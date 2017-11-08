using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMicroService.Models;


namespace UserMicroService.DataAccess
{
    public static class UserDB
    {
        public static List<User> usersInMemory = new List<User>();

        //vracanje svih korisnika
        public static List<User> GetAllUsers(){ //dodavanje filtera
            return usersInMemory;
        }

        public static User GetUserById(int id){
            foreach (User user in usersInMemory){
                if (user.Id == id){
                    return user;
                }
                //linq - zamjena za foreach, provjeriti
            }
            return null;
        }


        public static User CreateUser(User user){
            usersInMemory.Add(user);
            return GetUserById(user.Id);
        }


    }
}
