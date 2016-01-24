using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ploeh.AutoFixture;
using Sandbox461.Website.Controllers;
using Sandbox461.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sandbox461.Tests.Website.Controllers
{
    [TestClass()]
    public class MailMessageControllerTests
    {
        [TestMethod()]
        public void Create_SavesValidMessage()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Create_ValidPath()
        {
            // Arrange
            var mockSet = new Mock<DbSet<MailMessage>>();
            var mockContext = new Mock<Sandbox461DbContext>();
            mockContext.Setup(m => m.MailMessages).Returns(mockSet.Object);

            var controller = new MailMessageController(mockContext.Object);

            var mailMessage = new MailMessage
            {
                MailId = 0,
                Subject = "Test Subject"
            };

            // Act
            var result = controller.Create(mailMessage) as ViewResult;

            // Assert
            mockSet.Verify(m => m.Add(It.IsAny<MailMessage>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod()]
        public void Create_ValidPathWithAutoFixture()
        {
            // Arrange
            var mockSet = new Mock<DbSet<MailMessage>>();
            var mockContext = new Mock<Sandbox461DbContext>();
            mockContext.Setup(m => m.MailMessages).Returns(mockSet.Object);

            var controller = new MailMessageController(mockContext.Object);

            var fixture = new Fixture();
            var mailMessage = fixture.Create<MailMessage>();

            // Act
            var result = controller.Create(mailMessage) as ViewResult;

            // Assert
            mockSet.Verify(m => m.Add(It.IsAny<MailMessage>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod()]
        public void Create_InvalidPath()
        {
            Assert.Fail();
        }
    }
}