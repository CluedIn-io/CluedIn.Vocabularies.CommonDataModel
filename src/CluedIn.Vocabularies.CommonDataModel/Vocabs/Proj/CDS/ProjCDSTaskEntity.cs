using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSTaskEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSTaskEntityVocabulary()
        {
            VocabularyName = "ProjCDSTaskEntity";
            KeyPrefix = "commonDataModel.projcdstaskentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSTaskEntity";

            AddGroup("ProjCDSTaskEntity Details", group =>
            {
                Task = group.Add(new VocabularyKey(nameof(Task), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentTask = group.Add(new VocabularyKey(nameof(ParentTask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkBreakdownStructureID = group.Add(new VocabularyKey(nameof(WorkBreakdownStructureID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Task { get; private set; }
        public VocabularyKey ParentTask { get; private set; }
        public VocabularyKey WorkBreakdownStructureID { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}