using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventNonConformanceChargeTypeEntityVocabulary : SimpleVocabulary
    {
        public InventNonConformanceChargeTypeEntityVocabulary()
        {
            VocabularyName = "Invent Non Conformance Charge Type Entity";
            KeyPrefix = "commonDataModel.inventnonconformancechargetypeentity";
            KeySeparator = ".";
            Grouping = "/InventNonConformanceChargeTypeEntity";

            AddGroup("InventNonConformanceChargeTypeEntity Details", group =>
            {
                TypeCode = group.Add(new VocabularyKey(nameof(TypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeCode { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
    }
}