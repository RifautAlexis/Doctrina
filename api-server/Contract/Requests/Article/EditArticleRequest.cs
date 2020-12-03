﻿using api_server.Contract.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Requests
{
    public class EditArticleRequest
    {
        [FromBody]
        public EditArticleDTO ArticleToEdit { get; set; }
    }
}