using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxGSTMinorCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxGSTMinorCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxGSTMinorCodeEntity";
            KeyPrefix = "commonDataModel.taxgstminorcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxGSTMinorCodeEntity";

            AddGroup("Common Data Model TaxGSTMinorCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinorCode = group.Add(new VocabularyKey(nameof(MinorCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxComponent = group.Add(new VocabularyKey(nameof(TaxComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey MinorCode { get; private set; }
        public VocabularyKey TaxComponent { get; private set; }


    }
}