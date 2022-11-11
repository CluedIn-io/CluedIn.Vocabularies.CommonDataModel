using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmSalesActivityTypeEntityVocabulary : SimpleVocabulary
    {
        public smmSalesActivityTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmSalesActivityTypeEntity";
            KeyPrefix = "commonDataModel.smmsalesactivitytypeentity";
            KeySeparator = ".";
            Grouping = "/smmSalesActivityTypeEntity";

            AddGroup("Common Data Model smmSalesActivityTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey TypeId { get; private set; }


    }
}