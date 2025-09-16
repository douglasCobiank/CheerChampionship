using AutoMapper;
using CheerChampionship.API.Athletes.Controllers;
using CheerChampionship.API.AthletesModels.Models;
using CheerChampionship.Core.Handler.Athletes.Interface;
using CheerChampionship.Core.Handler.Athletes.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CheerChampionship.API.Tests.Athletes
{
    public class AthletesControllerTests
    {
        private readonly Mock<IAthleteHandler> _mockHandler;
        private readonly Mock<IMapper> _mockMapper;
        private readonly AthletesController _controller;

        public AthletesControllerTests()
        {
            _mockHandler = new Mock<IAthleteHandler>();
            _mockMapper = new Mock<IMapper>();
            _controller = new AthletesController(_mockHandler.Object, _mockMapper.Object);
        }

        [Fact]
        public void CriarAtleta_DeveRetornarOk()
        {
            // Arrange
            var atletaModel = new AtletaDto 
            { 
                Nome = "JOIA 2025", 
                Documento = new AthletesModels.DocumentoDto { CPF = "123", RG = "123" } 
            };

            var atletaEntity = new Atleta 
            { 
                Nome = "JOIA 2025", 
                Documento = new Documento { CPF = "123", RG = "123" } 
            };

            _mockMapper
                .Setup(m => m.Map<Atleta>(atletaModel))
                .Returns(atletaEntity);

            // Act
            var result = _controller.CriarAtleta(atletaModel); // <- corrige aqui

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var mensagens = Assert.IsType<string[]>(okResult.Value);
            Assert.Contains("Atleta criado", mensagens[0]); // <- corrige aqui

            _mockHandler.Verify(h => h.CadastraAthleteHandler(It.IsAny<Atleta>()), Times.Once);
        }
    }
}
