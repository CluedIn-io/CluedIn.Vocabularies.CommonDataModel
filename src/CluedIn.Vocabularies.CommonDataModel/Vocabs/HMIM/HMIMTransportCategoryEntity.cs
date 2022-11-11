using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMTransportCategoryEntityVocabulary : SimpleVocabulary
    {
        public HMIMTransportCategoryEntityVocabulary()
        {
            VocabularyName = "HMIMTransportCategoryEntity";
            KeyPrefix = "commonDataModel.hmimtransportcategoryentity";
            KeySeparator = ".";
            Grouping = "/HMIMTransportCategoryEntity";

            AddGroup("HMIMTransportCategoryEntity Details", group =>
            {
                TransportCategoryCode = group.Add(new VocabularyKey(nameof(TransportCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransportCategoryCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}