using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealTimeTable.Data;

namespace RealTimeTable.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly AppDbContext _context;

		public EmployeeController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var employees = await _context.Employees.ToListAsync();
			return View(employees);
		}
	}
}
