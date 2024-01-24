using FluentValidation;

namespace Twitter.Business.DTOs.TopicDTOs
{
    public class TopicCreateItemDTO
    {
        public string Name { get; set; }
    }
    public class TopicCreateItemDTOValidator : AbstractValidator<TopicCreateItemDTO> 
    {
        public TopicCreateItemDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(32);
        }
    }
}
