using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers.Subjects
{
    public class SubjectManager
    {
        private readonly SubjectRepository _repo = new SubjectRepository();

        public void CreateSubject(string name)
        {
            //          _repo.Insert(name);
        }

        internal object GetAllSubjects()
        {
            throw new NotImplementedException();
        }
    }
}