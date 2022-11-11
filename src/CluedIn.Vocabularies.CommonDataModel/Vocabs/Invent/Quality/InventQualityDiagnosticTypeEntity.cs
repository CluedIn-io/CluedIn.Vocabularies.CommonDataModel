using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityDiagnosticTypeEntityVocabulary : SimpleVocabulary
    {
        public InventQualityDiagnosticTypeEntityVocabulary()
        {
            VocabularyName = "InventQualityDiagnosticTypeEntity";
            KeyPrefix = "commonDataModel.inventqualitydiagnostictypeentity";
            KeySeparator = ".";
            Grouping = "/InventQualityDiagnosticTypeEntity";

            AddGroup("InventQualityDiagnosticTypeEntity Details", group =>
            {
                DiagnosticDescription = group.Add(new VocabularyKey(nameof(DiagnosticDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DiagnosticDescription { get; private set; }
        public VocabularyKey TypeId { get; private set; }


    }
}