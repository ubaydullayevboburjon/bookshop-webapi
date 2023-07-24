﻿using BookShop.Domain.Entities.Users;

namespace BookShop.Service.Interfaces.Auth;

public interface ITokenService
{
    public string GenerateToken(User user);

}
