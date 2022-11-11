using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingDataImportVocabulary : SimpleVocabulary
    {
        public MarketingDataImportVocabulary()
        {
            VocabularyName = "MarketingDataImport";
            KeyPrefix = "commonDataModel.marketingdataimport";
            KeySeparator = ".";
            Grouping = "/MarketingDataImport";

            AddGroup("MarketingDataImport Details", group =>
            {
                dataversion = group.Add(new VocabularyKey(nameof(dataversion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importcompleted = group.Add(new VocabularyKey(nameof(importcompleted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingdataimportId = group.Add(new VocabularyKey(nameof(marketingdataimportId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                newName = group.Add(new VocabularyKey(nameof(newName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey dataversion { get; private set; }
        public VocabularyKey importcompleted { get; private set; }
        public VocabularyKey marketingdataimportId { get; private set; }
        public VocabularyKey newName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}