﻿//// ********************************** 
//// Densen Informatica 中讯科技 
//// 作者：Alex Chow
//// e-mail:zhouchuanglin@gmail.com 
//// **********************************

//using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
//using Microsoft.AspNetCore.Mvc;
//using System.Reflection;

//namespace Densen.Identity.Controllers;

//public class OidcConfigurationController : Controller
//{
//    private readonly ILogger<OidcConfigurationController> _logger;

//    public OidcConfigurationController(IClientRequestParametersProvider clientRequestParametersProvider, ILogger<OidcConfigurationController> logger)
//    {
//        ClientRequestParametersProvider = clientRequestParametersProvider;
//        _logger = logger;
//    }

//    public IClientRequestParametersProvider ClientRequestParametersProvider { get; }

//    [HttpGet("_configuration/{clientId}")]
//    public IActionResult GetClientRequestParameters([FromRoute] string clientId)
//    {
//        var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
//        return Ok(parameters);
//    }

//    [HttpGet("ver")]
//    public IActionResult GetVer()
//    {
//        return Ok(Assembly.GetExecutingAssembly().GetName().Version?.ToString());
//    }
//}
