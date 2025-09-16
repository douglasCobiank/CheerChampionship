using Moq;
using CheerChampionship.API.Championship.Controllers;
using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.API.Championship.Models;
using CheerChampionship.Core.Handler.Championships.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


namespace CheerChampionship.Tests.Championship
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
   }
}