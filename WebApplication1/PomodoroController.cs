using Microsoft.AspNetCore.Mvc;
[Route("api/pomodoro")]
[ApiController]
public class PomodoroController : ControllerBase
{
    [HttpPost("start")]
    public IActionResult StartPomodoro()
    {
        // Implemente a lógica para iniciar o Pomodoro
        return Ok("Pomodoro iniciado.");
    }

    [HttpPost("stop")]
    public IActionResult StopPomodoro()
    {
        // Implemente a lógica para parar o Pomodoro
        return Ok("Pomodoro parado.");
    }
}