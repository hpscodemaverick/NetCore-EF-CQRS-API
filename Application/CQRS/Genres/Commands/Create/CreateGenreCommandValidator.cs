﻿namespace Application.CQRS.Genres.Commands.Create
{
using FluentValidation;
    public class CreateGenreCommandValidator : AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).MinimumLength(3);
            RuleFor(x => x.Description).NotEmpty();

        }
    }
}
