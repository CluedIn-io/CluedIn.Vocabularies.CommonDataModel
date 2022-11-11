using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxGSTReliefCategoryEntityVocabulary : SimpleVocabulary
    {
        public TaxGSTReliefCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxGSTReliefCategoryEntity";
            KeyPrefix = "commonDataModel.taxgstreliefcategoryentity";
            KeySeparator = ".";
            Grouping = "/TaxGSTReliefCategoryEntity";

            AddGroup("Common Data Model TaxGSTReliefCategoryEntity Details", group =>
            {
                ReliefCategoryEntityKey = group.Add(new VocabularyKey(nameof(ReliefCategoryEntityKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReliefCategoryId = group.Add(new VocabularyKey(nameof(ReliefCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReliefItemNumber = group.Add(new VocabularyKey(nameof(ReliefItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReliefSchedule = group.Add(new VocabularyKey(nameof(ReliefSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReliefCategoryEntityKey { get; private set; }
        public VocabularyKey ReliefCategoryId { get; private set; }
        public VocabularyKey ReliefItemNumber { get; private set; }
        public VocabularyKey ReliefSchedule { get; private set; }


    }
}