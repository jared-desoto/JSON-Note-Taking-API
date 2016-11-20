using BusinessService;
using DO;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace NotesAPI
{
    public class notesController : ApiController
    {
        // GET api/notes
        // Retrieves all notes created
        [HttpGet]
        public IHttpActionResult GetAllNotes()
        {
            try
            {
                NotesBS BS = new NotesBS();
                List<NoteDO> listNoteDO = BS.Fetch();
                return Ok(listNoteDO);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Try again!");
                throw;
            }
        }


        // GET api/notes/id
        // Retrieves note with specified id
        [HttpGet]
        public IHttpActionResult GetOneNote(int id)
        {
            try
            {
                NotesBS BS = new NotesBS();
                NoteDO noteDO = BS.Fetch(id);

                return Ok(noteDO);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Try again!");
                throw;
            }
        }

        //// GET api/notes
        //// Retrieves notes that contain specified query parameter
        [HttpGet]
        public IHttpActionResult GetQueriedNote([FromUri] string query)
        {
            try
            {
                NotesBS BS = new NotesBS();
                List<NoteDO> noteDO = BS.Fetch(query);

                return Ok(noteDO);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Try again!");
                throw;
            }
        }


        //// POST api/notes 
        //// Creates a note
        [HttpPost]
        public IHttpActionResult Post(NoteDO body)
        {
            try
            {
                NotesBS BS = new NotesBS();
                NoteDO noteDO = BS.Save(body.body);

                return Ok(noteDO);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Try again!");
                throw;
            }

        }
    }
}
