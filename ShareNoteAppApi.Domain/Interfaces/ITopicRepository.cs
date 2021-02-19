using ShareNoteAppApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Interfaces
{
    public interface ITopicRepository
    {
        Topic CreateTopic();
        Topic GetTopic(int topicId);
        List<Topic> GetAllTopics();
        List<Topic> GetSubjectTopics();
    }
}
