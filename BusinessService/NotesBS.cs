using DAL;
using DO;
using System.Collections.Generic;

namespace BusinessService
{
    public class NotesBS
    {
        public List<NoteDO> Fetch()
        {
            NotesDAL dal = new NotesDAL();
            List<NoteDO> listNoteDOs = dal.Fetch();
            return listNoteDOs;
        }

        public NoteDO Fetch(int id)
        {
            NotesDAL dal = new NotesDAL();
            NoteDO result = dal.Fetch(id);
            return result;
        }

        public List<NoteDO> Fetch(string query)
        {
            NotesDAL dal = new NotesDAL();
            List<NoteDO> listNoteDOs = dal.Fetch(query);
            return listNoteDOs;
        }

        public NoteDO Save(string note)
        {
            NotesDAL dal = new NotesDAL();
            NoteDO savedNote = dal.Save(note);
            return savedNote;
        }
    }
}
