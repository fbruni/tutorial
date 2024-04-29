using AutoMapper;
using BLL.Models;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("Api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
            
        }

        [HttpGet("GetBook")]
        public IActionResult Get(int id)
        {
            return Ok(bookService.GetById(id));
        }

        [HttpGet("GetAllBooks")]
        public IActionResult GetAll()
        {
            return Ok(bookService.GetBooks());
        }

        [HttpPost("CreateBook")]
        public IActionResult InsertBook(BookModel model)
        {
            try
            {
                bookService.Insert(model);
                return Ok();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut("UpdateBook")]
        public IActionResult Update(BookModel model)
        {
            try
            {
                bookService.Update(model);
                return Ok();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("DeleteBook")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                bookService.Delete(id);
                return Ok();
            } catch(Exception ex) {

                return BadRequest(ex.Message);
                throw;

            }
        }


    }
}
