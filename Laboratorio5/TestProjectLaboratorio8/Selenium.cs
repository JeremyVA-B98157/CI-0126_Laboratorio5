using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectLaboratorio8
{
    public class Selenium
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        { 
            driver = new ChromeDriver();
        }

        [Test]
        public void PruebaIngresoCrearPaises()
        {
            // Arrange
            // Crea el driver de Chrome
            string URL = "https://localhost:44331";
            // Fullscreen
            driver.Manage().Window.Maximize();
            // Act
            // Se va a la URL indicada
            driver.Url = URL;
            // Assert
            // Debe usar otro tipo de assert
            Assert.IsNotNull(driver);
        }

        [Test]
        public void PruebaCrearPaises()
        {
            // Arrange
            // Crea el driver de Chrome y los web element necesarios
            IWebElement cajaDeTexto;
            IWebElement botonCrear;
            IWebElement mensajeExito;
            string URL = "https://localhost:44331/Paises/CrearPais";
            // Fullscreen
            driver.Manage().Window.Maximize();
            // Act
            // Se va a la URL indicada
            driver.Url = URL;
            // Llena el formulario
            cajaDeTexto = driver.FindElement(By.Name("Nombre"));
            cajaDeTexto.SendKeys("Holanda");
            cajaDeTexto = driver.FindElement(By.Name("Continente"));
            cajaDeTexto.SendKeys("Europa");
            cajaDeTexto = driver.FindElement(By.Name("Idioma"));
            cajaDeTexto.SendKeys("Neerlandés");

            // Hace submit del formulario
            botonCrear = driver.FindElement(By.ClassName("btn-success"));
            botonCrear.Click();

            // Busca el mensaje de confirmación
            mensajeExito = driver.FindElement(By.ClassName("alert-success"));
            // Assert
            // Comprobamos que el mensaje de exito exista despues de la insercion
            Assert.IsNotNull(mensajeExito);
        }
    }
}
