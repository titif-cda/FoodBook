using BLL.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion=}/account")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]

    public class AccountController: ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;

        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            LoginResponse loginResponse = await _accountService.Login(loginRequest.Username, loginRequest.Password);
            if (loginResponse != null)
            {
                return Ok(loginResponse);
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            RegisterResponse registerResponse = await _accountService.Register(registerRequest);
            if (registerResponse != null)
            {
                return Ok(registerResponse);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
