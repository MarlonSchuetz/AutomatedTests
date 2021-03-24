using AutomatedTests.UI.Selenium;
using AutomatedTests.UI.Selenium.WebDrivers;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using Xunit;

namespace AutomatedTests.Tests
{
    public class DuolingoTests : IClassFixture<TestsFixture>, IDisposable
    {
        private Page _pagina;

        public DuolingoTests() 
        {
            _pagina = new Page(60,60); 
        }

        public void Dispose() 
        {
            _pagina.Close();
        }

        [Fact]
        public void LoginComUsuarioSenha_CredenciaisCorretas_Sucesso()
        {
            // Arrange
            string usuario = "usuario_correto";
            string senha = "senha_valida";

            // Act
            _pagina.Navigate(WebDriverEnum.RemoteWebDriverChrome, DuolingoMap.Url, urlRemoteWebDriver: "http://localhost:4444/wd/hub");

            _pagina.Click(xpath: DuolingoMap.BotaoJaTenhoUmaConta);
            _pagina.SendKeys(DuolingoMap.CampoUsuario, usuario);
            _pagina.SendKeys(DuolingoMap.CampoSenha, senha);
            _pagina.Click(xpath: DuolingoMap.BotaoEntrar);

            // Assert
            _pagina.WebDriver.Title.Should().Be("Duolingo - The world's best way to learn a language");
        }

        [Fact]
        public void LoginComUsuarioSenha_CredenciaisErradas_Erro()
        {
            // Arrange
            string usuario = "usuario_errado";
            string senha = "senha_invalida";

            // Act
            _pagina.Navigate(WebDriverEnum.RemoteWebDriverChrome, DuolingoMap.Url, urlRemoteWebDriver: "http://localhost:4444/wd/hub");

            _pagina.Click(xpath: DuolingoMap.BotaoJaTenhoUmaConta);
            _pagina.SendKeys(DuolingoMap.CampoUsuario, usuario);
            _pagina.SendKeys(DuolingoMap.CampoSenha, senha);
            _pagina.Click(xpath: DuolingoMap.BotaoEntrar);

            // Assert
            _pagina.WebDriver.FindElement(By.ClassName("_1G8OV")).Text.Should().Be("Wrong password. Please try again.");
        }
    }
}
