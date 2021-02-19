using ShareNoteAppApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Interfaces
{
    public interface ISubjectRepository
    {
        Subject CreateSubject();
        Subject GetSubject(int subjectId);
        List<Subject> GetAllSubjects();
    }
}
