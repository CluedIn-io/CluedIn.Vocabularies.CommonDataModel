using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningCodeGroupEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningCodeGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollEarningCodeGroupEntity";
            KeyPrefix = "commonDataModel.payrollearningcodegroupentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningCodeGroupEntity";

            AddGroup("Common Data Model PayrollEarningCodeGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeGroup = group.Add(new VocabularyKey(nameof(EarningCodeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey EarningCodeGroup { get; private set; }


    }
}