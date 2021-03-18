﻿namespace Application.CQRS.Artists.Commands.Create
{
    using Application.Common.Interfaces;
    using Domain.Entities;
    using MediatR;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    public class CreateArtist : IRequest<string>
    {
        public string Name { get; set; }
        public string YearActive { get; set; }
        public string Biography { get; set; }
        //public ArtistBasicInfo ArtistBasicInfo { get; set; }

        public string Born { get; set; }
        public string Died { get; set; }
        public string AKA { get; set; }
    }


    public class CreateArtistHandler : IRequestHandler<CreateArtist, string>
    {

        private readonly IApplicationDbContext _context;

        public CreateArtistHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(CreateArtist request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            var entity = new Artist
            {
                Id = id,
                ArtistName = request.Name,
                Biography = request.Biography,
                YearActive = request.YearActive,
                ArtistBasicInfo = new ArtistBasicInfo
                {
                    ArtistId = id,
                    Born = request.Born,
                    Died = request.Died,
                    AlsoKnownAs = request.AKA
                }
            };

            _context.Artist.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id.ToString();
        }
    }
}
