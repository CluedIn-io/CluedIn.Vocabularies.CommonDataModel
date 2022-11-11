using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceProfileTypeEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceProfileTypeEntityVocabulary()
        {
            VocabularyName = "JmgTimeAndAttendanceProfileTypeEntity";
            KeyPrefix = "commonDataModel.jmgtimeandattendanceprofiletypeentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceProfileTypeEntity";

            AddGroup("JmgTimeAndAttendanceProfileTypeEntity Details", group =>
            {
                ProfileTypeId = group.Add(new VocabularyKey(nameof(ProfileTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileSpecificationTypeCode = group.Add(new VocabularyKey(nameof(ProfileSpecificationTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProfileTypeId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ProfileSpecificationTypeCode { get; private set; }


    }
}