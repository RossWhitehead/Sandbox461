using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using Ploeh.AutoFixture.AutoMoq;
using Sandbox461.Data;
using Sandbox461.Domain.Services;

namespace Sandbox461.Tests.Domain
{
    [TestClass]
    public class FilmServerTests
    {
        [TestMethod]
        public void AddFilm_HappyPath()
        {
            // Arrange
            var mockFilmsSet = new Mock<DbSet<Film>>();
            var mockContext = new Mock<Sandbox461DbContext>();
            mockContext.Setup(m => m.Films).Returns(mockFilmsSet.Object);

            var service = new FilmService(mockContext.Object);

            Film film = new Film
            {
                FilmId = 0,
                Title = "Test Title",
                Actors = new List<FilmMaker>(),
                Directors = new List<FilmMaker>()
            };

            // Act
            var result = service.AddFilm(film);

            // Assert
            mockFilmsSet.Verify(m => m.Add(It.IsAny<Film>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.IsInstanceOfType(result, typeof(Film));
        }

        [TestMethod]
        public void AddFilm_HappyPath_WithAutoFixture()
        {
            // Arrange
            var mockFilmsSet = new Mock<DbSet<Film>>();
            var mockContext = new Mock<Sandbox461DbContext>();
            mockContext.Setup(m => m.Films).Returns(mockFilmsSet.Object);

            var service = new FilmService(mockContext.Object);

            var fixture = new Fixture();
            var film = fixture.Create<Film>();

            // Act
            var result = service.AddFilm(film);

            // Assert
            mockFilmsSet.Verify(m => m.Add(It.IsAny<Film>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.IsInstanceOfType(result, typeof(Film));
        }

        [TestMethod]
        public void AddFilm_HappyPath_WithAutoFixtureAndAutoMoq()
        {
            // Arrange
            var mockFilmsSet = new Mock<DbSet<Film>>();
            var mockContext =new Mock<Sandbox461DbContext>();
            mockContext.Setup(m => m.Films).Returns(mockFilmsSet.Object);

            var service = new FilmService(mockContext.Object);

            var fixture = new Fixture().Customize(new AutoMoqCustomization());
            var film = fixture.Create<Film>();

            // Act
            var result = service.AddFilm(film);

            // Assert
            mockFilmsSet.Verify(m => m.Add(It.IsAny<Film>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.IsInstanceOfType(result, typeof(Film));
        }
    }
}
