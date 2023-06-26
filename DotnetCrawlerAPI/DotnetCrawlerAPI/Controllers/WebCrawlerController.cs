﻿using DotnetCrawlerAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCrawlerAPI.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class WebCrawlerController : ControllerBase
    {
        private readonly IWebCrawlerService _webCrawlerService;

        public WebCrawlerController(IWebCrawlerService webCrawlerService)
        {
            _webCrawlerService = webCrawlerService;
        }

        [HttpGet("webcrawl")]
        public async IEnumerable<string> SearchItens(string searchOrigin, string query)
        {
            return Ok(await _webCrawlerService.SearchProducts(searchOrigin,query));
        }
    }
}
