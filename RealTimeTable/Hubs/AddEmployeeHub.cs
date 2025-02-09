using Microsoft.AspNetCore.SignalR;
using RealTimeTable.Data;
using RealTimeTable.Models;

namespace RealTimeTable.Hubs
{
	public class AddEmployeeHub : Hub
	{
		private readonly AppDbContext _context;

		public AddEmployeeHub(AppDbContext context)
		{
			_context = context;
		}

		public async Task AddEmployee(Employee employee)
		{

			// save in database
			await _context.Employees.AddAsync(employee);
			await _context.SaveChangesAsync();

			// send to all online clients
			await Clients.All.SendAsync("newEmployee", employee);
		}
	}
}
