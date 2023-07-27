using Casgem_DapperProject.DAL.Entities;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Casgem_DapperProject.Controllers
{
    public class HeadingController : Controller
    {
        private readonly string _connectionString = "Server=.;initial catalog=CasgemDbDapper; integrated security=true";
        public async Task<IActionResult> Index()
        {
            await using var connection = new SqlConnection(_connectionString);
            var values = await connection.QueryAsync<Headings>("Select * From TblHeading");
            return View(values);
        }
    }
}
