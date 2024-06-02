using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet;


[Route("/helloworld")]
public class HelloController : Controller 
{
// GET: /helloworld
[HttpGet]
   public IActionResult Index() 
   {
      string html = "<form method='post' action='/helloworld'>" +
      "<input type = 'text' name='name' />" +
      "<select name = 'language'><option value ='english' selected>English</option>" +
      "<option value = 'spanish'>Spanish</option>" +
      "<option value = 'bosnian'>Bosnian</option>" +
      "<option value = 'mongolian'>Mongolian</option>" +
      "<option value = 'french'>French</option>"+
      "</select>"+
      "<input type = 'submit' value='Greet me!' />" +
      "</form>";
      return Content(html, "text/html");
   }
   //POST: /helloworld
   [HttpPost]
    public IActionResult Index(string name, string language)
    {
        string greetingMessage = CreateMessage(name, language);
        string html = $"<h1 style='color: blue; font-family: Arial, sans-serif;'>{greetingMessage}</h1>";
        return Content(html, "text/html");
    }

   //Get: /helloworld/welcome
    [HttpGet("welcome/{name?}")]

    public IActionResult Welcome(string name = "World")
    {
        return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
    }


    public static string CreateMessage(string name, string language)
     {
         string helloTranslation = "";
         switch (language)
         {
             case "french":
                 helloTranslation = "Bonjour ";
                 break;
             case "spanish":
                 helloTranslation = "Hola ";
                 break;
             case "bosnian":
                 helloTranslation = "Zdravo ";
                 break;
             case "mongolian":
                 helloTranslation = "Sain baina uu ";
                 break;
             case "english":
                 helloTranslation = "Hello ";
                 break;
         }
         return helloTranslation + name;

     }
 

}
