using system;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class EntryPoint
{
 static void main()
 {
   string url= "http://testing.todorvachev.com/selectors/id";
   string cssPath = "";
   string xPath = "";
   IWebdrive driver = new chromeDriver();
   driver.navigate().GoToUrl(url);
   IWebeElement element = driver.FindElemet(By.ClassName(ClassName));  
   if(elment.Displayed){
   GreenMessage("Found the element");
   }
   else{
    ReadMessage ("Not Found");
   }
   Console.WriteLine(elemet.Text);
        Thread.sleep(5000);
   driver.Quit();
 }
 
	private static void ReadMessage(string message){
    System.console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine(message);
	System.console.ForegroundColor = ConsoleColor.White;
	}

	private static void GreenMessage(string message){
    System.console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine(message);
	System.console.ForegroundColor = ConsoleColor.White;
	}
	}