﻿namespace Application.CQRS.Artists.Commands.Update
{
    using Application.Common.Exceptions;
    using Application.Common.Interfaces;
    using Domain.Entities;
    using MediatR;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    public class UpdateArtist : IRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string YearActive { get; set; }
        public string Biography { get; set; }
        public string Born { get; set; }
        public string Died { get; set; }
        public string AKA { get; set; }

    }

    public class UpdateArtistHandler : IRequestHandler<UpdateArtist>
    {
        private readonly IApplicationDbContext _context;

        public UpdateArtistHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateArtist request, CancellationToken cancellationToken)
        {
            bool isValidGuid = Guid.TryParse(request.Id, out _);
            if (!isValidGuid)
            {
                throw new InvalidGuidException(nameof(Artist), request.Id);
            }

            var entity = await _context.Artist.FindAsync(Guid.Parse(request.Id));
            if (entity == null)
            {
                throw new NotFoundException(nameof(Artist), request.Id);
            }
            var basicInfoEntity = await _context.ArtistBasicInfo.FindAsync(Guid.Parse(request.Id));

            entity.Id = Guid.Parse(request.Id);
            entity.ArtistName = request.Name;
            entity.Biography = request.Biography;
            entity.YearActive = request.YearActive;

            basicInfoEntity.ArtistId = Guid.Parse(request.Id);
            basicInfoEntity.Born = request.Born;
            basicInfoEntity.AlsoKnownAs = request.AKA;
            basicInfoEntity.Died = request.Died;

            entity.ArtistBasicInfo = basicInfoEntity;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
