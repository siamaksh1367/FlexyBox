using AutoMapper;
using FlexyBox.core.Queries.GetComments;
using FlexyBox.core.Services.ContentStorage;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace FlexyBox.core.Commands.CreateComment
{
    public class CreateCommentCommandHandler : ICommandHandler<CreateCommentCommand, GetCommentResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContentStorage _contentStorage;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateCommentCommandHandler(IUnitOfWork unitOfWork, IContentStorage contentStorage, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _contentStorage = contentStorage;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<GetCommentResponse> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new Comment();

            comment.PostId = request.PostId;
            comment.Content = request.Content;
            var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim != null)
            {
                comment.UserId = userIdClaim.Value;
            }
            else
            {
                throw new UnauthorizedAccessException("User is not authenticated.");
            }
            comment.Created = DateTime.UtcNow;
            var createdComment = await _unitOfWork.Comments.AddAsync(comment);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<GetCommentResponse>(createdComment);

        }
    }
}
