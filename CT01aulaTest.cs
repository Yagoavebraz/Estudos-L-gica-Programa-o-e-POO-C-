// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class CT01aulaTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void cT01aula() {
    driver.Navigate().GoToUrl("https://livros.inoveteste.com.br/");
    driver.Manage().Window.Size = new System.Drawing.Size(856, 1031);
    driver.FindElement(By.CssSelector("#sidr-navigation-container > #nav-wrap > #primary_menu > #menu-item-80 span")).Click();
    driver.FindElement(By.Name("your-name")).Click();
    driver.FindElement(By.Name("your-name")).SendKeys("yago braz");
    driver.FindElement(By.Name("your-email")).SendKeys("yagoavebraz@gmail.com");
    driver.FindElement(By.Name("your-subject")).SendKeys("aulas");
    driver.FindElement(By.CssSelector(".wpcf7-submit")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".wpcf7-not-valid-tip")).Text, Is.EqualTo("O campo é obrigatório."));
  }
}
