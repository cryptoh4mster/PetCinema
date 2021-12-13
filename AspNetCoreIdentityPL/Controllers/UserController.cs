using AspNetCoreIdentityBLL.DTO;
using AspNetCoreIdentityBLL.Infrastructure;
using AspNetCoreIdentityBLL.Interfaces;
using AspNetCoreIdentityDAL.Entities;
using AspNetCoreIdentityPL.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AspNetCoreIdentityPL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService) 
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost("Registration")]
        public async Task<ActionResult> Register(CreateUserViewModel createUserViewModel)
        {
            CreateUserDTO createUserDTO = _mapper.Map<CreateUserDTO>(createUserViewModel);
            // добавляем пользователя
            OperationDetails operationDetails = await _userService.AddUser(createUserDTO);
            return Ok(operationDetails);
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginUserViewModel loginUserViewModel)
        {
            LoginUserDTO loginUserDTO = _mapper.Map<LoginUserDTO>(loginUserViewModel);
            // добавляем пользователя
            OperationDetails operationDetails = await _userService.Login(loginUserDTO);
            return Ok(operationDetails);
        }

        [HttpPost("Logout")]
        public async Task<ActionResult> Logout()
        {
            // добавляем пользователя
            OperationDetails operationDetails = await _userService.Logout();
            return Ok(operationDetails);
        }
    }
}
