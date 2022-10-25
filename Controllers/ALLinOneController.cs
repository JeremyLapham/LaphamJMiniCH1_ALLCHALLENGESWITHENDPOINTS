using Microsoft.AspNetCore.Mvc;

namespace AllMiniChEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ALLinOneController : ControllerBase
{
    [HttpGet]
    [Route("MiniCH1")]

    public string HelloWorld()
    {
        return "Hello Jeremy";
    }

    [HttpGet]
    [Route("MiniCH2")]

    public int AddingNumber()
    {
        return 67+34568;
    }
    [HttpGet]
    [Route("MiniCH3")]
    
    public string AskingQuestions()
    {
        return "Hello Jeremy. You got up at 4AM.";
    }

    [HttpGet]
    [Route("MiniCH4")]
    
    public string GreaterThanLessThan()
    {
        return "Here the computer is comparing two numbers and gives the result \n 5 > 4:\n true";
    }

    [HttpGet]
    [Route("MiniCH5")]

    public string MadLibs()
    {
        return "This game is called MADLIBS \n It is a CHILLY Halloween night. I have my BATMAN costume on and I step outside to begin my AWESOME eveing of trick or treating. I RAN down the street and KICKED up to the first door. \"HUG or treat\" I said as the door began to open. \"HUG or treat?\" a DOG said on the other side of the door. \"What does that mean?\" \"It means if you don't give me a treat I'll have to BURN a STICK on you. \"GREAT\" he said as he GENTLY BOLTED out the door and HOPPED down the street. I guess he played a trick on me! \n This was a good game of MadLibs";
    }

    [HttpGet]
    [Route("MiniCH6")]

    public string OddOrEven()
    {
        return "This will tell you if the number is ODD or EVEN \n 6 is EVEN \n 3 is ODD \n 90 is EVEN \n 300001 is ODD";
    }

    [HttpGet]
    [Route("MiniCH7")]

    public string ReverseIt()
    {
        return "This will take an input and will reverse it \n45678 |||| 87654 \n hello there |||| ereht olleh \n 909090 |||| 090909 \n Have a great day! |||| !yad taerg a eavH";
    }

    [HttpGet]
    [Route("MiniCH8")]

    public string EightBall()
    {
        return "This will have the user ask themselves the question and then load the page for the computer to say a random phrase or answer to their question \n Yes \n Absolutly \n No \n Maybe \n who knows";
    }

    [HttpGet]
    [Route("MiniCH9")]

    public string ResturantPicker()
    {
        return "This will give you a random resturant to go to \n You should go to Sonic \n You should go to Chili's";
    }
    
}
