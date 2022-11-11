using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressFormatEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressFormatEntityVocabulary()
        {
            VocabularyName = "Common Data Model LogisticsAddressFormatEntity";
            KeyPrefix = "commonDataModel.logisticsaddressformatentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressFormatEntity";

            AddGroup("Common Data Model LogisticsAddressFormatEntity Details", group =>
            {
                AddressFormat = group.Add(new VocabularyKey(nameof(AddressFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AddressFormat { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}