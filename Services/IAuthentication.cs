﻿using System.Threading.Tasks;
using chub.Dtos;
using chub.Models;

namespace chub.Services
{
    public interface IAuthentication
    {
        User AskForCredentials();
        bool PersistCredentials(User user);
        public UserDto ReadUserCredentials();
        Task<UserDto> GetUser(string token);

    }
}
