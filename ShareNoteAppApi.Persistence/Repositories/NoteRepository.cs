using ShareNoteAppApi.Domain.Interfaces;
using ShareNoteAppApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Persistence.Repositories
{
    public class NoteRepository : INoteRepository
    {
        public Note CreateNote()
        {
            throw new NotImplementedException();
        }

        public List<Note> GetAllNotes()
        {
            throw new NotImplementedException();
        }

        public Note GetNote(int id)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetSubjectNoters(int subjectId)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetTopicNotes(int topicid)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetUserNotes(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
