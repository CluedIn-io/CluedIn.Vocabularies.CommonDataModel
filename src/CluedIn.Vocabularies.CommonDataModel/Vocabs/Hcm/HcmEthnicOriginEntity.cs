using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmEthnicOriginEntityVocabulary : SimpleVocabulary
    {
        public HcmEthnicOriginEntityVocabulary()
        {
            VocabularyName = "HcmEthnicOriginEntity";
            KeyPrefix = "commonDataModel.hcmethnicoriginentity";
            KeySeparator = ".";
            Grouping = "/HcmEthnicOriginEntity";

            AddGroup("HcmEthnicOriginEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EthnicOriginId = group.Add(new VocabularyKey(nameof(EthnicOriginId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey EthnicOriginId { get; private set; }


    }
}