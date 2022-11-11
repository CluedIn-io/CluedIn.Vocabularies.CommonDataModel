using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxVATSchedulesEntityVocabulary : SimpleVocabulary
    {
        public TaxVATSchedulesEntityVocabulary()
        {
            VocabularyName = "TaxVATSchedulesEntity";
            KeyPrefix = "commonDataModel.taxvatschedulesentity";
            KeySeparator = ".";
            Grouping = "/TaxVATSchedulesEntity";

            AddGroup("TaxVATSchedulesEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Schedule = group.Add(new VocabularyKey(nameof(Schedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Schedule { get; private set; }


    }
}