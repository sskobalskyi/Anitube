using Anitube.Core.Entities;

namespace Anitube.Application.DTOs.GenreDTOs
{
    public class GenreDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
