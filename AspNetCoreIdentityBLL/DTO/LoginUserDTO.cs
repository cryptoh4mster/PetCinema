﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreIdentityBLL.DTO
{
    public class LoginUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
