using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmSalesActivityTypeEntityVocabulary : SimpleVocabulary
    {
        public SmmSalesActivityTypeEntityVocabulary()
        {
            VocabularyName = "Smm Sales Activity Type Entity";
            KeyPrefix = "commonDataModel.smmsalesactivitytypeentity";
            KeySeparator = ".";
            Grouping = "/SmmSalesActivityTypeEntity";

            AddGroup("SmmSalesActivityTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TypeId { get; private set; }
    }
}