using AspNetCoreIdentityBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreIdentityBLL.DTO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using AspNetCoreIdentityDAL.Entities;
using AspNetCoreIdentityDAL.EF;
using AspNetCoreIdentityBLL.Infrastructure;
using System.Linq;


namespace AspNetCoreIdentityBLL.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IdentityContext _context;
        public UserService(UserManager<User> userManager, IMapper mapper, IdentityContext context, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _context = context;
            _signInManager = signInManager;
        }
        public async Task<OperationDetails> AddUser(CreateUserDTO createUserDTO)
        {
            User user = await _userManager.FindByEmailAsync(createUserDTO.Email);

            if (user == null)
            {
                user = _mapper.Map<User>(createUserDTO);
                var result = await _userManager.CreateAsync(user, createUserDTO.Password);
                if (result.Errors.Count() > 0)
                    return new OperationDetails(false, result.Errors.First().Description, "");
                await _context.SaveChangesAsync();
                await _signInManager.SignInAsync(user, false);
                return new OperationDetails(true, "Регистрация успешно пройдена", "");
            }

            else
            {
                return new OperationDetails(false, "Пользователь с таким Email уже существует", "Email");
            }
        }

        public async Task<OperationDetails> Login(LoginUserDTO loginUserDTO)
        {
            var result = await _signInManager.PasswordSignInAsync(loginUserDTO.Email, loginUserDTO.Password, loginUserDTO.RememberMe, false);
            if (result.Succeeded)
                return new OperationDetails(true, "Вы успешно залогинились", "");
            else
                return new OperationDetails(false, "Неправильный логин и(или) пароль", "");
        }

        public async Task<OperationDetails> Logout()
        {
            await _signInManager.SignOutAsync();
            return new OperationDetails(true, "Вы успешно разлогинились", "");
        }
    }
}
