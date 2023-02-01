using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Projet0001;

public partial class MainPage : ContentPage
{
	//process
	 
	// 1 - installer le Nuget Selenium
	// * Aller dans Outils
	// * Choisir Gestionnaire de package Nuget
	// * Choisir gerer les package Nuget
	// * Cliquer sur Parcourir
	// * Saisir selenium
	// * Choisir Selenium.WebDriver.ChromeDriver
	// * Installer le navigateur Chrome
	// * Installer ( si absent ) le driver a l'amplacement : sur C dans Drivers dans Web

	public MainPage()
	{
		InitializeComponent();
		this.CliquerSurUnBouton();
	}

	public void LancerNavigateur()
	{
		// Créer un objet ChromeDriver
		IWebDriver driver = new ChromeDriver(@"c:\Drivers\Web");
		// La methode lance le navigateur à l'adresse google.com
		driver.Navigate().GoToUrl("https://google.com");
		// la methode dort pendant 10 secondes
		Thread.Sleep(10000);
		// la methode quitte le navigateur
		driver.Quit();
	}
	public void CliquerSurUnBouton()
	{
		// Créer un objet ChromeDriver
		IWebDriver driver = new ChromeDriver(@"c:\Drivers\Web");
		// La methode lance le navigateur à l'adresse google.com
		driver.Navigate().GoToUrl("https://google.com");
		// la methode dort pendant 10 secondes
		Thread.Sleep(5000);
		// la methode trouve sur la page l'element defini ( ici le bouton accepter )
		var element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/span/div/div/div/div[3]/div[1]/button[2]/div"));
		// la méthode simule un clique sur le bouton
		element.Click();
		// je positionne mon curseur dans la zone de saisie de google 
		element = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
		// je saisis le texte que je desire rechercher
		element.SendKeys("chat mignon");
		// je lance la recherche du terme saisi    
		element.Submit();
		/// La méthode dort pendant 3 secondes
		Thread.Sleep(3000);
		// je veux récupérer tous les elements qui contiennent le Tag h3
		var elements = driver.FindElements(By.TagName("h3"));
		// je veux récupérer le texte de chaque tag h3
		// Etape 1 : créer une boucle 
		foreach (var monElement in elements)
		{
			// Je mets le texte dans le h3 une case 
			string monTexte = monElement.Text;

		}
		// Je desire aller sur la page 2
		element = driver.FindElement(By.LinkText("2"));
		// je clique sur le lien 2
		element.Click();
		// je veux defiler les pages de recherche GOOGLE 
		// je crée une case mémoire pour me souvenir de la page du numéro de la page 
		int compteur = 2;
		//for = boucle 
		//int compteur = 3 le compteir démarre à 3
		//compteur <=10000 le compteur temrmine à 10000
		// le compteur++ A chaque passage dans la boucle, il ajoute 1
		// bn corresponde à la case mémoire 

			// Je recherche un lien qui correspond à la case mémoire
			int nb = 3;
			for (int compteur = 3; compteur <= 10000; compteur++)
			{
				element = driver.FindElement(By.LinkText(nb.ToString()));
				element.Click();
				// jjaoute à la case mémoire
				nb++;
				//récupérer le texte
				string monTexte = element.Text;
				//Tester le contenu pour savoir s'il contient 
				if (monTexte.Contains("3"))
				{
					break;
				}
				//je m'endors 3 secondes
				Thread.Sleep(3000);
			}
	}	
}