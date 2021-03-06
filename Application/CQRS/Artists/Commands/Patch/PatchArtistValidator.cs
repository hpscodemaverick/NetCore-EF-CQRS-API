﻿namespace Application.CQRS.Artists.Commands.Patch
{
    using FluentValidation;
    class PatchArtistValidator : AbstractValidator<PatchArtist>
    {
        public PatchArtistValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).MinimumLength(3);
            RuleFor(x => x.YearActive).NotEmpty();
            RuleFor(x => x.Biography).NotEmpty();
            RuleFor(x => x.Born).NotEmpty();
        }
    }
}
