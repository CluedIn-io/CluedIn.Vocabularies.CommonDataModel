using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjStatusTypeRuleEntityVocabulary : SimpleVocabulary
    {
        public ProjStatusTypeRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjStatusTypeRuleEntity";
            KeyPrefix = "commonDataModel.projstatustyperuleentity";
            KeySeparator = ".";
            Grouping = "/ProjStatusTypeRuleEntity";

            AddGroup("Common Data Model ProjStatusTypeRuleEntity Details", group =>
            {
                ProjStatus = group.Add(new VocabularyKey(nameof(ProjStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjStatusRule = group.Add(new VocabularyKey(nameof(ProjStatusRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjType = group.Add(new VocabularyKey(nameof(ProjType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProjStatus { get; private set; }
        public VocabularyKey ProjStatusRule { get; private set; }
        public VocabularyKey ProjType { get; private set; }


    }
}