using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxServiceCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxServiceCodeEntityVocabulary()
        {
            VocabularyName = "Tax Service Code Entity";
            KeyPrefix = "commonDataModel.taxservicecodeentity";
            KeySeparator = ".";
            Grouping = "/TaxServiceCodeEntity";

            AddGroup("TaxServiceCodeEntity Details", group =>
            {
                ServiceCode = group.Add(new VocabularyKey(nameof(ServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ServiceCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}