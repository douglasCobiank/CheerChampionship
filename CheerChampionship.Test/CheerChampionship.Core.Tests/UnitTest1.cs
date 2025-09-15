using Xunit;
using Moq;
using CheerChampionship.API.Championship.Controllers;
using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.API.Championship.Models;
using CheerChampionship.Core.Handler.Championships.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System;


namespace CheerChampionship.Tests.Championship.Controllers
{
   public class ChampionshipControllerTests
   {
       private readonly Mock<IChampionshipHandler> _mockHandler;
       private readonly Mock<IMapper> _mockMapper;
       private readonly ChampionshipController _controller;


       public ChampionshipControllerTests()
       {
           _mockHandler = new Mock<IChampionshipHandler>();
           _mockMapper = new Mock<IMapper>();
           _controller = new ChampionshipController(_mockHandler.Object, _mockMapper.Object);
       }


       [Fact]
       public void CriarCampeonato_DeveRetornarOk()
       {
           // Arrange
           var campeonatoModel = new CampeonatoDto { Nome = "JOIA 2025" };
           var campeonatoEntity = new Campeonato { Name = "JOIA 2025" };


           _mockMapper.Setup(m => m.Map<Campeonato>(campeonatoModel))
              .Returns(campeonatoEntity);


           // Act
           var result = _controller.CriarCampeonato(campeonatoModel);


           // Assert
           var okResult = Assert.IsType<OkObjectResult>(result);
           var mensagens = Assert.IsType<string[]>(okResult.Value);
           Assert.Contains("Campeonato criado", mensagens[0]);


           _mockHandler.Verify(h => h.CadastraChampionshipHandler(It.IsAny<Campeonato>()), Times.Once);
       }


       [Fact]
       public void EditarCampeonato_DeveRetornarOkComMensagem()
       {
           // Arrange
           var id = Guid.NewGuid();
           var campeonatoModel = new CampeonatoDto { Nome = "Paranaense 2025" };
           var campeonatoEntity = new Campeonato { Name = "Paranaense 2025" };


           _mockMapper.Setup(m => m.Map<Campeonato>(campeonatoModel))
                      .Returns(campeonatoEntity);


           // Act
           var result = _controller.EditarCampeonato(campeonatoModel);


           // Assert
           var okResult = Assert.IsType<OkObjectResult>(result);
           var mensagem = okResult.Value?.ToString();
           Assert.Contains("editado com sucesso", mensagem);
           Assert.Contains("Paranaense 2025", mensagem);


           _mockHandler.Verify(h => h.EditaChampionshipHandler(It.IsAny<Campeonato>()), Times.Once);
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
           _mockHandler.Verify(h => h.BuscaChampionshipHandler(nome, cidade), Times.Once);
       }
   }
}
