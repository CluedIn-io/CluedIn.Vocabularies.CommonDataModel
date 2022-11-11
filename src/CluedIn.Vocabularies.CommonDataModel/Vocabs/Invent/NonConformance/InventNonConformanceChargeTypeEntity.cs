using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventNonConformanceChargeTypeEntityVocabulary : SimpleVocabulary
    {
        public InventNonConformanceChargeTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventNonConformanceChargeTypeEntity";
            KeyPrefix = "commonDataModel.inventnonconformancechargetypeentity";
            KeySeparator = ".";
            Grouping = "/InventNonConformanceChargeTypeEntity";

            AddGroup("Common Data Model InventNonConformanceChargeTypeEntity Details", group =>
            {
                TypeCode = group.Add(new VocabularyKey(nameof(TypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TypeCode { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }


    }
}