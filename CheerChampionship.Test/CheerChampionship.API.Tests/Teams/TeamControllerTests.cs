using AutoMapper;
using CheerChampionship.API.Teams.Controllers;
using CheerChampionship.API.Teams.Models;
using CheerChampionship.Core.Handler.Teams.Interface;
using CheerChampionship.Core.Handler.Teams.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CheerChampionship.API.Tests.Teams
{
    public class TeamControllerTests
    {
       private readonly Mock<ITeamHandler> _mockHandler;
       private readonly Mock<IMapper> _mockMapper;
       private readonly TeamController _controller;


       public TeamControllerTests()
       {
           _mockHandler = new Mock<ITeamHandler>();
           _mockMapper = new Mock<IMapper>();
           _controller = new TeamController(_mockHandler.Object, _mockMapper.Object);
       }


       [Fact]
       public void CriarEquipe_DeveRetornarOk()
       {
           // Arrange
           var equipeModel = new EquipeDto { Nome = "JOIA 2025" };
           var equipeEntity = new Equipe { Nome = "JOIA 2025" };


           _mockMapper.Setup(m => m.Map<Equipe>(equipeModel))
              .Returns(equipeEntity);


           // Act
           var result = _controller.CriarEquipe(equipeModel);


           // Assert
           var okResult = Assert.IsType<OkObjectResult>(result);
           var mensagens = Assert.IsType<string[]>(okResult.Value);
           Assert.Contains("Equipe criada", mensagens[0]);


           _mockHandler.Verify(h => h.CadastraEquipeHandler(It.IsAny<Equipe>()), Times.Once);
       }
    }
}