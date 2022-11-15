using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceApprovalGroupEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceApprovalGroupEntityVocabulary()
        {
            VocabularyName = "Jmg Time And Attendance Approval Group Entity";
            KeyPrefix = "commonDataModel.jmgtimeandattendanceapprovalgroupentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceApprovalGroupEntity";

            AddGroup("JmgTimeAndAttendanceApprovalGroupEntity Details", group =>
            {
                ApprovalGroupId = group.Add(new VocabularyKey(nameof(ApprovalGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ApprovalGroupId { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}