using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceCalculationGroupEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceCalculationGroupEntityVocabulary()
        {
            VocabularyName = "JmgTimeAndAttendanceCalculationGroupEntity";
            KeyPrefix = "commonDataModel.jmgtimeandattendancecalculationgroupentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceCalculationGroupEntity";

            AddGroup("JmgTimeAndAttendanceCalculationGroupEntity Details", group =>
            {
                CalculationGroupId = group.Add(new VocabularyKey(nameof(CalculationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CalculationGroupId { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}