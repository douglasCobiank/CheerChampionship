using AutoMapper;
using CheerChampionship.API.AthletesModels.Models;
using CheerChampionship.Core.Handler.Athletes;
using CheerChampionship.Core.Handler.Athletes.Models;
using CheerChampionship.Infrastructure.Data.Models;
using CheerChampionship.Infrastructure.Repositories.Athlete;
using Moq;

namespace CheerChampionship.Core.Tests.Athletes
{
    public class AthleteServiceTests
    {
        private readonly Mock<IAthleteRepository> _athleteRepositoryMock;
        private readonly Mock<IMapper> _mockMapper;
        private readonly AthleteService _athleteService;

        public AthleteServiceTests()
        {
            _mockMapper = new Mock<IMapper>();
            _athleteRepositoryMock = new Mock<IAthleteRepository>();
            _athleteService = new AthleteService(_athleteRepositoryMock.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task AddAtletaAsync_DeveChamarRepositorioComAtletaMapeado()
        {
            // Arrange
            var atletaDto = new AtletaDto { Nome = "JOIA 2025", Cidade = "Ponta Grossa" };

            var atletaEntity = new Atleta { Nome = "JOIA 2025", Cidade = "Ponta Grossa" };
            var atletaData = new AtletaData { Nome = "JOIA 2025", Cidade = "Ponta Grossa" };

            // Mapeia de DTO -> Entity
            _mockMapper.Setup(m => m.Map<Atleta>(atletaDto))
                .Returns(atletaEntity);

            // Mapeia de Entity -> Data
            _mockMapper.Setup(m => m.Map<AtletaData>(atletaEntity))
                .Returns(atletaData);

            // Act
            await _athleteService.AddAtletaAsync(atletaEntity);

            // Assert
            _athleteRepositoryMock.Verify(
                repo => repo.AddAsync(It.Is<AtletaData>(a =>
                    a.Nome == "JOIA 2025" &&
                    a.Cidade == "Ponta Grossa"
                )),
                Times.Once
            );
        }
    }
}
