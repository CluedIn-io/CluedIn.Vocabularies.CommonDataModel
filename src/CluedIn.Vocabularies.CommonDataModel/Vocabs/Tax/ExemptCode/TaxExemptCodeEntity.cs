using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxExemptCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxExemptCodeEntityVocabulary()
        {
            VocabularyName = "TaxExemptCodeEntity";
            KeyPrefix = "commonDataModel.taxexemptcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxExemptCodeEntity";

            AddGroup("TaxExemptCodeEntity Details", group =>
            {
                TaxExemptCode = group.Add(new VocabularyKey(nameof(TaxExemptCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxExemptCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey Text { get; private set; }


    }
}