using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxCustomsBillOfEntryNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxCustomsBillOfEntryNumberEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxCustomsBillOfEntryNumberEntity";
            KeyPrefix = "commonDataModel.taxcustomsbillofentrynumberentity";
            KeySeparator = ".";
            Grouping = "/TaxCustomsBillOfEntryNumberEntity";

            AddGroup("Common Data Model TaxCustomsBillOfEntryNumberEntity Details", group =>
            {
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillOfEntry = group.Add(new VocabularyKey(nameof(BillOfEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Closed = group.Add(new VocabularyKey(nameof(Closed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Date { get; private set; }
        public VocabularyKey BillOfEntry { get; private set; }
        public VocabularyKey Closed { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}