using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerDefaultDescriptionParametersEntityVocabulary : SimpleVocabulary
    {
        public LedgerDefaultDescriptionParametersEntityVocabulary()
        {
            VocabularyName = "LedgerDefaultDescriptionParametersEntity";
            KeyPrefix = "commonDataModel.ledgerdefaultdescriptionparametersentity";
            KeySeparator = ".";
            Grouping = "/LedgerDefaultDescriptionParametersEntity";

            AddGroup("LedgerDefaultDescriptionParametersEntity Details", group =>
            {
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParameterNumber = group.Add(new VocabularyKey(nameof(ParameterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceTableName = group.Add(new VocabularyKey(nameof(ReferenceTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceFieldName = group.Add(new VocabularyKey(nameof(ReferenceFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactText = group.Add(new VocabularyKey(nameof(TransactText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Language { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ParameterNumber { get; private set; }
        public VocabularyKey ReferenceTableName { get; private set; }
        public VocabularyKey ReferenceFieldName { get; private set; }
        public VocabularyKey TransactText { get; private set; }


    }
}