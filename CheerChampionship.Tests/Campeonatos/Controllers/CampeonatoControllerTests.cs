using Xunit;
using Moq;
using CheerChampionship.API.Controllers;
using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.API.Models;
using CheerChampionship.Core.Handler.Championships.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System;

namespace CheerChampionship.Tests.Campeonatos.Controllers
{
    public class CampeonatosControllerTests
    {
        private readonly Mock<ICampeonatoHandler> _mockHandler;
        private readonly Mock<IMapper> _mockMapper;
        private readonly CampeonatosController _controller;

        public CampeonatosControllerTests()
        {
            _mockHandler = new Mock<ICampeonatoHandler>();
            _mockMapper = new Mock<IMapper>();
            _controller = new CampeonatosController(_mockHandler.Object, _mockMapper.Object);
        }

        [Fact]
        public void CriarCampeonato_DeveRetornarOk()
        {
            // Arrange
            var campeonatoModel = new Campeonato { Nome = "JOIA 2025" };
            var campeonatoEntity = new Championship { Name = "JOIA 2025" };

            _mockMapper.Setup(m => m.Map<Championship>(campeonatoModel))
               .Returns(campeonatoEntity);

            // Act
            var result = _controller.CriarCampeonato(campeonatoModel);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var mensagens = Assert.IsType<string[]>(okResult.Value);
            Assert.Contains("Campeonato criado", mensagens[0]);

            _mockHandler.Verify(h => h.CadastraCampeonatoHandler(It.IsAny<Championship>()), Times.Once);
        }

        [Fact]
        public void EditarCampeonato_DeveRetornarOkComMensagem()
        {
            // Arrange
            var id = Guid.NewGuid();
            var campeonatoModel = new Campeonato { Nome = "Paranaense 2025" };
            var campeonatoEntity = new Championship { Name = "Paranaense 2025" };

            _mockMapper.Setup(m => m.Map<Championship>(campeonatoModel))
                       .Returns(campeonatoEntity);

            // Act
            var result = _controller.EditarCampeonato(id, campeonatoModel);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var mensagem = okResult.Value.ToString();
            Assert.Contains("editado com sucesso", mensagem);
            Assert.Contains("Paranaense 2025", mensagem);

            _mockHandler.Verify(h => h.EditaCampeonatoHandler(It.IsAny<Championship>()), Times.Once);
        }

        [Fact]
        public void BuscarCampeonato_DeveChamarHandlerERetornarOk()
        {
            // Arrange
            var nome = "JOIA";
            var cidade = "Ponta Grossa";

            // Act
            var result = _controller.BuscarCampeonato(nome, cidade);

            // Assert
            Assert.IsType<OkResult>(result);
            _mockHandler.Verify(h => h.BuscaCampeonatoHandler(nome, cidade), Times.Once);
        }
    }
}