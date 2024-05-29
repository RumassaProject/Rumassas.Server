﻿using MediatR;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.CommentCases.Commands
{
    public class CreateCommentCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public Guid? UserId { get; set; }
    }
}
