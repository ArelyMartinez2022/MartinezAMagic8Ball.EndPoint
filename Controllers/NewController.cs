/*
ARELY MARTINEZ 
OCT 25, 2022 9:30PM
EIGHT BALL END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE USER 
CAN ENTER A STRING. AND ON POSTMAN IT WILL 
REPSOND WITH THE USERS FORTUNE FROM THE EIGHT BALL.

PEER REVIEW: JESSIE LAMZON - CODE RAN WELL AND WITHOUT 
ERRORS.  I REALLY LIKE HOW CLEAN THE CODE LOOKS AND IS 
NICE AND SIMPLE.  GOOD JOB
*/

using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("Ball")]

    public string putOut() {
        return "WHAT IS YOUR QUERY?? \nASK THE MAGIC 8 BALL?";
    } 


    [HttpGet]
    [Route("Ball/{response}")]
    //localHost9000/Input/Name
    public string ReversIt(string response)
    {

        string answer = "";
        string eight = "";

        string[] Mex = { "BETTER NOT TELL YOU NOW.", "MOST LIKELY.", "YES", "SIGNS POINT TO YES", "ASK AGAIN LATER.", "CANNOT PREDICT NOW.", "IT IS DECIDEEDLY SO", "WITHOUT A DOUBT.", "YES.", "AS I SEE IT, YES.", "YOU REALLY WANNA KNOW?.", "DON'T COUNT ON IT.", "NO - DEFINITELY.", "MY REPLY IS YES.", "NOT LIKELY.", "MY SOURCES SAY NO." , "SILLY QUESTION." };
        eight = " ---- THE MAGIC EIGHT BALL HAS SPOKEN ---- ";
        Random random = new Random();
        int randomOut = random.Next(0, 16);
        answer = Mex[randomOut];
        return $"*YOUR QUESTION: {response} \n*YOUR RESPONSE: {answer} \n{eight} ";
    }

    //return$"This would be my return {var} "
}