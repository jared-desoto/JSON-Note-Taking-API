using DO;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class NotesDAL
    {
        private static DataTable table;
        private static int id;

        public List<NoteDO> Fetch()
        {
            List<NoteDO> fetchedDOs = new List<NoteDO>();

            if (table != null)
            {
                DataRow[] result = table.Select();
                foreach (DataRow row in result)
                {
                    NoteDO singleNoteDO = new NoteDO();
                    singleNoteDO.id = int.Parse(row[0].ToString());
                    singleNoteDO.body = row[1].ToString();
                    fetchedDOs.Add(singleNoteDO);
                }
            }

            return fetchedDOs;
        }

        public NoteDO Fetch(int id)
        {
            NoteDO fetchedDO = new NoteDO();

            if (table != null)
            {
                string whereClause = "id = " + id.ToString();
                DataRow[] result = table.Select(whereClause);
                if (result.Count() == 1)
                {
                    foreach (DataRow row in result)
                    {
                        fetchedDO.id = int.Parse(row[0].ToString());
                        fetchedDO.body = row[1].ToString();
                    }
                }
            }

            return fetchedDO;
        }

        public List<NoteDO> Fetch(string content)
        {
            List<NoteDO> fetchedDOs = new List<NoteDO>();

            if (table != null)
            {
                string whereClause = "body like '%" + content.ToString() + "%'";
                DataRow[] result = table.Select(whereClause);
                foreach (DataRow row in result)
                {
                    NoteDO singleNoteDO = new NoteDO();
                    singleNoteDO.id = int.Parse(row[0].ToString());
                    singleNoteDO.body = row[1].ToString();
                    fetchedDOs.Add(singleNoteDO);
                }
            }

            return fetchedDOs;
        }

        public NoteDO Save(string body)
        {
            NoteDO savedDO = new NoteDO();
            if (body != null)
            {
                if (table == null)
                {
                    table = InitializeDataTable();
                    id = 0;
                }

                id++;
                table.Rows.Add(id, body);
                string whereClause = "id = " + id.ToString();
                DataRow[] result = table.Select(whereClause);
                foreach (DataRow row in result)
                {
                    savedDO.id = int.Parse(row[0].ToString());
                    savedDO.body = row[1].ToString();
                }
            }
            return savedDO;
        }

        // To save time, dataTables were used with the limitation that they only exist in memory.
        // To improve, utilize actual database and can use the following SQL statements:
        private static string fetchSQL ="select id, note from mytable";
        private static string fetchSpecificNoteSQL = "select id, note from myTable where id = id";
        private static string fetchNoteContentSQL = "select id, note from myTable where note like '%string%'";
        private static string insertSQL = @"insert into mytable(id, note) 
                                            values (id, body)";

        static DataTable InitializeDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("body", typeof(string));

            return table;
        }

    }
}
