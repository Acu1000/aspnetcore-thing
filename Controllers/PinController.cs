using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjZtpai.Data;
using ProjZtpai.Models;
using ProjZtpai.Dto;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ProjZtpai.Controllers;

[ApiController]
[Route("api/pins")]
public class PinController : Controller
{
    private readonly ApplicationDbContext _context;

    public PinController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pin>>> GetPins()
    {
        return await _context.Pins.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pin>> GetPin(int id)
    {
        var pin = await _context.Pins.FindAsync(id);

        if (pin == null)
            return NotFound();

        return pin;
    }

    [Authorize]
    [HttpGet("mine")]
    public async Task<ActionResult<IEnumerable<Pin>>> MyPins()
    {
        var userId = User.FindFirstValue(
            ClaimTypes.NameIdentifier);

        var pins = await _context.Pins
            .Where(p => p.UserId! == userId)
            .ToListAsync();

        return pins;
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Pin>> CreatePin(PinCreateDto pinDto)
    {
        var pin = new Pin();

        pin.Latitude = pinDto.Latitude!.Value;
        pin.Longitude = pinDto.Longitude!.Value;
        pin.Title = pinDto.Title;

        var userId = User.FindFirstValue(
        ClaimTypes.NameIdentifier);

        pin.UserId = userId!;

        _context.Pins.Add(pin);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetPin),
            new { id = pin.Id },
            pin);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePin(int id)
    {
        var pin = await _context.Pins.FindAsync(id);

        if (pin == null)
            return NotFound();

        _context.Pins.Remove(pin);

        await _context.SaveChangesAsync();

        return NoContent();
    }

}