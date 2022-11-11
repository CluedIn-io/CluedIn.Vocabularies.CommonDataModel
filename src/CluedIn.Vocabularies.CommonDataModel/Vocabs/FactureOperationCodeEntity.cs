using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FactureOperationCodeEntityVocabulary : SimpleVocabulary
    {
        public FactureOperationCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model FactureOperationCodeEntity";
            KeyPrefix = "commonDataModel.factureoperationcodeentity";
            KeySeparator = ".";
            Grouping = "/FactureOperationCodeEntity";

            AddGroup("Common Data Model FactureOperationCodeEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Derive = group.Add(new VocabularyKey(nameof(Derive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationTypeDefault = group.Add(new VocabularyKey(nameof(OperationTypeDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Derive { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OperationTypeDefault { get; private set; }


    }
}