using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxBranchEntityVocabulary : SimpleVocabulary
    {
        public TaxBranchEntityVocabulary()
        {
            VocabularyName = "TaxBranchEntity";
            KeyPrefix = "commonDataModel.taxbranchentity";
            KeySeparator = ".";
            Grouping = "/TaxBranchEntity";

            AddGroup("TaxBranchEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeadOffice = group.Add(new VocabularyKey(nameof(HeadOffice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsLocation = group.Add(new VocabularyKey(nameof(LogisticsLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsLocation_LocationId = group.Add(new VocabularyKey(nameof(LogisticsLocation_LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address = group.Add(new VocabularyKey(nameof(Address), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey HeadOffice { get; private set; }
        public VocabularyKey LogisticsLocation { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LogisticsLocation_LocationId { get; private set; }
        public VocabularyKey Address { get; private set; }


    }
}