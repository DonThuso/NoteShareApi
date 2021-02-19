using ShareNoteAppApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Interfaces
{
    public interface INoteRepository
    {
        Note CreateNote();
        Note GetNote(int id);
        List<Note> GetAllNotes();
        List<Note> GetUserNotes(int userId);
        List<Note> GetTopicNotes(int topicid);
        List<Note> GetSubjectNoters(int subjectId);
    }
}
