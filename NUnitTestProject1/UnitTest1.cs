using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitTestProject1
{
    public class Tests
    {
        public string nomeId ="nomeId", emailId="emailID",salvarButtonId="saveId",NotificacaoID="NotificacaoID";
       
        public void acessarUrl(IWebDriver driver,string url) {
            driver.Navigate().GoToUrl(url);
        }
        public void closeBrowser(IWebDriver driver) {
            driver.Close();
        }
        public void cadastrarUsuario(IWebDriver driver,string nome, string email) {
            driver.FindElement(By.Id(nomeId)).SendKeys(nome);
            driver.FindElement(By.Id(emailId)).SendKeys(email);
            driver.FindElement(By.Id(salvarButtonId)).Click();
        }
        public void validaUsuarioCadastrado(IWebDriver driver, string nome, string email) {
            Assert.True( driver.FindElement(By.Id(NotificacaoID)).Text.Contains(nome));
            Assert.True( driver.FindElement(By.Id(NotificacaoID)).Text.Contains(email));
        }
    }
}